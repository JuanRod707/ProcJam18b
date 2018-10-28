using UnityEngine;

namespace Magic
{
    [RequireComponent(typeof(SpellDisplay))]
    public abstract class Spell : MonoBehaviour
    {
        public float ManaCost;
        
        protected bool CanCast => true;
        protected SpellDisplay display;

        protected void Start()
        {
            display = GetComponent<SpellDisplay>();
        }

        public virtual void Cast()
        {
            if (CanCast)
            {
                display.Cast();
            }
        }
    }
}
