using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlockBehaviour : MonoBehaviour
{
    public int type;

    bool isActivable = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivable = true;
            Debug.Log("sphere activated"); Debug.Log("sphere activated");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivable = false;
            Debug.Log("sphere deactivated");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && isActivable)
        {
            Debug.Log("Sphere destroyed");
            transform.DOScale(10, 0.2f).SetEase(Ease.InOutCirc).OnComplete(()=>Destroy(gameObject));
        }
    }
}
