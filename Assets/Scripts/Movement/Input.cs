using Magic;
using UnityEngine;
using Weapons;

namespace Movement
{
    public class Input : MonoBehaviour
    {
        public Character Character;
        public float MouseSensitivity;

        Staff Staff => Character.Staff;
        Weapon Weapon => Character.Weapon;
        Movement Movement => Character.Movement;
        public CameraLook Viewpoint => Character.Viewpoint;
        
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
        void Update()
        {
            if (UnityEngine.Input.GetKey(KeyCode.W))
                Movement.MoveForward();
            else if (UnityEngine.Input.GetKey(KeyCode.S))
                Movement.MoveBackwards();

            if (UnityEngine.Input.GetKey(KeyCode.A))
                Movement.StrafeLeft();
            else if (UnityEngine.Input.GetKey(KeyCode.D))
                Movement.StrafeRight();

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
                Movement.Jump();

            if (UnityEngine.Input.GetMouseButton(0))
                Weapon.Attack();

            if (UnityEngine.Input.GetMouseButtonDown(1))
                Staff.Cast();

            if (UnityEngine.Input.GetKeyDown(KeyCode.R))
                Weapon.Reload();

            ReadMouseMovement();
        }

        private void ReadMouseMovement()
        {
            var mouseDelta = new Vector2(UnityEngine.Input.GetAxis("Mouse X"), UnityEngine.Input.GetAxis("Mouse Y")) * MouseSensitivity; 
            Movement.Turn(mouseDelta.x);
            Viewpoint.Pitch(mouseDelta.y);
        }
    }
}