using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public void PlayGame()
    {
        SceneManager.LoadScene("Livello1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //gameObject.GetComponent<PauseMenu>();
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void QuitGame()
    {
        
        Application.Quit();

    }


}
