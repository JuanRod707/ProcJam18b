using System.Linq;
using UnityEngine;
using Weapons.Generation;
using Weapons.Stats;

namespace Weapons
{
    public class Shotgun : BaseWeapon
    {
        private ShotgunStats myStats;

        void Start()
        {
            Initialize(WeaponGenerator.GenerateNewShotgun(ItemQuality.Common));
            myStats = stats as ShotgunStats;
        }

        public override void Attack()
        {
            if (!isCycling && CurrentAmmo > 0)
            {
                foreach (var _ in Enumerable.Range(0, myStats.PelletCount))
                {
                    FirePellet();
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

        void FirePellet()
        { 
            var aimPoint = GetRandomArcPoint();
            var firePosition = transform.position;
            var ray = new Ray(firePosition, aimPoint - firePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, stats.Range, layer))
            {
                display.DisplayHitScenery(ray.GetPoint(hit.distance - 0.5f));
                display.DisplayShot(hit.point);
            }
        }
    }
}
