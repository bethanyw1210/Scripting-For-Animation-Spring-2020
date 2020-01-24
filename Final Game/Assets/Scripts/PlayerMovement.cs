using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public float speed = 10f, gravity = -2f, jumpSpeed = 32f;

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
        }

        if (!controller.isGrounded)
        {
            position.y += gravity;
        }

        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
        controller.Move (position * Time.deltaTime);
    }
}
