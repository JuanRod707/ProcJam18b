using UnityEngine;
using Weapons;

namespace UI
{
    public class AdvancedCrosshair : MonoBehaviour
    {
        public float MinDimension;
        public float MaxDimension;
        public float CrossGrowthFactor;

        Weapon weapon;
        private RectTransform myRect;

        void Start()
        {
            myRect = GetComponent<RectTransform>();
        }

        void Update()
        {
            UpdateDimension(weapon.Inaccuracy);
        }

        public void UpdateDimension(float inaccuracy)
        {
            var dim = (-inaccuracy * CrossGrowthFactor) + MinDimension;

            myRect.sizeDelta = new Vector2(dim, dim);
        }

        public void AttachToWeapon(Weapon weap) => weapon = weap;
    }
}
