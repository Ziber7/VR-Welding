using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicTimer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float eplaspedTime = 0f;
    public GameObject textObject;
    public bool isTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            eplaspedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt (eplaspedTime / 60);
            int seconds = Mathf.FloorToInt (eplaspedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void startWeld()
    {
        textObject.SetActive(true);
        isTimer = true;
        eplaspedTime = 0f;
    }

    public void stopWeld()
    {
        isTimer = false;
    }

    public void leaveStage()
    {
        textObject.SetActive(false);
    }
}
