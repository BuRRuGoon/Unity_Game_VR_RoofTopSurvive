using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    Vector3 upPos;
    Vector3 downPos;
    Vector3 applyPos;

    [SerializeField]
    private float wavePower = 0.25f;

    void Start()
    {
        upPos = new Vector3(0f, transform.position.y + wavePower, transform.position.z);
        downPos = new Vector3(0f, transform.position.y - wavePower, transform.position.z);
        applyPos = upPos;
    }
    void Update()
    {
        Wave();
    }

    void Wave()
    {
        if(transform.position.y >= (upPos.y - 0.02f))
        {
            applyPos = downPos;
        }
        else if(transform.position.y <= (downPos.y + 0.02f))
        {
            applyPos = upPos;
        }
        transform.position = Vector3.Slerp(gameObject.transform.position, applyPos, 0.001f);
    }
}
