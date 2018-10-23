using UnityEngine;

namespace Weapons
{
    public class Weapon :MonoBehaviour
    {
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
