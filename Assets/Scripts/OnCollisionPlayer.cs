using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlayer : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

	    rb.velocity = new Vector2 (speed * moveHorizontal, speed * moveVertical);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Entered collision");

    }

    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("Exit collision");
    }

    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("On collision");
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Entered trigger");

    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exit trigger");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("On trigger");
    }
}
