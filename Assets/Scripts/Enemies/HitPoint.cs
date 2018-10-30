using System;
using UnityEngine;

namespace Enemies
{
    public class HitPoint : MonoBehaviour
    {
        EnemyHealth health;
        
        void Start()
        {
            health = GetComponentInParent<EnemyHealth>();
        }

        public void ReceiveDamage(int damage) => health.ReceiveDamage(damage);
    }
}