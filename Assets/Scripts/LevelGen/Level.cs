using System.Collections.Generic;
using System.Linq;
using Helpers;
using UnityEngine;

namespace LevelGen
{
    public class Level : MonoBehaviour
    {
        public int MaxLevelSize;
        public GameObject[] Sections;
        public GameObject[] DeadEnds;
        public string[] InitialSectionTags;

        private List<Collider> registeredColliders = new List<Collider>();

        public int LevelSize { get; private set; }

        void Start()
        {
            LevelSize = MaxLevelSize;
            CreateInitialChamber();
        }

        private void CreateInitialChamber()
        {
            Instantiate(PickSectionWithTag(InitialSectionTags), transform).GetComponent<Section>().Initialize(this);
        }

        public bool IsSectionValid(Collider newSection, Collider sectionToIgnore)
        {
            return !registeredColliders.Except(new[] {sectionToIgnore})
                .Any(c => c.bounds.Intersects(newSection.bounds));
        }

        public void RegisterNewSection(Collider newSection)
        {
            registeredColliders.Add(newSection);
            LevelSize--;
        }

        public GameObject PickSectionWithTag(string[] tags)
        {
            return Sections.Where(x => x.GetComponent<Section>().Tags.Intersect(tags).Any()).PickOne();
        }
    }
}