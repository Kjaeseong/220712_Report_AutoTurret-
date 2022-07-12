using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float BulletSpeed = 0.1f;
    public float BulletDestroyTime_sec = 2f;

    void Start()
    {
        Destroy(gameObject, BulletDestroyTime_sec);
    }

    void Update()
    {
        transform.Translate(0f, 0f, BulletSpeed);
    }
}
