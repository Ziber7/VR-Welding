using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerWeld : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float remainingTime;
    public GameObject weldObject;
    public GameObject textObject;
    public bool isTimer;
    // Start is called before the first frame update
    void Start()
    {
        textObject.SetActive(false);
        isTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*

        if (isTimer)
        {
            
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                int minutes = Mathf.FloorToInt (remainingTime / 60);
                int seconds = Mathf.FloorToInt (remainingTime % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else if (remainingTime <0)
            {
                remainingTime = 0;
                timerText.text = "Times Up";
                isTimer = false;
            }
        }

        */
    }

    public void weldActive()
    {
        weldObject.SetActive(true);
    }

    public void weldDeactive()
    {
        weldObject.SetActive(false);
    }

    public void leaveStage()
    {
        textObject.SetActive(false);
    }

    public void setTime(float timer)
    {
        textObject.SetActive(true);
        isTimer = true;
        remainingTime = timer;
    }

}
