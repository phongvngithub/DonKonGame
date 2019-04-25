using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioControl : MonoBehaviour
{
    public bool facingRight = true;
    public bool isDead = false;
    public bool hasWon = false;
    public bool ladderZone;
    public bool grounded = true;

    public float speed = 10f;
    public float maxSpeed = 3f;
    public float jumpForce = 45f;
    public Vector2 vt2;
    
    public Animator anim;
    public Rigidbody2D r2;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        r2 = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
        anim.SetBool("LadderZone", ladderZone);
        anim.SetBool("isDead", isDead);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                r2.AddForce(Vector2.up * jumpForce);
            }
        }
        
    }


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        r2.AddForce((Vector2.right) * speed * h);
        transform.Translate(new Vector2(1f, 0f)*h *speed* Time.deltaTime);
        if (ladderZone == true)
        {
            transform.Translate(new Vector2(0f, 1f) * v * speed * Time.deltaTime);
        }

        if (h > 0 && !facingRight)
        {
            Flip();
        }

        if (h < 0 && facingRight)
        {
            Flip();
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
