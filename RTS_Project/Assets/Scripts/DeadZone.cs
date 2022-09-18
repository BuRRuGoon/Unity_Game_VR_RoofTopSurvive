using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SurviveItem")
        {
            Destroy(other.gameObject);
        }
    }

    // 플레이어가 물에 빠졌을경우 리스폰
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = spawnPoint.position;
        }
    }
}
