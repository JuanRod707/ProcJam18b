using System.Collections;
using Scripts;
using UnityEngine;

namespace LevelGen
{
    public class Chamber : MonoBehaviour
    {
        public Transform[] Exits;
        public Collider Bounds;

        private Level levelContainer;
        
        public void Initialize(Level level)
        {
            levelContainer = level;
            transform.SetParent(levelContainer.transform);
            levelContainer.RegisterNewSection(Bounds);
            
            if (levelContainer.LevelSize > 0)
                GenerateAnnexes();
        }

        void GenerateAnnexes()
        {
            foreach (var e in Exits)
            {
                GenerateCorridor(e);
            }
        }
        
        void GenerateCorridor(Transform exit)
        {
            var candidate = Instantiate(levelContainer.Corridors.PickOne(), exit).GetComponent<Corridor>();
            if (levelContainer.IsSectionValid(candidate.Bounds, Bounds))
            {
                candidate.Initialize(levelContainer);
            }
            else
            {
                 Destroy(candidate.gameObject);
            }
        }
    }
}