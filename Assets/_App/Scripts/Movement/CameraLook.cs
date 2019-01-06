using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float rotateSpeed = 10f;

    private Vector2 mRotation;

    public Vector2 Input { get; set; }

    private void Start()
    {
        mRotation = transform.localEulerAngles;
    }

    private void LateUpdate()
    {
        Look(Input);
    }

    private void Look(Vector2 input)
    {
        var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
        mRotation.y += input.x * scaledRotateSpeed;
        mRotation.x = Mathf.Clamp(mRotation.x - input.y * scaledRotateSpeed, -89, 89);
        transform.localEulerAngles = mRotation;
    }
}
