using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string menuSceneName = "Menu";
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Menuu()
    {
        
       SceneManager.LoadScene(menuSceneName);
    }
}
