using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] Transform originPosition;
    [SerializeField] Transform obj;
    // Start is called before the first frame update

    public void Update()
    {
        obj = gameObject.GetComponent<Transform>();
    }
    public void ResetPos()
    {
        obj.transform.position = originPosition.position;
        obj.transform.rotation = originPosition.rotation;
    }

    public void ResetWelding()
    {
        GameObject[] welds = GameObject.FindGameObjectsWithTag("weldDot");
        foreach(GameObject weld in welds)
        GameObject.Destroy(weld);
    }

}