using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMove : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject leftHand;
    // 확인용
    public Vector3 rightHandVector;
    public Vector3 leftHandVector;

    void Update()
    {
        HandPosition();   
    }

    void HandPosition()
    {
        rightHandVector = rightHand.transform.localPosition;
        leftHandVector = leftHand.transform.localPosition;
    } 
}
