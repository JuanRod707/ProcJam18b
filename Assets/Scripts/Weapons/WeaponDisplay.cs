using UnityEngine;

namespace Weapons
{
    public class WeaponDisplay : MonoBehaviour
    {
        public Animator Animator;

        public void Fire()
        {
            Animator.SetTrigger("Fire");
        }
    }
}
