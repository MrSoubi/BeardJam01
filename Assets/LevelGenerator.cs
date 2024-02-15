using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject bar;

    GameObject[] bars = new GameObject[164];

    private Vector3 pos;

    void Start()
    {
        for (int i = 0; i < 164; i++) {
            bars[i] = Instantiate(bar, transform);
            bars[i].transform.position = pos;
            pos += new Vector3(40, -1, 0);
        }
    }

}