namespace Weapons.Stats
{
    public interface WeaponStats
    {
        ItemQuality Quality { get; set; }
        float RateOfFire { get; set; }
        float DamagePerRound { get; set; }
        int AmmoPerMag { get; set; }

        float Accuracy { get; set; }
        float MinAccuracy { get; set; }
        float AimDistance { get; set; }

        float Range { get; set; }
        float Recoil { get; set; }
        float AimRecovery { get; set; }
    }
}
