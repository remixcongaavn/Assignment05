using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Debug.Log("Play game!!");
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Debug.Log("Quit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
