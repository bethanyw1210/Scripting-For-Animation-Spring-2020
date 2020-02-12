using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.green;
    public Color spriteColorOff = Color.red;
    private SpriteRenderer spriteObj;
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = spriteColorOff;
    }

    void Update()
    {
        
    }
}
