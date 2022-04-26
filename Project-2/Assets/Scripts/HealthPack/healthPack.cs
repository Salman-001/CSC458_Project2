using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPack : MonoBehaviour
{

    [SerializeField] healthTypeSO healthPackType;

    [SerializeField] Player player;

    [SerializeField] HealthBar healthBar;

    // void Awake() {
    //     player = GetComponent<Player>();
    // }
    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(healthPackType.healthWeight);
        
    }

    private void OnTriggerEnter(Collider other) {

        
        if(other.gameObject.tag == "Player"){
            
            if(player.health + healthPackType.healthWeight > 100){
                Debug.Log("Cannot pick up the health pack");
            }else{
                player.health += healthPackType.healthWeight;
                healthBar.setHealth(player.health);
                Debug.Log($"Player hit me, my health is  {player.health}");
                Destroy(gameObject);
            }
        }

    }
}
