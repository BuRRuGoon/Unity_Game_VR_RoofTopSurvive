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
