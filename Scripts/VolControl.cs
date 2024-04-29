using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.UI;
using TMPro;

public class VolControl : MonoBehaviour
{
    public GameObject XRKnobContainer;
    public GameObject StatusArusObjective;
    public float RawValue;
    public int MyIntValue;

    public TMP_Text AmpereUI;
    public TMP_Text StatusAmpere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RawValue = XRKnobContainer.GetComponent<XRKnob>().value;
        MyIntValue = 20 + (int)(RawValue*100);
        AmpereUI.text = MyIntValue.ToString();

        if (MyIntValue < 60)
        {
            StatusAmpere.text = "Salah";
            StatusArusObjective.SetActive(false);
        }
        else if (MyIntValue > 80)        
        {
            StatusAmpere.text = "Salah";
            StatusArusObjective.SetActive(false);
        }
        else
        {
            StatusAmpere.text = "Benar";
            StatusArusObjective.SetActive(true);
        }


    }

    public void KnobTest()
    {
        Debug.Log("Knob Turned");
    }

    public void ValueControl()
    {
        // Mencari value mentah dari nilai value knob
        //RawValue = XRKnobContainer.GetComponent<XRKnob>().value;
        //MyIntValue = (int)RawValue;
        //RawValue = (Mathf.RoundToInt(MyIntValue));

    }
}
