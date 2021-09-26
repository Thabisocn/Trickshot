using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{

    private string playStoreID= "";
    private string appleStoreID= "";

    private string interstitialAd = "video";
     private string rewardedAd = "rewardedVideo";

     public bool isTargetPlaystore;
     public bool isTestAd;


     private void Start()
      {
         
     }

     private void InitilizeAdvertisement()
     {
           if(isTargetPlaystore)
           {
             Advertisement.Initialize(playStoreID, true);
             return;
            
           }

            Advertisement.Initialize(appleStoreID, isTestAd);
     }

     public void PlayInterstitialAd()
     {
        if(Advertisement.IsReady(interstitialAd))
        {
          return;
        }

        Advertisement.Show(interstitialAd);
     }

}
