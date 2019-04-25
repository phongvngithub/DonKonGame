using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCheckLadder : MonoBehaviour
{
    public FireSpirit fs;
    // Start is called before the first frame update
    void Start()
    {
       //fs = gameObject.GetComponentInParent<FireSpirit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fs.direction = Vector2.up;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
