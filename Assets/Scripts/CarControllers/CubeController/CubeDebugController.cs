﻿using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class CubeDebugController : MonoBehaviour
{
    [Title("Debug Draw Options")]
    [Button("@\"Draw All Wheel Velocities: \" + _isDrawWheelVelocities", ButtonSizes.Large)]
    void IsDrawWheelVelocities()
    {
        var wheelArray = GetComponentsInChildren<CubeWheel>();
        _isDrawWheelVelocities = !_isDrawWheelVelocities;

        foreach (var wheel in wheelArray)
        {
            wheel.isDrawWheelVelocities = !wheel.isDrawWheelVelocities;
        }
    }
    bool _isDrawWheelVelocities = false;
    
    [Button("@\"Draw All Wheel Discs: \" + _isDrawWheelDisc", ButtonSizes.Large)]
    void IsDrawWheelDisc()
    {
        var wheelArray = GetComponentsInChildren<CubeWheel>();
        _isDrawWheelDisc = !_isDrawWheelDisc;

        foreach (var sphere in wheelArray)
        {
            sphere.isDrawWheelDisc = !sphere.isDrawWheelDisc;
        }
    }
    bool _isDrawWheelDisc = false;
    
    [Button("@\"Draw All Raycasts: \" + _isDrawRaycasts", ButtonSizes.Large)]
    void IsDrawRaycast()
    {
        _isDrawRaycasts = !_isDrawRaycasts;
        var sphereArray = GetComponentsInChildren<CubeSphereCollider>();

        foreach (var sphere in sphereArray)
        {
            sphere.isDrawRaycast = !sphere.isDrawRaycast;
        }
    }
    bool _isDrawRaycasts = false;

    bool _isDrawForces = false;
    [Button("@\"Draw Wheel Forces: \" + _isDrawForces", ButtonSizes.Large)]
    void IsDrawForces()
    {
        _isDrawForces = !_isDrawForces;
        var wheelArray = GetComponentsInChildren<CubeWheel>();

        foreach (var w in wheelArray)
        {
            w.isDrawForces = !w.isDrawForces;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
