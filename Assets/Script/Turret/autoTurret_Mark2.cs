using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoTurret_Mark2 : MonoBehaviour
{
    public float TurretRotateSpeed = 1f;
    public float BulletSpawnTime_sec = 1f;
    private float GetTime = 0f;
    private bool PlayerDetected;

    public Transform Player;
    public GameObject BulletPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerDetected = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerDetected = false;
        }
    }


    void Update()
    {
        if (PlayerDetected)
        {
            transform.LookAt(Player);
            Shoot();
        }
        else 
        {
            transform.Rotate(0f, TurretRotateSpeed, 0f);
        }
    }

    private void Shoot()
    {
        GetTime += Time.deltaTime;
        if (GetTime >= BulletSpawnTime_sec)
        {
            GetTime = 0f;
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }

}