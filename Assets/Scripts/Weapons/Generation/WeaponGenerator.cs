using Helpers;
using Weapons.Stats;

namespace Weapons.Generation
{
    public class WeaponGenerator
    {
        public static PistolStats GenerateNewPistol(ItemQuality quality)
        {
            var genData = PistolGenerationPresets.GenData[quality];
            var stats = new PistolStats();

            stats.Accuracy = RandomService.GetRandom(genData.MinAccuracy, genData.MaxAccuracy);
            stats.MinAccuracy = stats.Accuracy - 20;
            stats.AimDistance = 50f;
            stats.AimRecovery = 0.8f;
            stats.Quality = quality;
            stats.DamagePerRound = RandomService.GetRandom(genData.MinDamagePerRound, genData.MaxDamagePerRound);
            stats.Range = RandomService.GetRandom(genData.MinRange, genData.MaxRange);
            stats.RateOfFire = RandomService.GetRandom(genData.MinRateOfFire, genData.MaxRateOfFire);
            stats.Recoil = RandomService.GetRandom(genData.MinRecoil, genData.MaxRecoil);
            stats.AmmoPerMag = RandomService.GetRandom(genData.MinAmmoPerMag, genData.MaxAmmoPerMag);

            return stats;
        }

        public static SmgStats GenerateNewSmg(ItemQuality quality)
        {
            var genData = SmgGenerationPresets.GenData[quality];
            var stats = new SmgStats();

            stats.Accuracy = RandomService.GetRandom(genData.MinAccuracy, genData.MaxAccuracy);
            stats.MinAccuracy = stats.Accuracy - 20;
            stats.AimDistance = 50f;
            stats.AimRecovery = 0.8f;
            stats.Quality = quality;
            stats.DamagePerRound = RandomService.GetRandom(genData.MinDamagePerRound, genData.MaxDamagePerRound);
            stats.Range = RandomService.GetRandom(genData.MinRange, genData.MaxRange);
            stats.RateOfFire = RandomService.GetRandom(genData.MinRateOfFire, genData.MaxRateOfFire);
            stats.Recoil = RandomService.GetRandom(genData.MinRecoil, genData.MaxRecoil);
            stats.AmmoPerMag = RandomService.GetRandom(genData.MinAmmoPerMag, genData.MaxAmmoPerMag);

            return stats;
        }

        public static ShotgunStats GenerateNewShotgun(ItemQuality quality)
        {
            var genData = ShotgunGenerationPresets.GenData[quality];
            var stats = new ShotgunStats();

            stats.Accuracy = RandomService.GetRandom(genData.MinAccuracy, genData.MaxAccuracy);
            stats.MinAccuracy = stats.Accuracy - 20;
            stats.AimDistance = 50f;
            stats.AimRecovery = 0.8f;
            stats.Quality = quality;
            stats.DamagePerRound = RandomService.GetRandom(genData.MinDamagePerRound, genData.MaxDamagePerRound);
            stats.Range = RandomService.GetRandom(genData.MinRange, genData.MaxRange);
            stats.RateOfFire = RandomService.GetRandom(genData.MinRateOfFire, genData.MaxRateOfFire);
            stats.Recoil = RandomService.GetRandom(genData.MinRecoil, genData.MaxRecoil);
            stats.AmmoPerMag = RandomService.GetRandom(genData.MinAmmoPerMag, genData.MaxAmmoPerMag);
            stats.PelletCount = 8;

            return stats;
        }
    }
}

