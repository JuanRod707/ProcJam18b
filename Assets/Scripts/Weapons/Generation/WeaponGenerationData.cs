using System;

namespace Weapons.Generation
{
    [Serializable]
    public class WeaponGenertationData
    {
        public float MinRateOfFire;
        public float MaxRateOfFire;

        public int MinDamagePerRound;
        public int MaxDamagePerRound;

        public int MinAmmoPerMag;
        public int MaxAmmoPerMag;

        public float MinAccuracy;
        public float MaxAccuracy;

        public float MinRange;
        public float MaxRange;

        public float MinRecoil;
        public float MaxRecoil;
    }
}
