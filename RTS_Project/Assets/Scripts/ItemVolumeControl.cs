using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVolumeControl : MonoBehaviour
{
    public GameObject itemRespone;
    
    [SerializeField]
    private int itemVolumeCount = 0;

    [SerializeField]
    private int maxVolumeCount = 10;

    // 트리거를 활용해 물체가 얼마나 획득 지역에 있는지 카운터로 계산한후에 제한해주는 방식
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SurviveItem")
        {
            itemVolumeCount++;
        }

        if(itemVolumeCount >= maxVolumeCount)
        {
            itemRespone.GetComponent<ItemSpawner>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "SurviveItem")
        {
            itemVolumeCount--;
        }

        if(itemVolumeCount < maxVolumeCount)
        {
            itemRespone.GetComponent<ItemSpawner>().enabled = true;
        }
    }





}
