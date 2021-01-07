using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TrackingData : MonoBehaviour {

    private SteamVR_TrackedObject obj;

    public GameObject buttonHolder;

    public bool buttonEnabled;

    private SteamVR_Controller.Device device;


	// Use this for initialization
	void Awake () {
        obj = GetComponent<SteamVR_TrackedObject>();
        buttonHolder.SetActive(false);
        buttonEnabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)obj.index);

        Debug.Log(device.transform.pos.x + " " + device.transform.pos.y + " " + device.transform.pos.z);

        if
            (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            {
                if(buttonEnabled == false)
                { buttonHolder.SetActive(true);
                    buttonEnabled = true;
                }
                else if(buttonEnabled == true)
                {
                    buttonHolder.SetActive(false);
                    buttonEnabled = false;
                }
            } }
	}
}
