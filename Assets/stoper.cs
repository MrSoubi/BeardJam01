using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.parent.GetComponent<TimerFromTwoBoxes>().Stop();
    }
}
