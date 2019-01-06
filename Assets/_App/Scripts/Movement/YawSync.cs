using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YawSync : MonoBehaviour
{
    public Transform target;

    private float mInitYaw;

    private void Start()
    {
        mInitYaw = transform.localEulerAngles.y;
    }

    private void Update()
    {
        Vector3 angles = transform.localEulerAngles;
        angles.y = mInitYaw + target.localEulerAngles.y;
        transform.localEulerAngles = angles;
    }
}
