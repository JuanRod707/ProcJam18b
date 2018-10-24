using UnityEngine;

namespace Weapons
{
    public class Weapon :MonoBehaviour
    {
        public GameObject HitEffect;
        private WeaponDisplay display;

        void Start()
        {
            display = GetComponent<WeaponDisplay>();
        }

        public void Fire(Vector3 target)
        {
            display.Fire();
        }
    }
}
