using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class StatusBar : MonoBehaviour
    {
        public Text Mana;
        public Text Health;
        public DynamicText Ammo;

        public void UpdateAmmo(int mag, int pool)
        {
            Ammo.SetValues(mag, pool);
        }
    }
}
