using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsArray : MonoBehaviour
{
    public string[] objectsInScene = new string[]{"Player", "Crystals", "Enemies", "Spikes", "Platforms", "Door"};
    void Awake()
    {
        string player = objectsInScene[0];
        Debug.Log("Player = true");
        string crystals = objectsInScene[1];
        Debug.Log("Crystals = true");
        string enemies = objectsInScene[2];
        Debug.Log("Enemies = true");
        string spikes = objectsInScene[3];
        Debug.Log("Spikes = true");
        string platforms = objectsInScene[4];
        Debug.Log("Platfroms = true");
        string Door = objectsInScene[5];
        Debug.Log("Door = true");
    }
}
