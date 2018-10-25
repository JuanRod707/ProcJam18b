using UI;
using UnityEngine;
using Weapons;

namespace Movement
{
    public class Input : MonoBehaviour
    {
        public AdvancedCrosshair UI;
        public float MouseSensitivity;

        Weapon weapon;
        Movement movement;
        public CameraLook cameraLook;
        private Vector3 previousMousePos;
        
        void Start()
        {
            movement = GetComponent<Movement>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            weapon = GetComponentInChildren<Weapon>();
            UI.AttachToWeapon(weapon);
        }
        
        void Update()
        {
            if (UnityEngine.Input.GetKey(KeyCode.W))
            {
                movement.MoveForward();
            }
            else if (UnityEngine.Input.GetKey(KeyCode.S))
            {
                movement.MoveBackwards();
            }

            if (UnityEngine.Input.GetKey(KeyCode.A))
            {
                movement.StrafeLeft();
            }
            else if (UnityEngine.Input.GetKey(KeyCode.D))
            {
                movement.StrafeRight();
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                movement.Jump();
            }

            if (UnityEngine.Input.GetMouseButton(0))
            {
                weapon.Attack();
            }

            ReadMouseMovement();
            previousMousePos = UnityEngine.Input.mousePosition;
        }

        private void ReadMouseMovement()
        {
            var mouseDelta = new Vector2(UnityEngine.Input.GetAxis("Mouse X"), UnityEngine.Input.GetAxis("Mouse Y")) * MouseSensitivity; 
            movement.Turn(mouseDelta.x);
            cameraLook.Pitch(mouseDelta.y);
        }
    }
}