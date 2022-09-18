using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public GameObject splitObject1;
    public GameObject splitObject2;
    private int count = 0;
    Vector3 newPosition;

    // 물체 생성시 기존에 부모 오브젝트 위치, 회전값을 적용하는 함수
    void SetNewTransform()
    {
        // 오브젝트 생성시 기존에 오브젝트 위치, 회전 적용
        splitObject1.transform.rotation = gameObject.transform.rotation;
        splitObject2.transform.rotation = gameObject.transform.rotation;

        newPosition = gameObject.transform.position;
        newPosition.z += 0.26f;
        splitObject1.transform.position = newPosition;
        newPosition.z -= 0.26f;
        splitObject2.transform.position = newPosition;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Axe")
        {
            count++;
            if(count >= 10)
            {
                SetNewTransform();

                splitObject1.SetActive(true);
                splitObject2.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
