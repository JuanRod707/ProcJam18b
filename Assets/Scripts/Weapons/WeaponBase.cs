using System.Collections;
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

        protected WeaponDisplay display;
        protected WeaponStats stats;
        protected bool isCycling;
        protected int currentFiringMode;
        protected float accuracyModifier;
        protected float currentAccuracy;
        
        public float CurrentAccuracy => currentAccuracy + accuracyModifier;
        public float Inaccuracy => 1 - (100f / CurrentAccuracy);

        public WeaponStats GetWeaponStats() => stats;

        public virtual void Initialize(WeaponStats stats)
        {
            this.stats = stats;
            currentAccuracy = this.stats.Accuracy;
            CurrentAmmo = this.stats.AmmoPerMag;

            display = GetComponent<WeaponDisplay>();
        }

        public void Reload() => CurrentAmmo = stats.AmmoPerMag;

        public virtual void Attack()
        {
            if (!isCycling && CurrentAmmo > 0)
            {
                var shotLine = cam.transform.forward + Random.insideUnitSphere * Inaccuracy * 0.02f;
                var ray = new Ray(cam.transform.position, shotLine);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit, stats.Range, layer))
                {
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
            }
        }

        void Update()
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
    }
}
