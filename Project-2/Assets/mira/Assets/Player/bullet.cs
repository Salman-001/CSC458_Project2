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
    [SerializeField] private GameObject fireeffect;

    ParticleSystem fe;

    [SerializeField] Player player;

    public int shellSpeed = 10;


    private void Start() {
        fe = fireeffect.GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "enemy")
        {
            gameObject.SetActive(false);
            // Destroy(collision.gameObject);
            // Instantiate(fireeffect);
            if(!fe.isPlaying){
                fe.Play();
            }
        }
        if (collision.tag == "ground")
        {
            gameObject.SetActive(false);
            //Instantiate(fireeffect);
            if(!fe.isPlaying){
                fe.Play();
            }
        }

        

    }
    private void Update() {
        Shoot();
    }

    void Shoot(){
        
        if(Input.GetKeyDown("space")){
            GameObject shell = Instantiate(bullets, transform.position, Quaternion.identity);
            shell.transform.Translate(Vector3.up * shellSpeed * Time.deltaTime);
        }

    }

    private IEnumerator WaitAndInstantiate(){
        Shoot();
        yield return new WaitForSeconds(5f);
    }
}
