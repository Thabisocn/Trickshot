using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class AdmanagerReward : MonoBehaviour, IUnityAdsListener
{

    	private EndGameManager endGameManager;
    string placement = "rewardedVideo";

    


 void Start() {
     endGameManager = FindObjectOfType<EndGameManager>();
     Advertisement.AddListener(this);
     Advertisement.Initialize("", false);
      
     
    }

    public void showAd(string p)
    {
      Advertisement.Show(p);
    }

 public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
 {
      if(showResult == ShowResult.Finished)
      {
          	if(endGameManager != null)
				{
       if(endGameManager.requirements.gametype == GameType.Moves)
							{
         endGameManager.IncreaseCounterValues();
							}
				}
      }

      else if (showResult == ShowResult.Failed)
      {
          SSTools.ShowMessage("Connect to the Internet.",SSTools.Position.bottom, SSTools.Time.threeSecond);
      }
 }

 public void OnUnityAdsDidStart(string placementId)
 {
  
 }

 public void OnUnityAdsReady(string placementId)
 {
  
 }

    
 public void OnUnityAdsDidError(string message)
 {
  
 }
}
