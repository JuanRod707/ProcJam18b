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
            if (CanFire)
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
            var shotLine = cam.transform.forward + Random.insideUnitSphere * Inaccuracy * 0.02f;
            var ray = new Ray(cam.transform.position, shotLine);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, layer))
            {
                display.DisplayHitScenery(ray.GetPoint(hit.distance - 0.1f));
                display.DisplayShot(hit.point);
            }
        }
    }
}
