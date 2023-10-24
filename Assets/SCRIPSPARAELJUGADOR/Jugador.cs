using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Jugador : MonoBehaviour
{

     public float speed = 5f;

    public float rotationSpeed = 50f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput,0, verticalInput);
        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotationSpeed * Time.deltaTime);
    }
}
