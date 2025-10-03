using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2.Classes
{
    public abstract class GameRules
    {
        public abstract int Ammo { get; set; }
        public int MaxAmmo { get; } = 10;
        public abstract int life { get; set; }
        public int MaxLife { get; } = 3;

        public abstract bool NoAmmo();

        public abstract bool ReloadFull();

        public abstract void Defend();

        public abstract void IsShot();

        public abstract bool IsDead();

        public abstract void Reset();

        public abstract bool Shotgun();

        public abstract ActionType ActionChoice { get; set; }

    }

    public enum ActionType { None, Shoot, Reload, Defend, Shotgun }


}
