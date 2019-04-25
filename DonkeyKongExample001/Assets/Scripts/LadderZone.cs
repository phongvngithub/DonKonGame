using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderZone : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MarioControl mc = gameObject.GetComponent<MarioControl>();
        if (mc.GetComponent<MarioControl>().ladderZone)
        {
            mc.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            mc.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MarioControl mc = collision.gameObject.GetComponent<MarioControl>();
        if (mc!=null)
        {
            mc.ladderZone = true;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        MarioControl mc = gameObject.GetComponent<MarioControl>();
        mc.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MarioControl mc = collision.gameObject.GetComponent<MarioControl>();
        if (mc != null)
        {
            mc.ladderZone = false;
            mc.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }
}
