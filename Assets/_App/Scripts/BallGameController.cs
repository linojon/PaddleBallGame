using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform dropPoint;
    public float startHeight = 10f;
    public float interval = 3f;

    private float nextBallTime = 0f;
    private AudioSource soundEffect;

    void Start()
    {
        if (dropPoint == null)
        {
            dropPoint = Camera.main.transform;
        }

        soundEffect = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Time.time > nextBallTime)
        {
            nextBallTime = Time.time + interval;

            soundEffect.Play();

            Vector3 position = new Vector3(dropPoint.position.x, startHeight, dropPoint.position.z);
            Instantiate(ballPrefab, position, Quaternion.identity);
        }
    }
}
