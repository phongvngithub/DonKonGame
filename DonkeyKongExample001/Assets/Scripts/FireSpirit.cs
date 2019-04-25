using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpirit : MonoBehaviour
{
    public float speed = 5f;
    public Animator anim;
    public Rigidbody2D r2;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
