using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if ( GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }

    public void Resume()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Menu");
    }

    public void QuitMenu()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Quit");
    }

    public void saveGame()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        PlayerPrefs.SetInt("score", Score.CurrentScore);
        PlayerPrefs.SetString("name", NameTransfer.theName);
        Debug.Log("Saved game.........Name: " + NameTransfer.theName + " Score: " + Score.CurrentScore);
    }

    public void loadGame()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Score.CurrentScore = PlayerPrefs.GetInt("score");
        NameTransfer.theName = PlayerPrefs.GetString("name");
        SceneManager.LoadScene("Game");
        Resume();

        Debug.Log("Loading save game.......Name: "+  NameTransfer.theName + " Score: " + Score.CurrentScore);
    }
}
