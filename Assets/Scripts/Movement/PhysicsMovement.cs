using UnityEngine;

namespace Movement
{
    public class PhysicsMovement : MonoBehaviour, Movement
    {
        public float MoveSpeed;
        public float TurnSpeed;
        public float JumpForce;

        private Rigidbody body;

        void Start()
        {
            body = GetComponent<Rigidbody>();
        }
        
        public void MoveForward()
        {
             body.AddForce(transform.forward * MoveSpeed * Time.deltaTime);
        }

        public void MoveBackwards()
        {
            body.AddForce(-transform.forward * MoveSpeed * Time.deltaTime);
        }

        public void StrafeLeft()
        {
            body.AddForce(-transform.right * MoveSpeed * Time.deltaTime);
        }

        public void StrafeRight()
        {
            body.AddForce(transform.right * MoveSpeed * Time.deltaTime);
        }

        public void Jump()
        {
            body.AddForce(Vector3.up * JumpForce);
        }

        public void TurnRight()
        {
            body.AddTorque(Vector3.up * TurnSpeed * Time.deltaTime);
        }

        public void TurnLeft()
        {
            body.AddTorque(Vector3.up * -TurnSpeed * Time.deltaTime);
        }

        public void Turn(float axis)
        {
            transform.Rotate(Vector3.up * TurnSpeed * axis);
            //body.AddTorque(Vector3.up * TurnSpeed * axis * Time.deltaTime);
        }
    }
}