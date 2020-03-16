using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextBehavoir : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;
    
    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = dataObj.value.ToString();
    }
}
