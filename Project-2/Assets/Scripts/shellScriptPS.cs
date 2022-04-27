using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellScriptPS : MonoBehaviour
{

    [Tooltip("particle system for the explosion when enemy is hit with a bullet")]
    public GameObject tankExplosion;
    ParticleSystem te;

    // Start is called before the first frame update
    void Start()
    {
        te = tankExplosion.GetComponent<ParticleSystem>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "enemy" || other.gameObject.tag == "ground"){
            Debug.Log("Hello shelllll");
            te.Play();
        }
    }
}
