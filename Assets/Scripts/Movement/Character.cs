using Magic;
using UI;
using UnityEngine;
using Weapons;

namespace Movement
{
    public class Character : MonoBehaviour
    {
        public AdvancedCrosshair Crosshair;

        public Movement Movement => movement;
        public Weapon Weapon => weapon;
        public CameraLook Viewpoint => viewpoint;
        public Staff Staff => staff;

        private Movement movement;
        private Weapon weapon;
        private Staff staff;
        private CameraLook viewpoint;
        
        void Start()
        {
            movement = GetComponent<Movement>();
            weapon = GetComponentInChildren<Weapon>();
            viewpoint = GetComponentInChildren<CameraLook>();
            staff = GetComponentInChildren<Staff>();
            Crosshair.AttachToWeapon(weapon);
        }
    }
}