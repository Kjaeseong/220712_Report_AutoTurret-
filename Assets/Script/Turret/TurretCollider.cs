using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TurretCollider : MonoBehaviour
{
    public bool DetectedTarget = false;

    public float angleRange = 60f;
    public float DistanceRange = 7.5f;
    private float _dotValue = 0f;
    private bool isCollision;
    
    public Vector3 DistanceToPlayer;
    public Transform target;

    void Update ()
    {
        _dotValue = Mathf.Cos(Mathf.Deg2Rad * (angleRange / 2));

        DistanceToPlayer = target.position - transform.position;

        if (DistanceToPlayer.magnitude < DistanceRange)
        {
            if (Vector3.Dot(DistanceToPlayer.normalized, transform.forward) > _dotValue)
            {
                DetectedTarget = true;
                isCollision = true;
            }
        }
        else
        {
            DetectedTarget = false;
            isCollision = false;
        }
    }

    Color _blue = new Color(0f, 0f, 1f, 0.2f);
    Color _red = new Color(1f, 0f, 0f, 0.2f);

    private void OnDrawGizmos()
    {
        Handles.color = isCollision ? _red : _blue;
        Handles.DrawSolidArc(transform.position, Vector3.up, transform.forward, angleRange/2, DistanceRange);
        Handles.DrawSolidArc(transform.position, Vector3.up, transform.forward, -angleRange/2, DistanceRange);
    }
}
