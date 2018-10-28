using UnityEngine;

namespace Magic
{
    public class Staff : MonoBehaviour
    {
        public Spell CurrentSpell;

        public void Cast()
        {
            CurrentSpell.Cast();
        }
    }
}
