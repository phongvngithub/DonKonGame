using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            //player will die
            collision.gameObject.GetComponent<MarioHealth>().Die();
            
        }
        if(collision.gameObject.tag=="Oil")
        {
            Destroy(gameObject);
        }
    }
}
