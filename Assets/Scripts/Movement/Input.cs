﻿using UnityEngine;
using Weapons;

namespace Movement
{
    public class Input : MonoBehaviour
    {
        public Weapon weapon;
        public float MouseSensitivity;

        Movement movement;
        public CameraLook cameraLook;
        private Vector3 previousMousePos;
        
        void Start()
        {
            movement = GetComponent<Movement>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
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

            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                weapon.Fire(Vector3.zero);
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