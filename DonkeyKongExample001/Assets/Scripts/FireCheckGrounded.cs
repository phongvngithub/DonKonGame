using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCheckGrounded : MonoBehaviour
{
    public FireSpirit fs;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Vector2 currentScale;
        if(fs.direction==Vector2.right)
        {
            fs.direction = Vector2.left;
        }
        else
        {
            fs.direction = Vector2.right;
        }
        currentScale = fs.transform.localScale;
        currentScale.x *= -1;
        fs.transform.localScale = currentScale;
    }


}
