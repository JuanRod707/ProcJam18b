using UnityEngine;

namespace Magic
{
    public class SpellDisplay : MonoBehaviour
    {
        public ParticleSystem CastVfx;

        public void Cast()
        {
            CastVfx.Play();
        }
    }
}
