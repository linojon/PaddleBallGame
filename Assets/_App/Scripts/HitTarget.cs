using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public int Score;
    private AudioSource hitSound;

    void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        hitSound.Play();
        Score++;
    }
}
