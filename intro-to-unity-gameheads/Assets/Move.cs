using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.01f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = Vector2.zero; // init direction to 0 in x and y dir
        if (Input.GetKey(KeyCode.A)) {
            moveDir.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveDir.y = 1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir.y = -1.0f;
        }
        moveDir = moveDir * speed * Time.deltaTime;
            transform.Translate(moveDir.x, 0.0f, moveDir.y);
            // args: x, y, x positions
    }
}