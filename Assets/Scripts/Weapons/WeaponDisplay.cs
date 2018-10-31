using System;
using UI;
using UnityEngine;

namespace Weapons
{
    public class WeaponDisplay : MonoBehaviour
    {
        public Animator Animator;
        public ParticleSystem MuzzleFlash;
        public ParticleSystem CaseEject;

        public GameObject HitParticle;
        public GameObject ShotLine;
        public AudioSource ShootSfx;
        public AudioSource ReloadSfx;

        private StatusBar ui;

        void Start()
        {
            ui = GameObject.Find("UI").GetComponentInChildren<StatusBar>();
        }

        public void Fire()
        {
            Animator.SetTrigger("Fire");
            MuzzleFlash.Play();
            CaseEject.Play();
            ShootSfx.Play();
        }

        public void Reload()
        {
            Animator.SetTrigger("Reload");
            ReloadSfx.Play();
        }

        public void DisplayHitScenery(Vector3 hitPoint) => Instantiate(HitParticle, hitPoint, Quaternion.identity);

        public void DisplayShot(Vector3 hitPoint)
        {
            //var shotLine = Instantiate(ShotLine).GetComponent<LineRenderer>();
            //shotLine.SetPositions(new[] { MuzzleFlash.transform.position, hitPoint });
        }

        internal void UpdateUI(int currentAmmo, int ammoPool) => ui.UpdateAmmo(currentAmmo, ammoPool);
    }
}
