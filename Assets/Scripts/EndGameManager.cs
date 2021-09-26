using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum GameType
{
    Moves,
    Time

}


[System.Serializable]
public class EndGameRequirements
{
    public GameType gametype;
    public int counterValue;
}
public class EndGameManager : MonoBehaviour
{

    public GameObject movesLabel;
    public GameObject timeLabel;
    public Text counter;
    public EndGameRequirements requirements;
    public int currentCounterValue;
    private float timerseconds;
    public GameObject tryAgainPanel; 
    // Start is called before the first frame update
    void Start()
    {
        SetupGame();
        
    }

    void SetupGame()
    {
        currentCounterValue = requirements.counterValue;
        if(requirements.gametype == GameType.Moves)
        {
            movesLabel.SetActive(true);
            timeLabel.SetActive(false);

        }
        else
        {
            timerseconds = 1;
            movesLabel.SetActive(false);
            timeLabel.SetActive(true);
        }

        counter.text = "" + currentCounterValue;
    }

    public void DecreaseCounterValues()
    {
        
            currentCounterValue--;
            counter.text = "" + currentCounterValue;

        if (currentCounterValue <= 0)
        {

            tryAgainPanel.SetActive(true);
            
            Debug.Log("You lose!!");
            currentCounterValue = 0;
            counter.text = "" + currentCounterValue;
        
        }

    }


        public void IncreaseCounterValues()
    {
        
            currentCounterValue++;
            counter.text = "" + currentCounterValue;

        if (currentCounterValue <= 0)
        {

            tryAgainPanel.SetActive(true);
            
            Debug.Log("You lose!!");
            currentCounterValue = 0;
            counter.text = "" + currentCounterValue;
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if(requirements.gametype == GameType.Time && currentCounterValue > 0)
        {
            timerseconds -= Time.deltaTime;
            if(timerseconds <= 0)
            {
                DecreaseCounterValues();
                timerseconds = 1;
            }

        }
    }
}
