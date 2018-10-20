using UnityEngine;

namespace Movement
{
    public class CameraLook : MonoBehaviour
    {
        public float PitchFactor;
        public float MaxPitch;

        private float pitch = 0f;

        public void Pitch(float axis)
        {
            pitch -= PitchFactor * axis * Time.deltaTime;
            var euler = transform.localEulerAngles;
            pitch = Mathf.Clamp(pitch, -MaxPitch, MaxPitch);
            euler.x = pitch;
            transform.localEulerAngles = euler;
            NormalizeRotation();
        }

        void NormalizeRotation()
        {
            var normalizedEuler = transform.localEulerAngles;
            normalizedEuler.z = 0f;
            transform.localEulerAngles = normalizedEuler;
        }
    }
}