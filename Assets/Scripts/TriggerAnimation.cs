using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] private Animator myExplosion;
    [SerializeField] private string fuelexplosion = "Fuel";

      private  void OnTriggerEnter2D(Collider2D col)
     {
         if (col.CompareTag("Player"))
         {
            myExplosion.Play(fuelexplosion, 0, 0.0f);
            
         }
     }
}
