using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingFloor2 : MonoBehaviour
{
    public float speed = -0.04f, changeDirection = -1;
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
        print(floating.y);
        if (floating.y < -4.12f)
        {
            print("Phuc Du again");
            speed *= changeDirection;
        }
        else if (floating.y > 0.769998f)
        {
            print("Phuc Du");
            speed *= changeDirection;
        }
    }
}
