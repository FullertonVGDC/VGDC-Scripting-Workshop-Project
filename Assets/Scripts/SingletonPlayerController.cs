using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPlayerController : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        Vector2 moveAmount = new Vector2();
        moveAmount.x = Input.GetAxisRaw("Horizontal") * speed;
        moveAmount.y = Input.GetAxisRaw("Vertical") * speed;
        transform.Translate(moveAmount * Time.deltaTime);

        //Prevent going off right edge
        if (transform.position.x > GameMaster.instance.screenRightEdge)
            transform.position = new Vector2(GameMaster.instance.screenRightEdge, transform.position.y);

        //Prevent going off left edge
        if (transform.position.x < GameMaster.instance.screenLeftEdge)
            transform.position = new Vector2(GameMaster.instance.screenLeftEdge, transform.position.y);

        //Prevent going off top edge
        if (transform.position.y > GameMaster.instance.screenTopEdge)
            transform.position = new Vector2(transform.position.x, GameMaster.instance.screenTopEdge);

        //Prevent going off bottom edge
        if (transform.position.y < GameMaster.instance.screenBottomEdge)
            transform.position = new Vector2(transform.position.x, GameMaster.instance.screenBottomEdge);
    }
}