﻿namespace Weapons.Stats
{
    public class SmgStats : WeaponStats
    {
        public ItemQuality Quality { get; set; }
        public float RateOfFire { get; set; }
        public int DamagePerRound { get; set; }
        public int AmmoPerMag { get; set; }
        public float Accuracy { get; set; }
        public float MinAccuracy { get; set; }
        public float Recoil { get; set; }
        public float AimRecovery { get; set; }
        public float ReloadTime { get; set; }
    }
}
