using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hudScript : MonoBehaviour
{


    private void Awake() {
        gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<TextMeshProUGUI>().text = "20";
        
    }

    public void setAmmo(int ammo){
        gameObject.GetComponent<TextMeshProUGUI>().text = ammo.ToString();

    }
}
