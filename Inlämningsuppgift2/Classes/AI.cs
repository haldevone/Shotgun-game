using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2.Classes
{
    public class AI : GameRules
    {
        private int _ammoAI;
        private int _lifeAI;
        private ActionType _actionAI;
        public event Action<ActionType> OnActionAI;
        public event Action OnReloadAI;
        public event Action<int> OnShotAI;
        public event Action OnRemoveLifeAI;
        public event Action<bool> OnBlockShootBtn;
        public event Action<bool> OnBlockReloadBtn;
        public event Action<string> OnSetLabelTextAI;

        public override int Ammo { get => _ammoAI; set => _ammoAI = value; }
        public override int life { get => _lifeAI; set => _lifeAI = value; }
        public override ActionType ActionChoice { get => _actionAI; set => _actionAI = value; }

        public AI()
        {
            Reset();
        }



        public override bool NoAmmo()
        {
            if (_ammoAI == 0)
            {
                return true;
            }
            return false;
        }
        public override void Defend()
        {
            //
        }

        public override bool IsDead()
        {
            if (life == 0)
            {
                Sound.PlaySound(SoundLibrary.AiDead);
                return true;
            }
            return false;
        }

        public override void IsShot()
        {
            life--;
            OnRemoveLifeAI?.Invoke();
        }

        public override bool ReloadFull()
        {
            if (_ammoAI == MaxAmmo)
            {
                return true;
            }
            return false;
        }
        public override bool Shotgun()
        {
            if (_ammoAI >= 3)
            {
                return true;
            }
            return false;
        }

        public bool SetAIAction()
        {
            Random random = new Random();
            int action;

            if (NoAmmo())
            {
                if (Game.Instance.player.NoAmmo())
                {
                    action = 2;
                }
                else
                {
                    action = random.Next(2, 4);
                }
            }
            else if(Shotgun())
            {
                action = random.Next(3, 5); //High chance pulling off
            }
            else
            {
                action = random.Next(1, 4);
            }

            switch ((ActionType)action)
            {
                case ActionType.Shoot:
                    if (!NoAmmo())
                    {
                        _actionAI = ActionType.Shoot;
                        OnActionAI?.Invoke(_actionAI);
                        return true;
                    }
                    else
                    {
                        OnBlockShootBtn?.Invoke(false);
                    }
                    break;
                case ActionType.Reload:
                    if (!ReloadFull())
                    {
                        _actionAI = ActionType.Reload;
                        OnActionAI?.Invoke(_actionAI);
                        return true;
                    }
                    else
                    {
                        OnBlockReloadBtn?.Invoke(false);
                    }
                    break;
                case ActionType.Defend:
                    _actionAI = ActionType.Defend;
                    OnActionAI?.Invoke(_actionAI);
                    Defend();
                    return true;
                case ActionType.Shotgun:
                    _actionAI = ActionType.Shotgun;
                    OnActionAI?.Invoke(_actionAI);
                    return true;
            }

            return false;
        }

        public void UpdateActionOnPlayAI()
        {
            switch (_actionAI)
            {
                case ActionType.Shoot:
                    OnShotAI?.Invoke(1);
                    _ammoAI--;
                    OnSetLabelTextAI?.Invoke("ROBOT, SHOOTING...");
                    break;
                case ActionType.Reload:
                    OnReloadAI?.Invoke();
                    _ammoAI++;
                    OnSetLabelTextAI?.Invoke("ROBOT, RELOADING...");
                    break;
                case ActionType.Defend:
                    OnSetLabelTextAI?.Invoke("ROBOT. DEFENDING...");
                    break;
                case ActionType.Shotgun:
                    OnSetLabelTextAI?.Invoke("ROBOT, SUPER SHOTGUN!...");
                    _ammoAI = _ammoAI - 3;
                    OnShotAI?.Invoke(3);
                    break;
            }
        }

        public void ResetActionAI()
        {
            _actionAI = ActionType.None;
        }

        public override void Reset()
        {
            _ammoAI = 0;
            _lifeAI = 3;
        }
    }
}

