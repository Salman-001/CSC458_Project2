using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Easy(){
        SceneManager.LoadScene("easy");
    }

    public void Medium(){
        SceneManager.LoadScene("medium");
    }

    public void Hard(){
        SceneManager.LoadScene("hard");
    }

    public void QuitGame(){
        Application.Quit();
    }

}
