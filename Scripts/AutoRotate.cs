using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public bool isPressed = false;
    public float degreesPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed)
        {
            transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        }
    }

    public void ObjRotate ()
    {
        isPressed = !isPressed;
    }
}
