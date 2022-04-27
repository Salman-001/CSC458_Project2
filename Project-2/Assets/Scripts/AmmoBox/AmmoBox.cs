using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    [SerializeField] Player player;

    [SerializeField] ammoTypeSO ammoBoxType;

    [SerializeField] hudScript hud_bullets;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(ammoBoxType.ammoWeight);
        
    }

    void Update() {


    }

    private void OnTriggerEnter(Collider other) {

        
        if(other.gameObject.tag == "Player"){
            
            // if(player.ammo + ammoBoxType.ammoWeight > 20){
            //     Debug.Log("Cannot pick up the ammo box");
            // }else{
                player.ammo += ammoBoxType.ammoWeight;
                hud_bullets.setAmmo(player.ammo);
                Debug.Log($"Player have {player.ammo} shells");
                Destroy(gameObject);
            // }

        }

    }
}
