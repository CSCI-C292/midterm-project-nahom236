using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HowTo() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    #if UNITY_EDITOR
    public void Quit() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    #endif
}
