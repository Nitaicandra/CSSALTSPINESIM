using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMARTS_SDK.Ultrasound;

public class FullscreenScript : MonoBehaviour
{
    public UltrasoundManager manager;
    public GameObject Screen;
    public GameObject Smallscreen;
    public GameObject Fullscreen;
    public bool toggle = false;

    public RectTransform ScreenRect;
    public RectTransform SmallscreenRect;
    public RectTransform FullscreenRect;

    void Start()
    {
        
    }   
    public void FullScreenFunc()
    {
        
        ScreenRect = Screen.GetComponent(typeof(RectTransform)) as RectTransform;
        
       
        if (toggle==false){
            toggle = true;
            FullscreenRect = Fullscreen.GetComponent(typeof(RectTransform)) as RectTransform;
            ScreenRect.anchorMin = FullscreenRect.anchorMin;
            ScreenRect.anchorMax = FullscreenRect.anchorMax;
            ScreenRect.anchoredPosition = FullscreenRect.anchoredPosition;
            ScreenRect.offsetMax = FullscreenRect.offsetMax;
            ScreenRect.offsetMin = FullscreenRect.offsetMin;

        }
        else 
        {
            toggle = false;
            SmallscreenRect = Smallscreen.GetComponent(typeof(RectTransform)) as RectTransform;
            ScreenRect.anchorMin = SmallscreenRect.anchorMin;
            ScreenRect.anchorMax = SmallscreenRect.anchorMax;
            ScreenRect.anchoredPosition = SmallscreenRect.anchoredPosition;
            ScreenRect.offsetMax = SmallscreenRect.offsetMax;
            ScreenRect.offsetMin = SmallscreenRect.offsetMin;




        }

    }
}
