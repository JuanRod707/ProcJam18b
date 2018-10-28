using UnityEngine;

namespace Magic
{
    public class MagicMissileProjectile : MonoBehaviour
    {
        public float Speed;
        public LayerMask CollisionWith;
        public GameObject Explosion;
        public float ProjectileSize;

        private bool isActive = true;

        void Update()
        {
            if(isActive)
                transform.Translate(Vector3.forward * Speed * Time.deltaTime);

            if (CheckCollision() && isActive)
            {
                isActive = false;
                Instantiate(Explosion, transform.position, Quaternion.identity);
                foreach(var pe in GetComponentsInChildren<ParticleSystem>())
                    pe.Stop();
                Destroy(gameObject, 1f);
            }
        }

        bool CheckCollision() => Physics.Raycast(transform.position, transform.forward, ProjectileSize, CollisionWith);
    }
}
