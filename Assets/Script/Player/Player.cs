using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            PlayerDie();
        }
    }

    private void PlayerDie()
    {
        gameObject.SetActive(false);
    }
}
