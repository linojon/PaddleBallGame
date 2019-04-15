using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioShooterController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform shootAt;
    public Transform shooter0;
    public Transform shooter1;
    public float speed = 5.0f;
    public float interval = 3f;

    public AudioProcessor audioProcessor;

    private int shooterId = 0;
    private AudioSource soundEffect;

    void Start()
    {
        soundEffect = GetComponent<AudioSource>();

        audioProcessor.onBeat.AddListener(OnBeatDetected);
    }

    void OnBeatDetected()
    {
        if (shooterId == 0)
        {
            ShootBall(shooter0);
            shooterId = 1;
        }
        else
        {
            ShootBall(shooter1);
            shooterId = 0;
        }
    }

    private void ShootBall(Transform shooter)
    {
        GameObject ball = Instantiate(ballPrefab, shooter.position, Quaternion.identity);

        shooter.transform.LookAt(shootAt);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = shooter.forward * speed;

        soundEffect.Play();
    }
}
