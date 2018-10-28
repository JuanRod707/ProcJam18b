using UnityEngine;

namespace Magic
{
    public class MagicMissile : Spell
    {
        public GameObject MissilePrefab;

        public override void Cast()
        {
            Instantiate(MissilePrefab, transform.position, transform.rotation);
            base.Cast();
        }
    }
}
