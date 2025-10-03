using System.Media;

namespace Inlämningsuppgift2.Classes
{
    public class Game
    {
        private static Game instance;
        public static Game Instance => instance ??= new Game();
        public Player player { get; }
        public AI ai { get; }
        public User user { get; set; }
        public event Action<bool> OnPlay;
        public event Action<string> OnPlayInfo;
        const int scoreWin = 30;
        const int scoreLose = 5;
        const int scoreDefend = 5;
        const int scoreShoot = 2;


        public Game()
        {
            player = new Player();
            ai = new AI();
        }

        public void PlayNextTurn()
        {
            OnPlay?.Invoke(true);
            DelayOnPlayTimer();
            ActionType playerAction = player.ActionChoice;
            ai.SetAIAction();
            player.UpdateActionOnPlay();
            ai.UpdateActionOnPlayAI();

            switch (ai.ActionChoice)
            {
                case ActionType.Shoot:
                    if (playerAction == ActionType.Shoot)
                    {
                        //Both get shot lose life
                        player.PlayerScore += scoreShoot;
                        Shot(3, false);
                    }
                    else if (playerAction == ActionType.Defend)
                    {
                        //Defend point for AI
                    }
                    else if (playerAction == ActionType.Reload)
                    {
                        //Player gets shot
                        Shot(1, false);
                    }
                    else if (playerAction == ActionType.Shotgun)
                    {
                        //Both get shot lose life
                        player.PlayerScore += scoreShoot;
                        Shot(3, true);
                    }
                        break;
                case ActionType.Defend:
                    if (playerAction == ActionType.Shotgun)
                    {
                        //AI gets shot
                        Shot(2, true);
                    }
                    else if (playerAction == ActionType.Shoot)
                    {
                        //Defend point player
                        Sound.PlaySound(SoundLibrary.ShotGun);
                        player.PlayerScore += scoreDefend;
                    }else if(playerAction == ActionType.Shotgun)
                    {
                        Shot(2, true);
                    }else if (playerAction == ActionType.Reload)
                    {
                        Sound.PlaySound(SoundLibrary.Reload);
                    }
                    else
                    {
                        Sound.PlaySound(SoundLibrary.Shield);
                    }
                    break;
                case ActionType.Reload:
                    if (playerAction == ActionType.Shoot)
                    {
                        //AI gets shot
                        player.PlayerScore += scoreShoot;
                        Shot(2, false);
                    }else if(playerAction == ActionType.Shotgun)
                    {
                        //AI gets shot
                        player.PlayerScore += scoreShoot;
                        Shot(2, true);
                    }else if(playerAction == ActionType.Defend)
                    {
                        Sound.PlaySound(SoundLibrary.Shield);
                    }
                    else
                    {
                        Sound.PlaySound(SoundLibrary.Reload);
                    }
                        break;
                case ActionType.Shotgun:
                    if (playerAction == ActionType.Shotgun)
                    {
                        //Both gets shot
                        player.PlayerScore += scoreShoot;
                        Shot(3, true);
                    }else if (playerAction == ActionType.Shoot)
                    {
                        //Both gets shot
                        Shot(3, true);
                    }
                    else
                    {
                        //Player gets shot
                        Shot(1, true);
                    }
                        break;
            }
            CheckIfDead();

        }

        private void Shot(int infoNr, bool supersound)
        {
            if (supersound)
            {
                Sound.PlaySound(SoundLibrary.SuperShotgun);
            }
            else
            {
                Sound.PlaySound(SoundLibrary.ShotGun);
            }
                switch (infoNr)
                {
                    case 1:
                        player.IsShot();
                        OnPlayInfo("Player is SHOT!");
                        break;
                    case 2:
                        ai.IsShot();
                        OnPlayInfo("AI is SHOT!");
                        break;
                    case 3:
                        player.IsShot();
                        ai.IsShot();
                        OnPlayInfo("Both opponents are SHOT!!!");
                        break;

                }
        }

        private void CheckIfDead()
        {
            if (ai.IsDead() && player.IsDead())
            {
                player.PlayerScore += scoreLose;
                EndGame("TIE!", "Both Opponents died!", false, player.PlayerScore);
            }
            else if (player.IsDead())
            {
                player.PlayerScore += scoreLose;
                EndGame("AI WINS!", "Player is dead!", false, player.PlayerScore);
            }
            else if (ai.IsDead())
            {
                player.PlayerScore += scoreWin;
                EndGame("PLAYER WINS!", "AI is dead!", true, player.PlayerScore);
            }
        }

        public async Task EndGame(string header, string message, bool playerWin, int score)
        {
            await Task.Delay(2000);

            Form4Complete gameComplete = new Form4Complete();
            gameComplete.Show();
            gameComplete.InitiateForm4(header, message, playerWin, player, ai, score);
        }

        public bool Play()
        {
            if (player.ActionChoice != ActionType.None)
            {
                PlayNextTurn();
                player.ResetActionPlayer();
                return true;
            }
            return false;
        }

        private async Task DelayOnPlayTimer()
        {
            await Task.Delay(2500);
            OnPlay?.Invoke(false);
            OnPlayInfo("");
        }

    }
}
