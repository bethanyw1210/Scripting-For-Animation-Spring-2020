using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    public GameObject weapon, spawnPoint;
    public float spawnTime;
    public string objTag;

    public UnityEvent idleEvent, jumpEvent, walkEvent, attackEvent;

    private float speed = 10f, gravity = -1.5f, jumpSpeed = 30f, jumpCount, jumpCountMax = 1f;

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
            jumpEvent.Invoke();
            position.y = jumpSpeed;
            jumpCount++;
        }
        controller.Move (position * Time.deltaTime);
        walkEvent.Invoke();
    }

    IEnumerator SpawnWeapon()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                attackEvent.Invoke();
                Instantiate(weapon, spawnPoint.transform.position, Quaternion.identity);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindGameObjectWithTag("Wall"))
        {
            jumpCount = 0f;
        }

        if (other.tag == objTag)
        {
            Destroy(other.gameObject);
            jumpCountMax = 2f;
            jumpCount = 0;
            StartCoroutine(PowerupTime());
        }
    }
    
    IEnumerator PowerupTime()
    {
        yield return new WaitForSeconds(5f);
        jumpCountMax = 1f;
        jumpCount = 0;
    }
    
}
