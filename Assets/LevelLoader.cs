using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition; 
    public float transitionTime = 1f;
   
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {

     transition.SetTrigger("start");

    yield return new WaitForSeconds(transitionTime);

    SceneManager.LoadScene(levelIndex);

    }
}
