using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;

    Rigidbody rb;
    Collider col;

    private bool isOnGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.Move(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime + rb.position, Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    public void SetIsOnGround(bool isOnGround)
    {
        this.isOnGround = isOnGround;
    }
}
