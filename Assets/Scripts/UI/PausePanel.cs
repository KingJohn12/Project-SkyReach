using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



[SerializeField] GameObject pauseState;

public static bool isGamePaused = true;

public class PausePanel : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeydown(KeyCode.Escape)) {

            if(isGamePaused) {
                Resume(isGamePaused);
            }
            else {
                Pause(isGamePaused);
            }

        }

        
    }


    void Pause() {
        pauseState.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    void Resume() {
        pauseState.SetActive(false);
        timeScale = 1f;
        isGamePaused = false;


    }

    public void Load() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void QuitGame() 
    {
        Application.Quit();

        Debug.Log("Quit");

    }
}
