using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedBoxScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        RedCubeScript RC = collision.gameObject.GetComponent<RedCubeScript>();

        if (RC)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
