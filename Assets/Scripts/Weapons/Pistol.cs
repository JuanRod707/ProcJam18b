using UnityEngine;
using Weapons.Generation;
using Weapons.Stats;

namespace Weapons
{
    public class Pistol : BaseWeapon
    {
        void Start()
        {
            Initialize(WeaponGenerator.GenerateNewPistol(ItemQuality.Common));
        }
    }
}
