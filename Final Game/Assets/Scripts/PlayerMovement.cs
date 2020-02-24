using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    private float speed = 10f, gravity = -1.5f, jumpSpeed = 30f, jumpCount, jumpCountMax = 1f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");

        if (controller.isGrounded)
        {
            position.y = 0f;
            jumpCount = 0;
        }

        if (!controller.isGrounded)
        { 
            position.y += gravity;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        controller.Move (position * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindGameObjectWithTag("Wall"))
        {
            jumpCount = 0f;
        }
    }
}
