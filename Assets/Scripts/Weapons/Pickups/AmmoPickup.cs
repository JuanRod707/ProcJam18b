using UnityEngine;

namespace Assets.Scripts.Weapons.Pickups
{
    public class AmmoPickup : MonoBehaviour
    {
        public ParticleSystem ConsumeVfx;
        public GameObject Model;
        
        public void Consume()
        {
            Model.SetActive(false);
            GetComponent<Collider>().enabled = false;
            ConsumeVfx.Play();
            Destroy(gameObject, 2f);
        }
    }
}
