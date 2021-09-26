using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAnimation : MonoBehaviour
{


    public Animator ani;

     public AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {
        ani.enabled = false;
    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.collider.name == "trigger")
       {
          ani.enabled = true;
           playSound.Play();
       }
    }

}
