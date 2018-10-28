using UnityEngine;

namespace LevelGen
{
    public class PlayerSpawnPoint : MonoBehaviour
    {
        void Start()
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
        }
    }
}
