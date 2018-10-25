using Weapons.Generation;
using Weapons.Stats;

namespace Weapons
{
    public class Smg : BaseWeapon
    {
        void Start()
        {
            Initialize(WeaponGenerator.GenerateNewSmg(ItemQuality.Common));
        }
    }
}
