using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLas : MonoBehaviour
{

    public GameObject las;
    public GameObject weldAltitude;
    public float loopTime;
    public float degress = 90;
    public float altitude;
    public bool isWelding = false;
    private float nextUpdate = 0.0f;
    public float period = 0.2f;


    [SerializeField] private GameObject _weldPrefab; 

    void Start()
    {
    
    }

    void Update()
    {
        if(Time.time>nextUpdate){
    		//Debug.Log(Time.time+">="+nextUpdate);
    		// Change the next update (current second+1)
            nextUpdate += period;
    		// Call your fonction
    		weldAction();
    	}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "freeWeld")
        {
            isWelding = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "freeWeld")
        {

        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "freeWeld")
        {
            isWelding = false;
        }
    }

    void weldAction()
    {
        if (isWelding)
        {
            StartCoroutine(weldContact());
        }
    }

    IEnumerator weldContact()
    {
        //yield return new WaitForSeconds(loopTime);
        RaycastHit hitInfo; //Contains raycast hit informations
            if (Physics.Raycast(transform.position,transform.forward,out hitInfo))
            {//Returns true if the ray touches something
                GameObject obj = Instantiate(_weldPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                //Instantiating the bullet hole object
                obj.transform.position = new Vector3(obj.transform.position.x, altitude, obj.transform.position.z);
                //Changing the bullet hole's position a bit so it will fit better
                obj.transform.eulerAngles = new Vector3 (degress, 0, 0);
                
        }
        yield return new WaitForSeconds(loopTime);
    }
    

}
