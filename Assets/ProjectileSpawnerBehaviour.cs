using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawnerBehaviour : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireRate;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > fireRate)
        {
            timer -= fireRate;
            GameObject localProjectile = Instantiate(projectilePrefab);
            localProjectile.transform.position = transform.position;
            localProjectile.transform.rotation = transform.rotation;
        }
    }
}
