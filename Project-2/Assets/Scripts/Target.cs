using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public scoreScript scoreScript;


    public float healthTarget = 50f;

    public void TakeDamage(float amount){
        
        healthTarget -= amount;

        if(healthTarget <= 0f){
            Die();
        }

    }

    public void Die(){
        Destroy(gameObject);
        scoreScript.score += 10;
        scoreScript.setScore(scoreScript.score);
    }

}
