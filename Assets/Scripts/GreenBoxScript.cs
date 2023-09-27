using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GreenBoxScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GreenCubeScript GC = collision.gameObject.GetComponent<GreenCubeScript>();

        if (GC)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
