using UnityEngine;

namespace Common
{
    public class AutoDispose : MonoBehaviour
    {
        public float LifeTime;

        void Start() => Destroy(this.gameObject, LifeTime);
    }
}
