using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        public int StartingPistolBullets;
        public int StartingSmgBullets;
        public int StartingShotgunShells;

        private Dictionary<AmmoType, int> ammoInventory = new Dictionary<AmmoType, int>();

        void Start()
        {
            ammoInventory.Add(AmmoType.Pistol, StartingPistolBullets);
            ammoInventory.Add(AmmoType.Smg, StartingSmgBullets);
            ammoInventory.Add(AmmoType.Shotgun, StartingShotgunShells);
        }

        public void AddAmmo(AmmoType ammoType, int amount) =>
            ammoInventory[ammoType] += amount;


        public void SubstractAmmo(AmmoType ammoType, int amount)
        {
            if (ammoInventory[ammoType] >= amount)
                ammoInventory[ammoType] -= amount;
            else
                ammoInventory[ammoType] = 0;
        }

        public int GetAmmo(AmmoType ammoType) => ammoInventory[ammoType];
    }

    public enum AmmoType
    {
        Pistol,
        Smg,
        Shotgun
    }
}
