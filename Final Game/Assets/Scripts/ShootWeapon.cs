using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject weapon;
    public GameObject spawnPoint;
    private float spawnTime = .5f;

    IEnumerator Spawn()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(weapon, spawnPoint.transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
