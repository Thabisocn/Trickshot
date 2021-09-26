using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{
   string gameId = "";
   string placementId = "banner";
  

   void Start() {
      Advertisement.Initialize(gameId);
      StartCoroutine(ShowBannerWhenInitialized());
   }

   IEnumerator  ShowBannerWhenInitialized()
    {
       

       while(!Advertisement.isInitialized)
       {
            yield return new WaitForSeconds(0.5F);
       }
      
       
       Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
       Advertisement.Banner.Show(placementId);
    }
}
