using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawn : MonoBehaviour
{
    public int powerupChance;
    public GameObject objectToCreate, powerUp;
    public GameObject spawnPoint;
    
    void Start()
    {
        SpawnPowerup();
    }
    
    private void SpawnPowerup()
    {
        powerupChance = Random.Range(1, 5);
        switch (powerupChance)
        {
            case 1:
                objectToCreate = powerUp;
                print("Powerup");
                break;
            case 2:
                objectToCreate = null;
                print("None1");
                break;
            case 3:
                objectToCreate = null;
                print("None2");
                break;
            case 4:
                objectToCreate = null;
                print("None3");
                break;
        }
        
        Instantiate(objectToCreate, spawnPoint.transform.position, Quaternion.identity);
    }
}
