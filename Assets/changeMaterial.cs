using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeMaterial : MonoBehaviour
{
    public SteamVR_TrackedObject leftController;
    public SteamVR_TrackedObject rightController;
    public GameObject display;

    int arrayPos = 0;
    public Material[] myMaterials;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerStay(Collider col)
    {
        SteamVR_Controller.Device deviceLeft = SteamVR_Controller.Input((int)leftController.index);
        SteamVR_Controller.Device deviceRight = SteamVR_Controller.Input((int)rightController.index);
        if (deviceLeft.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger) || deviceRight.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            arrayPos++;
            arrayPos %= myMaterials.Length;
            display.GetComponent<Renderer>().material = myMaterials[arrayPos];
        }
    }
}
