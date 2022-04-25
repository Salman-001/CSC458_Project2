using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    [SerializeField] ammoTypeSO ammoBoxType;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(ammoBoxType.ammoWeight);
        
    }

    void Update() {
    }

    private void OnTriggerEnter(Collider other) {

        
        if(other.gameObject.tag == "Player"){
            
            // FindObjectOfType<Player>().health += ammoBoxType.ammoWeight;
            Debug.Log("Player hit me");
            Destroy(gameObject);

        }

    }
}
