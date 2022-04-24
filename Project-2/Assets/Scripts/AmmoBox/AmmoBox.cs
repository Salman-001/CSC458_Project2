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
}
