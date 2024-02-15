using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject actor;
    public Vector3 cameraOffset;

    void Update()
    {
        transform.position = new Vector3(actor.transform.position.x, actor.transform.position.y, transform.position.z) + cameraOffset;
    }
}
