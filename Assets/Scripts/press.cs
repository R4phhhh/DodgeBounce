using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class press : MonoBehaviour
{
    public GameObject menu;
    public GameObject settings;
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene(0);
    }
    public void settingsMenu()
    {
        settings.SetActive(true);
        menu.SetActive(false);
    }
    public void mainMenu()
    {
        menu.SetActive(true);
        settings.SetActive(false);
    }
    public void exit()
    {
        Application.Quit();
    }

}
