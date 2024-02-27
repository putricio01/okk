using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Goal : MonoBehaviour
{
    private CubeController p1;
    private void Awake()
    {
        p1 = GetComponentInParent<CubeController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>() != null)
        {
            // goal scored
             p1.score++;
        }
    }
}*/

public class Goal : MonoBehaviour
{
    public CubeController associatedPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>() != null)
        {
            // goal scored
            associatedPlayer.score++;
        }
    }
}
