using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeldCounter : MonoBehaviour
{
    //Counter menghitung jumlah hitbox
    //MM menghitung mm las untuk dibagi per Hitungan Hitbox Counter
    
    public int CounterS1;
    public int CounterS1Total;
    public int CounterS1Percentage;
    public int MMStage1;
    public int MMStage1Total;
    public TMP_Text Stage1Counter;
    public TMP_Text MM1Counter;
    public GameObject CompleteUI;
    //public GameObject StageLevel;
    public AudioSource audioSource;
    public AudioClip CompleteSound;
    public GameObject textObject;

    public float Progress, MaxProgress;

    [SerializeField]
    private ProgressBarUI progressBar;   

    [SerializeField] TMP_Text timerText;
    [SerializeField] float eplaspedTime;
    public bool isTimer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Stage1", 0);
        progressBar.SetMaxProgress(MaxProgress);
    }

    // Update is called once per frame
    void Update()
    {
        // Stage's Statistic
        Stage1Counter.text = CounterS1Percentage.ToString() + " %";
        MM1Counter.text = MMStage1.ToString() + " mm";
        Progress = (float)CounterS1Percentage;
        progressBar.SetProgress(Progress);

        // Timer
        if (isTimer)
        {
            eplaspedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt (eplaspedTime / 60);
            int seconds = Mathf.FloorToInt (eplaspedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void Counter1()
    {
        CounterS1 = PlayerPrefs.GetInt("Stage1");
        CounterS1 += 1;
        PlayerPrefs.SetInt("Stage1", CounterS1);
        CounterS1Percentage = CounterS1 * 100 / CounterS1Total;
        MMStage1 = CounterS1Percentage * MMStage1Total / 100;

        // If complete play sound and activate the complete's UI
        if (CounterS1Percentage == 100) 
        {
            audioSource.PlayOneShot(CompleteSound, 0.9f);
            CompleteUI.SetActive(true);
            isTimer = false;
        }
    }

    public void ResetLevel()
    {
        PlayerPrefs.SetInt("Stage1",0);
        CounterS1 = 0;
        PlayerPrefs.SetInt("Stage1", CounterS1);
        CounterS1Percentage = CounterS1 * 100 / CounterS1Total;
        MMStage1 = CounterS1Percentage * MMStage1Total / 100;
        CompleteUI.SetActive(false);
        //StageLevel.SetActive(false);
    }

    public void timeStart()
    {
        textObject.SetActive(true);
        eplaspedTime = 0;
        isTimer = true;
    }

    // For Basic Competence
    public void timeEnd()
    {
        isTimer = false;
    }

    public void leaveStage()
    {
        textObject.SetActive(false);
    }
}
