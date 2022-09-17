using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerIndicator : MonoBehaviour
{
    private Material material;
    // Start is called before the first frame update
    private void Start()
    {
        material = GetComponent<Renderer>().material;
        FindObjectOfType<PlayerStatus>().OnHungerPctChanged += HungerIndicator_OnHungerPctChanged;
    }

    private void HungerIndicator_OnHungerPctChanged(float pct)
    {
        material.SetFloat("_Cutoff", 1f - pct);
    }
    
}
