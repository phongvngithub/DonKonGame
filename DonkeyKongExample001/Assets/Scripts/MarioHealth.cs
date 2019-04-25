using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHealth : MonoBehaviour
{
    // Start is called before the first frame update


    public void Die()
    {
        Destroy(transform.parent.gameObject);// gameover
        Application.LoadLevel(1);// restart
    }   
}
