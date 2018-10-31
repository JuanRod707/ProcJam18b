using UnityEngine;

namespace Enemies
{
    public class EnemyHealth : MonoBehaviour
    {
        public int BaseHitPoints;
        public int BaseManaShield;

        int currentHitPoints;
        int currentManaShield;

        void Start()
        {
            currentHitPoints = BaseHitPoints;
        }

        public void ReceiveDamage(int damage)
        {
            currentHitPoints -= damage;
            if(currentHitPoints <= 0)
                Destroy(gameObject);
        }
    }
}