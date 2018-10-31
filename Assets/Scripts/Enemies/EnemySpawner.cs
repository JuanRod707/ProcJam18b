using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        public float ActivationDistance;
        public ParticleSystem SpawnEffect;
        public GameObject enemy;

        private Transform character;
        private bool spawned;

        private bool IsInDistance => Vector3.Distance(transform.position, character.position) < ActivationDistance;

        void Start()
        {
            character = GameObject.FindWithTag("Player").transform;
        }

        void Update()
        {
            if (IsInDistance && !spawned)
            {
                Instantiate(enemy, transform.position, Quaternion.identity);

                SpawnEffect.Play();
                spawned = true;
                Destroy(gameObject, 2f);
            }
        }
    }
}
