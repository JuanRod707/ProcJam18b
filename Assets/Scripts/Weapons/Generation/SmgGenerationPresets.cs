using System.Collections.Generic;
using Weapons.Stats;

namespace Weapons.Generation
{
    static class SmgGenerationPresets
    {
        public static Dictionary<ItemQuality, WeaponGenertationData> GenData { get; }

        static SmgGenerationPresets()
        {
            GenData = new Dictionary<ItemQuality, WeaponGenertationData>();
            GenData.Add(ItemQuality.Common, CreateCommonData());
            GenData.Add(ItemQuality.Uncommon, CreateUncommonData());
            GenData.Add(ItemQuality.Rare, CreateRareData());
            GenData.Add(ItemQuality.Legendary, CreateLegendaryData());
        }

        static WeaponGenertationData CreateCommonData()
        {
            return new WeaponGenertationData
            {
                MinAccuracy = 36f,
                MaxAccuracy = 42f,
                MinAmmoPerMag = 30,
                MaxAmmoPerMag = 45,
                MinDamagePerRound = 2,
                MaxDamagePerRound = 5,
                MinRange = 50,
                MaxRange = 60,
                MinRateOfFire = 0.05f,
                MaxRateOfFire = 0.1f,
                MinRecoil = 7,
                MaxRecoil = 9
            };
        }

        static WeaponGenertationData CreateUncommonData()
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

        static WeaponGenertationData CreateRareData()
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

        static WeaponGenertationData CreateLegendaryData()
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
