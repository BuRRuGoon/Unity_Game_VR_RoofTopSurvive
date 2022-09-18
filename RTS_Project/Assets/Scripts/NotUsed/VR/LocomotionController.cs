using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftControllerRay;
    public XRController rightControllerRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    public bool EnableleftTeleport {get; set;} = true;
    public bool EnablerightTeleport {get; set;} = true;

    // Update is called once per frame
    void Update()
    {
        if(leftControllerRay)
        {
            leftControllerRay.gameObject.SetActive(EnableleftTeleport && CheckIfActivated(leftControllerRay));
        }
        if(rightControllerRay)
        {
            rightControllerRay.gameObject.SetActive(EnablerightTeleport && CheckIfActivated(rightControllerRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice,teleportActivationButton,out bool isActivated,activationThreshold);
        return isActivated;
    }
}
