using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;

    [SerializeField]
    public int maxHealth = 100;
    public int health;

    [Tooltip("HealthBar Image")]
    public HealthBar healthBar;

    void Start(){
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    public void SavePlayer() {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer () {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

    public void takeDamage (int damage){
        health -= damage;
        healthBar.setHealth(health);
    }

    void Update() {
        if(Input.GetKeyDown("p")){
            Debug.Log(health);
        }

        if(health < 0){
            health = 0;
            Debug.Log("You are dead");
        } 
    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "Borders"){
            StartCoroutine(WaitAndDamage());
        }

    }

    private IEnumerator WaitAndDamage(){
        takeDamage(5);
        yield return new WaitForSeconds(1);
    }

}
