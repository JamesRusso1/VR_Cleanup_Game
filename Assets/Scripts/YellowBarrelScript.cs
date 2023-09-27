using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YellowBarrelScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        YellowSphereScript YS = collision.gameObject.GetComponent<YellowSphereScript>();

        if (YS)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
