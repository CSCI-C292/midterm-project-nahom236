using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{

    public Button menu;

    public void Start() 
    {
        menu.onClick.AddListener(Refresh);
    }
    public void Refresh() 
    {
        Debug.Log("Entered");
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
