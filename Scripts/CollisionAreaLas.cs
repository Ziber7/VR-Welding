using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAreaLas : MonoBehaviour
{

    public GameObject area;
    public GameObject CountWeld;
    public int StatusLevel;

    void Start()
    {
        CountWeld.GetComponent<WeldCounter>();
        area.SetActive(false);
    }

    void Update()
    {
        StatusLevel = PlayerPrefs.GetInt("Stage1");
        if (StatusLevel == 0) 
        {
            area.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "UjungLas")
        {
            if (area.activeSelf)
            {
                return;
            }
            else
            {
                CountWeld.GetComponent<WeldCounter>().Counter1();
                area.SetActive(true);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "areaLas")
        {

        }
    }



}
