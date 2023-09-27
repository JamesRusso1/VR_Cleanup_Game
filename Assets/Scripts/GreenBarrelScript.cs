using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GreenBarrelScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GreenSphereScript GS = collision.gameObject.GetComponent<GreenSphereScript>();

        if (GS)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
