using System.Collections;
using Scripts;
using UnityEngine;

namespace LevelGen
{
    public class Section : MonoBehaviour
    {
        public string[] Tags;
        public string[] CreatesTags;
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
                GenerateSection(e);
            }
        }
        
        void GenerateSection(Transform exit)
        {
            var candidate = Instantiate(levelContainer.PickSectionWithTag(CreatesTags), exit).GetComponent<Section>();
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