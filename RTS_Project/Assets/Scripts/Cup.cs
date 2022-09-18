using System;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public GameObject cup;
    public GameObject cup_water;
    public GameObject cup_sea_water;
    
    void Update()
    {
        Cup_fall();
    }

    // 일정 각도 이상 컵을 기울였을경우 물을 제거
    void Cup_fall()
    {
        if(Math.Abs(cup.transform.rotation.x) > 0.72 || Math.Abs(cup.transform.rotation.y) > 0.72)
        {
            cup_water.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Water"))
        {
            cup_water.SetActive(true);
            // Debug.Log("물");
        }
    }
}
