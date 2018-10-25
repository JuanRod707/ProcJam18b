using System;

namespace Weapons.Generation
{
    [Serializable]
    public class WeaponGenertationData
    {
        public float MinRateOfFire;
        public float MaxRateOfFire;

        public float MinDamagePerRound;
        public float MaxDamagePerRound;

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
