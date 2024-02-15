using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float moveSpeed;
    private float lifeTime = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;

        lifeTime += Time.deltaTime;

        if (lifeTime > 10)
        {
            Destroy(gameObject);
        }
    }
}
