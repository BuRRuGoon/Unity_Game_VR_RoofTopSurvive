using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSys : MonoBehaviour
{
    Vector3 applyPos;
    [SerializeField]
    private float wavePower = 0.001f;
    [SerializeField]
    private float waveFinishPointZ = 8.3f; 

    void Start()
    {
        applyPos = new Vector3(transform.position.x, transform.position.y, waveFinishPointZ);
    }

    void Update()
    {
        Wave();
    }

    void Wave()
    {
        transform.position = Vector3.Lerp(gameObject.transform.position, applyPos, wavePower);
    }
}
