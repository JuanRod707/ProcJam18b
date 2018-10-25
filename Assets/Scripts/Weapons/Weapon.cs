using System;
using UnityEngine;
using Weapons.Stats;

namespace Weapons
{
    public interface Weapon
    {
        float CurrentAccuracy { get; }
        float Inaccuracy { get; }
        int CurrentAmmo { get; }

        void Attack();
        void Reload();
        WeaponStats GetWeaponStats();
    }
}
