using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMask : MonoBehaviour
{
    public GameObject MaskUseStatus;
    public GameObject Mask;
    public GameObject ResetMaskCanvas;
    public bool isGrab;

    // Start is called before the first frame update
    void Start()
    {
        MaskUseStatus.SetActive(false);
        isGrab = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isGrabMask()
    {
        isGrab = true;
    }

    public void isNotGrabMask()
    {
        isGrab = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            if (isGrab == true)
            {
                MaskUseStatus.SetActive(true);
                ResetMaskCanvas.SetActive(true);
                Mask.SetActive(false);
            }
        }
    }
}
