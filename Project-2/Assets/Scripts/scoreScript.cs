using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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

        if(score == 50){
            if(SceneManager.GetActiveScene().buildIndex == 0){
                SceneManager.LoadScene(1);
            }else if(SceneManager.GetActiveScene().buildIndex == 1){
                SceneManager.LoadScene(2);
            }else if(SceneManager.GetActiveScene().buildIndex == 2){
                SceneManager.LoadScene(3);
            }else{
                Application.Quit();
            }
        }
        
    }

    public void setScore(int score){
        gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();

    }
}
