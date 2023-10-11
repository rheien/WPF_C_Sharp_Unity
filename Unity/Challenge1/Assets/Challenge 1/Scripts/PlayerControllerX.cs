using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float turningSpeed = 1000f;
    public float pitchSpeed = 200f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Update()
    {
        float yawInput = Input.GetAxis("Horizontal");
        float pitchInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * yawInput * pitchSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right * pitchInput * pitchSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
