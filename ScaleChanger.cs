using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public float scale = 1.0f;
    void OnTriggerEnter(Collider hit)
    {
    if (hit.CompareTag("Item"))
    {
    transform.localScale = new Vector3(scale + 0.1f, scale + 0.1f, scale + 0.1f);
    }
    }
}