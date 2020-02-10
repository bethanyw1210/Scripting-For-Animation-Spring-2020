using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    public GameObject objTag;

    public float speed = 10f, gravity = -2f, jumpSpeed = 32f, jumpCount, jumpCountMax = 2f;
    
    public GameObject weapon;
    public GameObject spawnPoint;
    public float spawnTime = 2f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        
        StartCoroutine(SpawnWeapon());
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

    IEnumerator SpawnWeapon()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Instantiate(weapon, spawnPoint.transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
