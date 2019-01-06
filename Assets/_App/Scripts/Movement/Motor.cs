using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Vector2 Input { get; set; }

    private void Update()
    {
        Move(Input);
    }

    private void Move(Vector2 input)
    {
        var move = transform.TransformDirection(input.x, 0, input.y);
        transform.localPosition += move * moveSpeed * Time.deltaTime;
    }
}
