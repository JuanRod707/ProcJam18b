using System.Collections;
using UnityEngine;

namespace Enemies
{
    public class EnemyGun : MonoBehaviour
    {
        public GameObject Projectile;
        public Transform FiringPosition;
        public float RateOfFire;
        public float AimSpeed;
        
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

        public void Aim(Transform target)
        {
            var targetRelative = transform.InverseTransformPoint(target.position);
            if (targetRelative.y > 0)
                PitchDown();
            else
                PitchUp();
        }

        void PitchDown()
        {
            transform.Rotate(-Vector3.right * AimSpeed);
        }

        void PitchUp()
        {
            transform.Rotate(Vector3.right * AimSpeed);
        }
    }
}
