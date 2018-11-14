using Assets.Scripts.Weapons.Pickups;
using Helpers;
using Player;
using UnityEngine;

namespace Assets.Scripts.Movement
{
    public class PickupDetection : MonoBehaviour
    {
        public PlayerStats Player;

        private void OnTriggerEnter(Collider other)
        {
            var pickup = other.GetComponent<AmmoPickup>();
            if (pickup)
            {
                Player.AddAmmo(AmmoType.Pistol, RandomService.GetRandom(5, 10));
                Player.AddAmmo(AmmoType.Shotgun, RandomService.GetRandom(2, 6));
                Player.AddAmmo(AmmoType.Shotgun, RandomService.GetRandom(8, 17));
                pickup.Consume();
            }
        }
    }
}
