using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private bool flashSwitch = false;
    public GameObject flashLit;

    public void FlashSwitch()
    {
        if(flashSwitch)
        {
            flashLit.SetActive(false);
            flashSwitch = false;
        }
        else
        {
            flashLit.SetActive(true);
            flashSwitch = true;
        }
    }
}
