using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_animation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void button_touch()
    {
        GetComponent<Animation>().Play("New Animation");
    }
}
