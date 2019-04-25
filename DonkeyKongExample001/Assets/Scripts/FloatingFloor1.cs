using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingFloor1 : MonoBehaviour
{
    public float speed = 0.09f, changeDirection = -1;
    public Vector3 floating;
    // Start is called before the first frame update
    void Start()
    {
        floating = this.transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        floating.y += speed;
        this.transform.position = floating;
  
        if (floating.y > 0.769998f)
        {
            speed *= changeDirection;
        }
        else if(floating.y < -4.12f )
        {
            speed *= changeDirection;
        }
    }
}
