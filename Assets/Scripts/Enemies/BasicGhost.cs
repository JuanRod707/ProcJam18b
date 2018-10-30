using UnityEngine;

namespace Enemies
{
    public class BasicGhost : MonoBehaviour
    {
        public float EngageDistance;
        public float MinimumDistance;

        private Movement.Movement movement;
        private Transform character;
        private EnemyGun[] weapons;

        private bool IsInDistance => Vector3.Distance(transform.position, character.position) < EngageDistance;
        private bool IsTooClose => Vector3.Distance(transform.position, character.position) < MinimumDistance;

        void Start()
        {
            movement = GetComponent<Movement.Movement>();
            character = GameObject.FindWithTag("Player").transform;
            weapons = GetComponentsInChildren<EnemyGun>();
        }

        void Update()
        {
            if (IsInDistance)
            {
                LookAtCharacter();

                if (IsTooClose)
                    movement.MoveBackwards();
                else
                    movement.MoveForward();

                foreach (var w in weapons)
                    w.Fire();
            }
        }

        void LookAtCharacter()
        {
            var charPosition = transform.InverseTransformPoint(character.position);
            if (charPosition.x > 0)
                movement.TurnRight();
            else
                movement.TurnLeft();

            foreach (var w in weapons)
                w.Aim(character);
        }
    }
}
