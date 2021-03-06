﻿using System.Collections;
using Enemies;
using Player;
using UnityEngine;
using Weapons.Stats;
using Random = UnityEngine.Random;

namespace Weapons
{
    [RequireComponent(typeof(WeaponDisplay))]

    public abstract class BaseWeapon : MonoBehaviour, Weapon
    {
        public int CurrentAmmo { get; protected set; }
        public Camera cam;
        public LayerMask layer;
        public AmmoType AmmoType;

        protected WeaponDisplay display;
        protected WeaponStats stats;
        protected bool isCycling;
        protected bool isReloading;
        protected float accuracyModifier;
        protected float currentAccuracy;
        protected PlayerStats player;
        
        public float CurrentAccuracy => currentAccuracy + accuracyModifier;
        public float Inaccuracy => 1 - (100f / CurrentAccuracy);

        public WeaponStats GetWeaponStats() => stats;

        protected bool CanFire => !isCycling && !isReloading && CurrentAmmo > 0;

        public virtual void Initialize(WeaponStats stats)
        {
            this.stats = stats;
            currentAccuracy = this.stats.Accuracy;
            CurrentAmmo = this.stats.AmmoPerMag;

            player = GameObject.Find("Player").GetComponent<PlayerStats>();
            display = GetComponent<WeaponDisplay>();

            Reload();
        }

        public void Reload()
        {
            if (!isReloading)
            {
                display.Reload();
                StartCoroutine(WaitForReload());
            }
        }

        void EndReload()
        {
            isReloading = false;
            CalculateReload();
            player.UpdateUICounter(CurrentAmmo, AmmoType);
        }

        void CalculateReload()
        {
            player.AddAmmo(AmmoType, CurrentAmmo);
            CurrentAmmo = player.GetAmmo(AmmoType) >= stats.AmmoPerMag ? stats.AmmoPerMag : player.GetAmmo(AmmoType);
            player.SubstractAmmo(AmmoType, CurrentAmmo);
        }

        public virtual void Attack()
        {
            if (CanFire)
            {
                var shotLine = cam.transform.forward + Random.insideUnitSphere * Inaccuracy * 0.02f;
                var ray = new Ray(cam.transform.position, shotLine);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit, 100, layer))
                {
                    DamageTarget(hit);
                    display.DisplayHitScenery(ray.GetPoint(hit.distance - 0.1f));
                    display.DisplayShot(hit.point);
                }

                if (currentAccuracy > 1 && currentAccuracy > stats.MinAccuracy)
                {
                    currentAccuracy -= stats.Recoil;
                }

                CurrentAmmo--;
                display.Fire();
                StartCoroutine(CycleBullet());
                player.UpdateUICounter(CurrentAmmo, AmmoType);
            }
        }

        protected void DamageTarget(RaycastHit hit)
        {
            var hitPoint = hit.collider.GetComponent<HitPoint>();
            if (hitPoint)
                hitPoint.ReceiveDamage(stats.DamagePerRound);
        }

        protected void Update()
        {
            if (!isCycling && currentAccuracy < stats.Accuracy)
            {
                currentAccuracy += stats.AimRecovery;
            }
        }

        protected IEnumerator CycleBullet()
        {
            isCycling = true;
            yield return new WaitForSeconds(stats.RateOfFire);
            isCycling = false;
        }

        IEnumerator WaitForReload()
        {
            isReloading = true;
            yield return new WaitForSeconds(stats.ReloadTime);
            EndReload();
        }
    }
}
