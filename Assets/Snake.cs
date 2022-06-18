using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{   
    float speed = 3.0f;
    float rotationSpeed = 200.0f;

    public string inputAxis = "Horizontal";
    float horizontal = 0f;

    void Update()
    {
        horizontal = Input.GetAxisRaw(inputAxis);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "KillsPlayer")
        {
            speed = 0;
            rotationSpeed = 0;
            GameObject.FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
