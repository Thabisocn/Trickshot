using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	//public void LoadNextLevel ()
	//{
	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	//}

	public string menuSceneName = "Menu";

	public string nextLevel = "Level2";
	public int levelToUnlock = 2;

	

	public void Continue()
	{

		
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			PlayerPrefs.SetInt("levelReached", levelToUnlock);
	}

	public void Menu()
	{
		 SceneManager.LoadScene(menuSceneName);
	}

}
