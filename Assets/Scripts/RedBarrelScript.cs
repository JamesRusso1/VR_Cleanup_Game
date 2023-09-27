using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedBarrelScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        RedSphereScript RS = collision.gameObject.GetComponent<RedSphereScript>();

        if (RS)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
