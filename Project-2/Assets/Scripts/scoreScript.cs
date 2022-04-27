using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{

    public int score;
    private void Awake() {
        gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<TextMeshProUGUI>().text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int score){
        gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();

    }
}
