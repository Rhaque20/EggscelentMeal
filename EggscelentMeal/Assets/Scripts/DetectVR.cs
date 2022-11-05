using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    [SerializeField]bool startVR = false;
    public GameObject xrOrigin;
    public GameObject desktopCharacter;
    // Start is called before the first frame update
    void Start()
    {
        if (startVR)
        {
            var xrSettings = XRGeneralSettings.Instance;
            if (xrSettings == null)
            {
                Debug.Log("xRSettings is null");
                return;
            }

            var xrManager = xrSettings.Manager;
            if (xrManager == null)
            {
                Debug.Log("xRSettings is null");
                return;
            }

            var xrLoader = xrManager.activeLoader;
            if (xrLoader == null)
            {
                Debug.Log("xRSettings is null");
                xrOrigin.SetActive(false);
                desktopCharacter.SetActive(true);
                return;
            }

            xrOrigin.SetActive(true);
            desktopCharacter.SetActive(false);
        }
        else
        {
            xrOrigin.SetActive(false);
            desktopCharacter.SetActive(true);
        }
    }
}
