using System.Collections.Generic;
using Weapons.Stats;

namespace Weapons.Generation
{
    static class PistolGenerationPresets
    {
        public static Dictionary<ItemQuality, WeaponGenertationData> GenData { get; }

        static PistolGenerationPresets()
        {
            GenData = new Dictionary<ItemQuality, WeaponGenertationData>();
            GenData.Add(ItemQuality.Common, CreateCommonPistolData());
            GenData.Add(ItemQuality.Uncommon, CreateUncommonPistolData());
            GenData.Add(ItemQuality.Rare, CreateRarePistolData());
            GenData.Add(ItemQuality.Legendary, CreateLegendaryPistolData());
        }

        static WeaponGenertationData CreateCommonPistolData()
        {
            return new WeaponGenertationData
            {
                MinAccuracy = 46f,
                MaxAccuracy = 52f,
                MinAmmoPerMag = 20,
                MaxAmmoPerMag = 25,
                MinDamagePerRound = 2,
                MaxDamagePerRound = 5,
                MinRange = 50,
                MaxRange = 60,
                MinRateOfFire = 0.3f,
                MaxRateOfFire = 0.6f,
                MinRecoil = 5,
                MaxRecoil = 8
            };
        }

        static WeaponGenertationData CreateUncommonPistolData()
        {
            return new WeaponGenertationData
            {
                MinAccuracy = 46f,
                MaxAccuracy = 52f,
                MinAmmoPerMag = 20,
                MaxAmmoPerMag = 25,
                MinDamagePerRound = 2,
                MaxDamagePerRound = 5,
                MinRange = 50,
                MaxRange = 60,
                MinRateOfFire = 0.5f,
                MaxRateOfFire = 0.8f,
                MinRecoil = 5,
                MaxRecoil = 8
            };
        }

        static WeaponGenertationData CreateRarePistolData()
        {

            return new WeaponGenertationData
            {
                MinAccuracy = 46f,
                MaxAccuracy = 52f,
                MinAmmoPerMag = 20,
                MaxAmmoPerMag = 25,
                MinDamagePerRound = 2,
                MaxDamagePerRound = 5,
                MinRange = 50,
                MaxRange = 60,
                MinRateOfFire = 0.5f,
                MaxRateOfFire = 0.8f,
                MinRecoil = 5,
                MaxRecoil = 8
            };
        }

        static WeaponGenertationData CreateLegendaryPistolData()
        {
            return new WeaponGenertationData
            {
                MinAccuracy = 46f,
                MaxAccuracy = 52f,
                MinAmmoPerMag = 20,
                MaxAmmoPerMag = 25,
                MinDamagePerRound = 2,
                MaxDamagePerRound = 5,
                MinRange = 50,
                MaxRange = 60,
                MinRateOfFire = 0.5f,
                MaxRateOfFire = 0.8f,
                MinRecoil = 5,
                MaxRecoil = 8
            };
        }
    }
}
