﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    void Start()
    {
        initalOffset = transform.position - targetObject.position;
    }

    void LateUpdate()
    {
        cameraPosition = targetObject.position + initalOffset;
        transform.position = cameraPosition;
    }
}
