using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Tooltip("Bullet")]
    [SerializeField] private GameObject bullets;

    GameObject shell;

    [SerializeField] private GameObject enemyTriggered;
    [SerializeField] private float damage;
    // [Tooltip("particle system for the explosion when enemy is hit with a bullet")]
    // [SerializeField] private GameObject fireeffect;

    // ParticleSystem fe;

    [SerializeField] Player player;

    public int shellSpeed = 50;

    private int counter = 0;


    private void Start() {
        // fe = fireeffect.GetComponent<ParticleSystem>();
    }

    // private void OnTriggerEnter(Collider collision)
    // {
    //     if (collision.tag == "enemy")
    //     {
    //         gameObject.SetActive(false);
    //         // Destroy(collision.gameObject);
    //         // Instantiate(fireeffect);
    //         if(!fe.isPlaying){
    //             fe.Play();
    //         }
    //     }
    //     if (collision.tag == "ground")
    //     {
    //         gameObject.SetActive(false);
    //         //Instantiate(fireeffect);
    //         if(!fe.isPlaying){
    //             fe.Play();
    //         }
    //     }

        

    // }
    private void Update() {
        StartCoroutine(WaitAndInstantiate());
    }

    void Shoot(){

        if(player.ammo>0){
            if(Input.GetKeyDown("space")){
                GameObject shell = Instantiate(bullets, transform.position, transform.rotation);
                shell.GetComponent<Rigidbody>().velocity = shell.transform.forward * shellSpeed;

                shell.name = $"shell {counter}" ;
                counter++;

                Destroy(shell, .5f);
            }
            
        }

    }

    private IEnumerator WaitAndInstantiate(){
        Shoot();
        yield return new WaitForSeconds(5f);
    }

}
