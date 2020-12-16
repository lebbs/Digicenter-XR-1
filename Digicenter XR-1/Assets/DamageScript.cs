using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float damage = 100;

         void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("target1"))
            {
                other.gameObject.SendMessage("OnDamage", damage);
            }
        }



}


