using System.Collections;
using UnityEngine;

namespace Enemies
{
    public class EnemyGun : MonoBehaviour
    {
        public GameObject Projectile;
        public Transform FiringPosition;
        public float RateOfFire;
        
        private bool isCiclying;

        public void Fire()
        {
            if (!isCiclying)
                Shoot();
        }

        IEnumerator Cycle()
        {
            isCiclying = true;
            yield return new WaitForSeconds(RateOfFire);
            isCiclying = false;
        }

        void Shoot()
        {
            Instantiate(Projectile, FiringPosition.transform.position, FiringPosition.rotation);
            StartCoroutine(Cycle());
        }
    }
}
