    /*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCollider : MonoBehaviour
{
    public autoTurret _autoturret;
    public Transform target;
    
    void Start()
    {
        _autoturret = GetComponent<autoTurret>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _autoturret.inCollider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _autoturret.inCollider = false;
        }
    }
}

    */