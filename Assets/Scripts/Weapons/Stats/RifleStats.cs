namespace Weapons.Stats
{
    public class RifleStats : WeaponStats
    {
        public ItemQuality Quality { get; set; }
        public float RateOfFire { get; set; }
        public float DamagePerRound { get; set; }
        public int AmmoPerMag { get; set; }
        public float Accuracy { get; set; }
        public float MinAccuracy { get; set; }
        public float AimDistance { get; set; }
        public float Range { get; set; }
        public float Recoil { get; set; }
        public float AimRecovery { get; set; }
    }
}
