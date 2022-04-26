using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Tooltip("Bullet")]
    [SerializeField] private GameObject bullets;
    [SerializeField] private GameObject enemyTriggered;
    [SerializeField] private float damage;
    [Tooltip("particle system for the explosion when enemy is hit with a bullet")]
    [SerializeField] private ParticleSystem fireeffect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "enemy")
        {
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            //Instantiate(fireeffect);
            if(!fireeffect.isPlaying){
                fireeffect.Play();
            }
        }
        if (collision.tag == "ground")
        {
            gameObject.SetActive(false);
            //Instantiate(fireeffect);
            if(!fireeffect.isPlaying){
                fireeffect.Play();
            }
        }

    }
}
