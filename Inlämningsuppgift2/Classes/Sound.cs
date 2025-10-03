using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2.Classes
{
    public static class Sound
    {
        static SoundPlayer shotgunSound = new SoundPlayer(Properties.Resources.shotgun);
        static SoundPlayer reloadSound = new SoundPlayer(Properties.Resources.reloadSound);
        static SoundPlayer shieldSound = new SoundPlayer(Properties.Resources.shieldSound);
        static SoundPlayer supershotgunSound = new SoundPlayer(Properties.Resources.supershotgunSound);
        static SoundPlayer aiDeadSound = new SoundPlayer(Properties.Resources.aiDead);
        static SoundPlayer playerDeadSound = new SoundPlayer(Properties.Resources.playerDead);

        public static void PlaySound(SoundLibrary sound)
        {
            switch (sound)
            {
                case SoundLibrary.ShotGun:
                    shotgunSound.Play();
                    break;
                case SoundLibrary.Reload:
                    reloadSound.Play();
                    break;
                case SoundLibrary.Shield:
                    shieldSound.Play();
                    break;
                case SoundLibrary.SuperShotgun:
                    supershotgunSound.Play();
                    break;
                case SoundLibrary.AiDead:
                    aiDeadSound.Play();
                    break;
                case SoundLibrary.PlayerDead:
                    playerDeadSound.Play();
                    break;
                default:
                    break;
            }
        }
    }
}

public enum SoundLibrary { ShotGun, Reload, Shield, SuperShotgun, AiDead, PlayerDead}

