using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour
{
    public bool usesDeltaTime;
    public float speed;

    void Update()
    {
        Vector2 moveAmount = new Vector2();
        moveAmount.x = (usesDeltaTime) ? (speed * Time.deltaTime) : speed;

        transform.Translate(moveAmount);

        if (transform.position.x > 10) transform.position = new Vector2(-10, transform.position.y);
    }
}