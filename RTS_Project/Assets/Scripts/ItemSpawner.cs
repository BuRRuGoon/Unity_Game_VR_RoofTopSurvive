using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] item;
    // public GameObject wave;
    public Transform responeTransform;

    [SerializeField]
    private float currentTime;
    private int itemArray;

    // Update is called once per frame
    void Update()
    {
        ItemRespone();
    }

    void ItemRespone()
    {
        // 시간이 흐르게 만듬
        currentTime += Time.deltaTime;

        // 오브젝트 생성 시간
        if (currentTime > 10)
        {
            float newX = Random.Range(-25f, 25f);
            float newY = -1f;
            float newZ = 0f;
            itemArray = Random.Range(0, item.Length);
            
            GameObject resItem = Instantiate(item[itemArray], responeTransform);
            resItem.transform.localPosition = new Vector3(newX, newY, newZ);

            
            // GameObject resWave = Instantiate(wave, responeTransform);
            // resWave.transform.position = new Vector3(newX, 0f, 185f);

            currentTime = 0;
        }

    }
}
