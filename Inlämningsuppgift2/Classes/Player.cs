using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2.Classes
{
    public class Player : GameRules
    {
        private int _ammo;
        private int _life;
        private int _score;
        private ActionType _action;
        public event Action<ActionType> OnAction;
        public event Action OnReload;
        public event Action<int> OnShot;
        public event Action OnRemoveLife;
        public event Action<bool> OnBlockShootBtn;
        public event Action<bool> OnBlockReloadBtn;
        public event Action<string> OnSetLabelText;

        public override int Ammo { get => _ammo; set => _ammo = value; }
        public override int life { get => _life; set => _life = value; }
        public override ActionType ActionChoice { get => _action; set => _action = value; }
        public int PlayerScore { get => _score; set => _score = value; }

        public Player()
        {
            _ammo = 0;
            _life = 3;
        }
        public override bool NoAmmo()
        {
            if (_ammo == 0)
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
                Sound.PlaySound(SoundLibrary.PlayerDead);
                return true;
            }
            return false;
        }

        public override void IsShot()
        {
            life--;
            OnRemoveLife?.Invoke();
        }

        public override bool ReloadFull()
        {
            if (_ammo == MaxAmmo)
            {
                return true;
            }
            return false;
        }

        public override bool Shotgun()
        {
            if(_ammo >= 3)
            {
                return true;
            }
            return false;
        }

        public bool SetAction(ActionType action)
        {
            switch (action)
            {
                case ActionType.None:
                    return false;
                case ActionType.Shoot:
                    if (!NoAmmo())
                    {
                        _action = ActionType.Shoot;
                        OnAction?.Invoke(_action);
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
                        _action = ActionType.Reload;
                        OnAction?.Invoke(_action);
                        return true;
                    }
                    else
                    {
                        OnBlockReloadBtn?.Invoke(false);
                    }
                        break;
                case ActionType.Defend:
                    _action = ActionType.Defend;
                    OnAction?.Invoke(_action);
                    Defend();
                    return true;
                case ActionType.Shotgun:
                    _action = ActionType.Shotgun;
                    OnAction?.Invoke(_action);
                    return true;
            }
            return false;
        }

        public void UpdateActionOnPlay()
        {
            switch (_action)
            {
                case ActionType.Shoot:
                    OnShot?.Invoke(1);
                    _ammo--;
                    OnSetLabelText?.Invoke("SHOOTING...");
                    break;
                case ActionType.Reload:
                    OnReload?.Invoke();
                    _ammo++;
                    OnSetLabelText?.Invoke("RELOADING...");
                    break;
                case ActionType.Defend:
                    OnSetLabelText?.Invoke("DEFENDING...");
                    break;
                case ActionType.Shotgun:
                    OnSetLabelText?.Invoke("SUPER SHOTGUN!...");
                    _ammo = _ammo - 3;
                    OnShot?.Invoke(3);
                    break;
            }
        }
        
        public void ResetActionPlayer()
        {
            _action = ActionType.None;
        }
        public override void Reset()
        {
            _ammo = 0;
            _life = 3;
        }


    }
}
