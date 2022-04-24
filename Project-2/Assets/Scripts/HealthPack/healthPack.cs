using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPack : MonoBehaviour
{

    [SerializeField] healthTypeSO healthPackType;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(healthPackType.healthWeight);
        
    }
}
