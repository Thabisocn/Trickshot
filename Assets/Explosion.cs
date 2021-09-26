using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    public float impactField;
    public float force;
      public AudioSource playSound;
    public LayerMask ImToHit;

     public GameObject explosionPrefab;
      
   
   void OnTriggerEnter2D(Collider2D other) 
     {
         if(other.CompareTag("Player"))
         {
             playSound.Play();
             Explosionnn();
             Debug.Log("YOU DIED");
             FindObjectOfType<GameManager>().EndGame();
             
            
             
         }
         
         
     }


    // Update is called once per frame
    void Explosionnn()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, impactField, ImToHit);
        foreach (Collider2D obj in objects)
        {
           Vector2 dir = obj.transform.position - transform.position;

           obj.GetComponent<Rigidbody2D>().AddForce(dir * force);
           Instantiate(explosionPrefab, transform.position, transform.rotation);
           Destroy(gameObject);
        }
    }
    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,impactField);
    }
}
