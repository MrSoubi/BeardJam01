using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDetector : MonoBehaviour
{
    GameObject parent;
    PlayerController parentController;

    private void Start()
    {
        parent = transform.parent.gameObject;
        if (parent != null)
        {
            parentController = parent.GetComponent<PlayerController>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        parentController.SetIsOnGround(true);
    }

    private void OnTriggerExit(Collider other)
    {
        parentController.SetIsOnGround(false);
    }
}
