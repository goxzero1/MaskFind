using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject_mask : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {

            collision.transform.GetComponent<PlayerRespawn>().OnDamaged(collision.transform.position); 
        }
    }
}