using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float PlayerMoveSpeed = 0.025f;

    void Update()
    {
        MoveInput();
    }

    private void MoveInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, PlayerMoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -1 * PlayerMoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * PlayerMoveSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(PlayerMoveSpeed, 0f, 0f);
        }
    }

    
}
