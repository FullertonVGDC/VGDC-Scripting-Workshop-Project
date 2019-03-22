using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumPlayerController : MonoBehaviour
{
    public enum State { Attacking, Defending, Fleeing };
    State state;

    SpriteRenderer sr;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ChangeState(State.Attacking);
    }

    void Update()
    {
        switch (state)
        {
            case State.Attacking:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeState(State.Defending);
                }
                break;

            case State.Defending:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeState(State.Fleeing);
                }
                break;

            case State.Fleeing:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeState(State.Attacking);
                }
                break;
        }
    }



    void ChangeState(State newState)
    {
        switch (newState)
        {
            case State.Attacking:
                state = State.Attacking;
                sr.color = Color.red;
                break;

            case State.Defending:
                state = State.Defending;
                sr.color = Color.blue;
                break;

            case State.Fleeing:
                state = State.Fleeing;
                sr.color = Color.green;
                break;
        }
    }
}