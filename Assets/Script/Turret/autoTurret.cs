using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class autoTurret : MonoBehaviour
{
    public float BulletSpawnTime = 1f;
    public float angleRange = 60f;
    public float DistanceRange = 7.5f;
    public float TurretRotateSpeed = 1f;
    public bool inCollider;

    public GameObject BulletPrefab;
    public Transform target;

    private float _Cumulativetime = 0f;
    private float _dotValue = 0f;

    Vector3 DistanceToPlayer;



    void Update ()
    {
        transform.Rotate(0f, TurretRotateSpeed, 0f);
        
        _dotValue = Mathf.Cos(Mathf.Deg2Rad * (angleRange / 2));

        DistanceToPlayer = target.position - transform.position;

        if (DistanceToPlayer.magnitude < DistanceRange)
        {
            if (Vector3.Dot(DistanceToPlayer.normalized, transform.forward) > _dotValue)
            {
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        transform.LookAt(target);

        _Cumulativetime += Time.deltaTime;
        if (_Cumulativetime >= BulletSpawnTime)
        {
            _Cumulativetime = 0f;
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}