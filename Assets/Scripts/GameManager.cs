using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static bool GameIsOver;
	public GameObject completeLevelUI;
	public GameObject fellLevelUI;
	public string nextlevel = "Level2";
	public int levelToUnlock = 2;


	public EndGameManager GameObject;


	public GameObject gameOverUI;

	void Start()
	{
		
		GameObject.GetComponent<EndGameManager>();
		GameIsOver = false;
		Time.timeScale = 1;

		
	}

	public void fell()
	{
		GameObject.GetComponent<EndGameManager>().enabled = false;
		GameIsOver = true;
		fellLevelUI.SetActive(true);
	}

	 public void EndGame()
	{

		
		GameIsOver = true;
		Time.timeScale = 0;
		gameOverUI.SetActive(true);
	}
	public void CompleteLevel ()
	{
		Debug.Log("You win");
		
		PlayerPrefs.SetInt("levelReached", levelToUnlock);

		//disable timer
	
		GameIsOver = true;
		Time.timeScale = 0;
		completeLevelUI.SetActive(true);

	}



}
