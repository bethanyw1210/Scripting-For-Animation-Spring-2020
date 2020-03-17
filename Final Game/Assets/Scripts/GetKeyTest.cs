using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyTest : MonoBehaviour
{

    public void Test()
    {
        if (Input.GetKey(KeyCode.D))
        {
            print("Working");
        }
    }
}
