using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstIndicator : MonoBehaviour
{
    private Material material;
    
    private void Start()
    {
        material = GetComponent<Renderer>().material;
        FindObjectOfType<PlayerStatus>().OnThirstPctChanged += ThirstIndicator_OnThirstPctChanged;
    }

    // 마테리얼의 Cutoff값을 변경해서 HP바와 동일한 효과를 주는 기능
    private void ThirstIndicator_OnThirstPctChanged(float pct)
    {
        material.SetFloat("_Cutoff", 1f - pct);
    }
}
