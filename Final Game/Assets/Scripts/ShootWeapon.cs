using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject laser;
    public GameObject spawnPoint;
    public float spawnTime = 1f;

    IEnumerator Spawn()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Instantiate(laser, spawnPoint.transform.position, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(spawnTime);
        }

    }
}
