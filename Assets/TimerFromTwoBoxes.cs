using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerFromTwoBoxes : MonoBehaviour
{
    public GameObject start;
    public GameObject stop;

    public float delay = 0f;
    bool running = false;

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            delay += Time.deltaTime;
        }
    }

    public void Go()
    {
        running = true;
    }

    public void Stop()
    {
        running = false;
        Debug.Log(delay);
    }
}
