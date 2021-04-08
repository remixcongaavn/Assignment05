using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public void goToMenu()
    {
        MusicManager.MusicMan.Audio.PlayOneShot(MusicManager.MusicMan.Click);
        Debug.Log("Loading Meu....!");
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
