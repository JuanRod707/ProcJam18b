using Helpers;
using UnityEngine;

namespace Effects
{
    public class FireLightEffect : MonoBehaviour
    {
        public float MinIntensity;
        public float MaxIntensity;
        public int Frameskip;

        private Light light;
        private int currentFrame;

        void Start()
        {
            light = GetComponent<Light>();
        }

        void Update()
        {
            if(currentFrame > Frameskip)
                ChangeIntensity();

            currentFrame++;
        }

        void ChangeIntensity()
        {
            light.intensity = RandomService.GetRandom(MinIntensity, MaxIntensity);
            currentFrame = 0;
        }
    }
}
