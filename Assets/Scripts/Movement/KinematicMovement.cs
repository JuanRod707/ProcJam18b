using UnityEngine;

namespace Movement
{
    public class KinematicMovement : MonoBehaviour, Movement
    {
        public float MoveSpeed;
        public float TurnSpeed;
        public float JumpStrength;
        public float Gravity;
        public float CharacterSize;
        public float CharacterHeight;
        public LayerMask ColliderMask;

        private bool CanMoveForward => !Physics.Raycast(transform.position + Vector3.up * 0.2f, transform.forward,
            CharacterSize, ColliderMask);
        private bool CanMoveBackwards => !Physics.Raycast(transform.position + Vector3.up * 0.2f, -transform.forward,
            CharacterSize, ColliderMask);
        private bool CanMoveRight => !Physics.Raycast(transform.position + Vector3.up * 0.2f, transform.right,
            CharacterSize, ColliderMask);
        private bool CanMoveLeft => !Physics.Raycast(transform.position + Vector3.up * 0.2f, -transform.right,
            CharacterSize, ColliderMask);

        private bool FloorIsAvailable => Physics.Raycast(transform.position, -transform.up, CharacterHeight, ColliderMask);
        private float verticalVelocity = 0;

        private Vector3 FloorSpot
        {
            get
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, -transform.up, out hit, CharacterHeight, ColliderMask))
                {
                    return hit.point;
                }

                return Vector3.zero;
            }
        }

        void Update()
        {
            if (FloorIsAvailable)
                StandOnFloor();
            else
                VerticalMove();
        }

        public void MoveForward()
        {
            if(CanMoveForward)
                transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }

        public void MoveBackwards()
        {
            if(CanMoveBackwards)
                transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        
        public void StrafeLeft()
        {
            if (CanMoveLeft)
                transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
        }

        public void StrafeRight()
        {
            if (CanMoveRight)
                transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }

        public void Jump()
        {
            verticalVelocity = JumpStrength;
            transform.Translate(Vector3.up * JumpStrength);
        }

        public void TurnRight()
        {
            Turn(1f);
        }
        
        public void TurnLeft()
        {
            Turn(-1f);
        }

        void VerticalMove()
        {
            verticalVelocity -= Gravity * Time.deltaTime;
            transform.Translate(Vector3.up * verticalVelocity);
        }

        void StandOnFloor()
        {
            verticalVelocity = 0;
            transform.position = FloorSpot + new Vector3(0f, CharacterHeight - 0.01f, 0f);
        }
        
        public void Turn(float axis)
        {
            transform.Rotate(Vector3.up * TurnSpeed * axis);
        }
    }
}