using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo : MonoBehaviour
{
    [SerializeField] GameObject _instruct;


    public void How() 
    {
        _instruct.SetActive(true);
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
