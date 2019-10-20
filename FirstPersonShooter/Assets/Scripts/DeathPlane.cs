using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().Damage(100);
    }
}
