using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = .3f;

    private Vector3 mOffset;
    private Vector3 mNewPos;
    private Vector3 mVelocity;

    private void Start()
    {
        mOffset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        mNewPos = target.position + mOffset;
        transform.position = Vector3.SmoothDamp(transform.position, mNewPos, ref mVelocity, smoothTime);
    }
}
