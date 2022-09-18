using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerIndicator : MonoBehaviour
{
    private Material material;
    
    private void Start()
    {
        material = GetComponent<Renderer>().material;
        FindObjectOfType<PlayerStatus>().OnHungerPctChanged += HungerIndicator_OnHungerPctChanged;
    }

    // 마테리얼의 Cutoff값을 변경해서 HP바와 동일한 효과를 주는 기능
    private void HungerIndicator_OnHungerPctChanged(float pct)
    {
        material.SetFloat("_Cutoff", 1f - pct);
    }
    
}
