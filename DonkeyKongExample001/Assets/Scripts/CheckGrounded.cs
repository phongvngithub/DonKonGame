using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{
    public MarioControl mc;
    // Start is called before the first frame update
    void Start()
    {
        mc = gameObject.GetComponentInParent<MarioControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        mc.grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        mc.grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mc.grounded = true;
    }
}
