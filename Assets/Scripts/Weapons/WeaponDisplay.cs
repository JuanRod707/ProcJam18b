using UnityEngine;

namespace Weapons
{
    public class WeaponDisplay : MonoBehaviour
    {
        public Animator Animator;
        public ParticleSystem MuzzleFlash;

        public void Fire()
        {
            Animator.SetTrigger("Fire");
            MuzzleFlash.Play();
        }
    }
}
