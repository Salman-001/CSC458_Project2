using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    // Update is called once per frame
    void Update()
    {
        if(health <=  0){
            die();
        }
        
    }

    public void die(){
        Destroy(this.gameObject);
        Debug.Log("Enemy died");
    }

    
}
