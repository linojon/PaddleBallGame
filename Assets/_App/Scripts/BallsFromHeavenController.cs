﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsFromHeavenController : MonoBehaviour
{
    public GameObject ballPrefab;
    public float startHeight = 10f;
    public float interval = 0.5f;
    private float nextBallTime = 0f;

    private void Update()
    {
        if (Time.time > nextBallTime)
        {
            nextBallTime = Time.time + interval;
            Vector3 position = new Vector3(Random.Range(-4f, 4f), startHeight, Random.Range(-4f, 4f));
            Instantiate(ballPrefab, position, Quaternion.identity);
        }
    }
}
