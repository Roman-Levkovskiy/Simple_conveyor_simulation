using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    public enum direction
    {
        Forward,
        Back,
        Right,
        Left
    }
    public direction dir;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 pos = rb.position;

        switch(dir)
        {
            case direction.Forward:
                rb.position += Vector3.back * speed * Time.fixedDeltaTime;
                rb.MovePosition(pos);
                break;

            case direction.Left:
                rb.position += Vector3.right * speed * Time.fixedDeltaTime;
                rb.MovePosition(pos);
                break;

            case direction.Right:
                rb.position += Vector3.left * speed * Time.fixedDeltaTime;
                rb.MovePosition(pos);
                break;

            case direction.Back:
                rb.position += Vector3.forward * speed * Time.fixedDeltaTime;
                rb.MovePosition(pos);
                break;
        }
    }
}
