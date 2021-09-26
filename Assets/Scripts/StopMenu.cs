using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour
{

	public GameObject ui;
	public static bool GameIsPaused = false;

	public string menuSceneName = "Menu";

	







	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			Toggle();
		}
	}

	// Update is called once per frame
	public void Toggle()
	{
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf)
		{
			
			Time.timeScale = 0f;

		}
		else
		{
			Time.timeScale = 1f;
		}
		//disable timer
		//disable timer
		

	}



	public void Retry()
	{
		Toggle();

		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Menu()
	{
	
	}
}
