using UnityEngine;

namespace Movement
{
    public class CameraLook : MonoBehaviour
    {
        public float PitchFactor;
        public float MaxPitch;
        
        float NegativeEuler(float angle) => (angle > 180) ? angle - 360 : angle;

        public void Pitch(float axis)
        {
            var rotX = PitchFactor * axis * Time.deltaTime;

            if (rotX > 0)
            {
                rotX = NegativeEuler(transform.eulerAngles.x) < MaxPitch ? rotX : 0f;
            }
            else if (rotX < 0)
            {
                rotX = NegativeEuler(transform.eulerAngles.x) > -MaxPitch ? rotX : 0f;
            }

            transform.Rotate(transform.right * rotX);
            NormalizeRotation();
        }

        void NormalizeRotation()
        {
            var normalizedEuler = transform.eulerAngles;
            normalizedEuler.z = 0f;
            transform.eulerAngles = normalizedEuler;
        }
    }
}