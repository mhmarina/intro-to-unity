using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.01f;
    public Vector3 jumpForce = new Vector3(0.0f, 10.0f, 0.0f);
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }
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
        Vector3 movement = transform.forward * moveDir.y + transform.right * moveDir.x ;
        moveDir = movement * speed * Time.deltaTime;
        transform.Translate(moveDir);
        // args: x, y, x positions

        Jump();
    }
}