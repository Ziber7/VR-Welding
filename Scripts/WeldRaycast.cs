using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldRaycast : MonoBehaviour
{
    [SerializeField] private GameObject _weldPrefab; //Bullet hole

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {//Returns true if we click the mouse button0
            RaycastHit hitInfo; //Contains raycast hit informations
            if (Physics.Raycast(transform.position,transform.forward,out hitInfo))
            {//Returns true if the ray touches something
                GameObject obj = Instantiate(_weldPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                //Instantiating the bullet hole object
                obj.transform.position += obj.transform.forward / 1000;
                //Changing the bullet hole's position a bit so it will fit better
            }
        } */

        StartCoroutine(weldContact());
    }

    IEnumerator weldContact()
    {
        RaycastHit hitInfo; //Contains raycast hit informations
            if (Physics.Raycast(transform.position,transform.forward,out hitInfo))
            {//Returns true if the ray touches something
                GameObject obj = Instantiate(_weldPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                //Instantiating the bullet hole object
                //obj.transform.position += obj.transform.forward / 1000;
                //Changing the bullet hole's position a bit so it will fit better
        }

        yield return new WaitForSeconds(1);
    }
}



