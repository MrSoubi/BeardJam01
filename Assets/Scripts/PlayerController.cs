using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed;
    public float jumpHeight;
    public float gravityValue;
    private AudioSource playerAudioSource;
    public float timeOffset;

    public float hitDistance;


    private Vector3 startPosition;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        playerAudioSource = GetComponentInChildren<AudioSource>();

        startPosition = transform.position;

        if (transform.position.x > 1)
        {
            float time = (transform.position.x / 6560.0f) * 246.0f - timeOffset;
            Debug.Log(time);
            playerAudioSource.time = time;
            playerAudioSource.Play();
        }
        
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(1, 0, 0);

        controller.Move(move * Time.deltaTime * playerSpeed);

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;

        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = startPosition;
            float time = (transform.position.x / 6560.0f) * 246.0f - timeOffset;
            Debug.Log(time);
            playerAudioSource.time = time;
        }
    }

    public void SetRotation(Quaternion quaternion)
    {
        transform.rotation = quaternion;
    }
}