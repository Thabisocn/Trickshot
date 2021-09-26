using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
   public AudioSource playSound;
void OnTriggerEnter2D(Collider2D other) 
{
    if(other.CompareTag("Player"))
         {
             playSound.Play();
         }
}
}
