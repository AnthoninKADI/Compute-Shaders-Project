using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [Header("Camera Reference")]
    public GameObject target;
    public GameObject CameraFPS;
    public GameObject CameraLvL1;
    public GameObject CameraLvL2;
    public bool isCLVL1;
    public bool isCLVL2;
    public bool isFPS; 

    [Space]

    [Header("Don't Touch")]
    public float defaultFOV;

    void Start()
    {
        isFPS = true;
        isCLVL1 = false;
        isCLVL2 = false;
    }

    void Update()
    {
        if (isCLVL1) 
        {
            CameraLvL1.SetActive(true);
            CameraFPS.SetActive(false);
            CameraLvL2.SetActive(false);
        }
        else if (isFPS) 
        {
            CameraLvL1.SetActive(false);
            CameraFPS.SetActive(true);
            CameraLvL2.SetActive(false);
        }
        else if(isCLVL2) 
        {
            CameraLvL1.SetActive(false);
            CameraFPS.SetActive(false);
            CameraLvL2.SetActive(true);
        }
    }

    public void CLVL1Switch()
    {
        isCLVL1 = true;
        isFPS = false;
        isCLVL2 = false;
    }
    
    public void FPSSwitch()
    {
        isCLVL1 = false;
        isFPS = true;
        isCLVL2 = false;

    }

    public void CLVL2Switch()
    {
        isCLVL1 = false;
        isFPS = false;
        isCLVL2 = true;
    }
}
