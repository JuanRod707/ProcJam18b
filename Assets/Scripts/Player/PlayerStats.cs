using System.Collections.Generic;
using UI;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        public StatusBar UI;

        public int StartingPistolBullets;
        public int StartingSmgBullets;
        public int StartingShotgunShells;

        public int MaxPistolBullets;
        public int MaxSmgBullets;
        public int MaxShotgunShells;

        private Dictionary<AmmoType, AmmoPool> ammoInventory = new Dictionary<AmmoType, AmmoPool>();

        void Start()
        {
            ammoInventory.Add(AmmoType.Pistol, new AmmoPool(StartingPistolBullets, MaxPistolBullets));
            ammoInventory.Add(AmmoType.Smg, new AmmoPool(StartingSmgBullets, MaxSmgBullets));
            ammoInventory.Add(AmmoType.Shotgun, new AmmoPool(StartingShotgunShells, MaxShotgunShells));
        }

        public void AddAmmo(AmmoType ammoType, int amount) =>
            ammoInventory[ammoType].AddAmmo(amount);

        public void SubstractAmmo(AmmoType ammoType, int amount) => ammoInventory[ammoType].SpendAmmo(amount);

        public int GetAmmo(AmmoType ammoType) => ammoInventory[ammoType].CurrentAmmo;

        public void UpdateUICounter(int currentAmmo, AmmoType ammoType) => 
            UI.Ammo.SetValues(currentAmmo, ammoInventory[ammoType].CurrentAmmo);
    }

    public enum AmmoType
    {
        Pistol,
        Smg,
        Shotgun
    }

    class AmmoPool
    {
        private int currentAmmo;
        private int maxAmmo;

        public AmmoPool(int starting, int max)
        {
            currentAmmo = starting;
            maxAmmo = max;
        }

        public int CurrentAmmo => currentAmmo;

        public void AddAmmo(int ammo)
        {
            currentAmmo += ammo;
            currentAmmo = currentAmmo > maxAmmo ? maxAmmo : currentAmmo;
        }

        public void SpendAmmo(int amount) => 
            currentAmmo = currentAmmo > amount ? currentAmmo - amount : 0;
    }
}
