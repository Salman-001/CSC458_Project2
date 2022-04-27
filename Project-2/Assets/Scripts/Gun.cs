using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 25f;
    public float range = 100f;

    public Camera fpsCam;
    public GameObject shellExplosion;
    ParticleSystem ps;

    public Player player;

    private void Start() {
        ps = shellExplosion.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("space")){
            StartCoroutine(WaitAndShoot());
        }
        
    }

    void Shoot(){
        if(player.ammo > 0){
            ps.Play();
            FindObjectOfType<AudioManager>().Play("Firing");
        }

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){

            Target target = hit.transform.GetComponent<Target>();

            if(target != null){
                target.TakeDamage(damage);
            }

        }

    }

    private IEnumerator WaitAndShoot(){
        Shoot();
        yield return new WaitForSeconds(5f);
    }
}
