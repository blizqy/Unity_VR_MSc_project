using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TrackingData2 : MonoBehaviour
{

    private SteamVR_TrackedObject obj2;

    private SteamVR_Controller.Device device;


    // Use this for initialization
    void Awake()
    {
        obj2 = GetComponent<SteamVR_TrackedObject>();

    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)obj2.index);

        Debug.Log(device.transform.pos.x + " " + device.transform.pos.y + " " + device.transform.pos.z);

    }
}
