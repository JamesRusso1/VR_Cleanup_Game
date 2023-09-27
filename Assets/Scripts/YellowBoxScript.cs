using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YellowBoxScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        YellowCubeScript YC = collision.gameObject.GetComponent<YellowCubeScript>();

        if (YC)
        {
            Destroy(collision.gameObject);
            Counter.Points++;
        }
    }
}
