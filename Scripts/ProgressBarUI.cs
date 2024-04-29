using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    public float Progress, MaxProgress, Width, Height;

    [SerializeField]
    private RectTransform progressBar;

    // Start is called before the first frame update
    public void SetMaxProgress(float MaxProgress)
    {
        MaxProgress = MaxProgress;
    }

    // Update is called once per frame
    public void SetProgress(float progress)
    {
        Progress = progress;
        float newWidth = (progress / MaxProgress) * Width;

        progressBar.sizeDelta = new Vector2(newWidth, Height);
    }
}
