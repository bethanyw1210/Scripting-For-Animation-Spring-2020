using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject weapon;
    public GameObject spawnPoint;
    public float spawnTime = 1;

    IEnumerator Spawn()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(weapon, spawnPoint.transform.position, Quaternion.identity);
                print("Working");
            }
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
