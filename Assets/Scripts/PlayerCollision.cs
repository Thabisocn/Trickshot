using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
        public float impactField;
    public float force;
    
    public LayerMask ImToHit;

     public GameObject explosionPrefab;
    public trajectoryScript movement;
     public AudioSource playSound;

     

     public AudioSource BouncingSound;

         void Start() {
    
            BouncingSound = GetComponent<AudioSource>();
        }
  
     void OnCollisionEnter2D(Collision2D other)
      {
        if(other.collider.tag == "trigger")
        {
            Debug.Log("Dead");
            Explosionnn();
           playSound.Play();
            FindObjectOfType<GameManager>().EndGame();


            }
             if(other.collider.tag == "Bounce")
        {
            Debug.Log("Bounceaway");
           
             BouncingSound.Play();

            }


              if(other.collider.tag == "bullet")
        {
            Debug.Log("bullet");
           
             playSound.Play();

            }
    }

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
    



