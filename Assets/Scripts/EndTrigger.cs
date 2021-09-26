using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	 private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player")
       {
          gameManager.CompleteLevel();
       }
    }

}
