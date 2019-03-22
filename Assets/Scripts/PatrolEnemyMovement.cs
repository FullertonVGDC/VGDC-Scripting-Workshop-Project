using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemyMovement : MonoBehaviour
{
    Vector2 velocity;

    void Start()
    {
        velocity = new Vector2(0, 0);
        StartCoroutine(PatrolRoutine());
    }

    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }

    IEnumerator PatrolRoutine()
    {
        while (true)
        {
            velocity.x = 5;
            velocity.y = 0;
            yield return new WaitForSeconds(1);
            velocity.x = 3;
            velocity.y = 3;
            yield return new WaitForSeconds(1);
            velocity.x = -5;
            velocity.y = 0;
            yield return new WaitForSeconds(1);
            velocity.x = -3;
            velocity.y = -3;
            yield return new WaitForSeconds(1);
        }
    }
}