using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstIndicator : MonoBehaviour
{
    private Material material;
    // Start is called before the first frame update
    private void Start()
    {
        material = GetComponent<Renderer>().material;
        FindObjectOfType<PlayerStatus>().OnThirstPctChanged += ThirstIndicator_OnThirstPctChanged;
    }

    private void ThirstIndicator_OnThirstPctChanged(float pct)
    {
        material.SetFloat("_Cutoff", 1f - pct);
    }
}
