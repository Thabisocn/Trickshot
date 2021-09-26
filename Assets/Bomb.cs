 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{  public Animator anim;
    
 
  void Start () {
         anim.enabled = false;
  }
 
   private  void OnTriggerEnter2D(Collider2D col)
     {
         if (col.gameObject.tag == ("Player"))
         {
             anim.enabled = true;
            
         }
     }
 }