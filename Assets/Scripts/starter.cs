using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.parent.GetComponent<TimerFromTwoBoxes>().Go();
    }
}
