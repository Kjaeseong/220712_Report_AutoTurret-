using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class autoTurret : MonoBehaviour
{
    public float BulletSpawnTime = 1f;
    public float TurretRotateSpeed = 1f;

    public GameObject BulletPrefab;
    public Transform target;
    public TurretCollider collider;


    private float _Cumulativetime = 0f;

    Vector3 DistanceToPlayer;
    

    void Update()
    {
        
        if(collider.DetectedTarget)
        {
            Shoot();
        }
        else
        {
            transform.Rotate(0f, TurretRotateSpeed, 0f);
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