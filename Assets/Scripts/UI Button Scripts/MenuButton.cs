using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit(); 
        Debug.Log("QUITTER");  
    }
    public void StartGame() 
    {
        SceneManager.LoadScene("Power Plant Sliders", LoadSceneMode.Single);
        MainManager.Instance.resetValues();
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }


}
