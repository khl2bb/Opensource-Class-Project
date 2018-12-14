using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class GameManager1 : MonoBehaviour {

    public float animTime = 2f;
    public float start = 1f;
    public float end = 0f;
    public float time = 0f;

    public bool isPlaying = false;


    public GameObject MenuImage;
    public GameObject FadeImage;
    public GameObject IntroImage;
    public GameObject StartButton;
    public GameObject MessageLobbyImage;
    public GameObject MessageToButton;
    public GameObject MessageFirstImage;

    public Image FadeImageCom;
    // Use this for initialization

    void Start () {

        



        MenuImage.SetActive(true);
        IntroImage.SetActive(false);
        StartButton.SetActive(true);
        MessageLobbyImage.SetActive(false);
        MessageToButton.SetActive(false);
        MessageFirstImage.SetActive(false);
        Debug.Log("GameManager Started");

        FadeImageCom = GetComponent<Image>();

        Color color = FadeImageCom.color;
        color.a = 0f;
        FadeImageCom.color = color;


    }

    public void StartFadeAnim()
    {
        if (isPlaying == true)
            return;
    }
    
}
/*
 * 
 * 
 * 
        //iTween.FadeTo(FadeImage, iTween.Hash("alpha", 0f, "time", 1f));
      //  Debug.Log("FadeFrom1 Started");

        //Color tempcolor = FadeImageCom.color;
        //tempcolor.a = 0.5f;
       // FadeImage.a = 0.5f;
 *  while (color.a > 0f)
        {
            time += Time.deltaTime / animTime;

            color.a = Mathf.Lerp(start, end, time);

            FadeImageCom.color = color;

        }
 * void Update()
    {
    iTween.FadeUpdate(FadeImage, iTween.Hash("alpha", 0f, "time", 10f));
        iTween.FadeFrom(FadeImage, iTween.Hash("alpha", 10f, "time", 10f));
        Debug.Log("FadeFrom1 Started");
        iTween.FadeFrom(FadeImage, iTween.Hash("alpha", 0f, "time", 10f));
        Debug.Log("FadeFrom2 Started");
        iTween.FadeTo(FadeImage, iTween.Hash("alpha", 0f, "time", 10f));
        Debug.Log("FadeTo1 Started");
        iTween.FadeTo(FadeImage, iTween.Hash("alpha", 10f, "time", 10f));
        Debug.Log("FadeTo2 Started");
    }

    public int logoDelayTime = 5;
    public string nextLevel = "MainMenu";

    private float startTime;

    void Start()
    {
        startTime = Time.time;
        fadein();
    }

    void Update()
    {

        if ((Time.time - startTime) > logoDelayTime)
        {
            fadeout();
            Application.LoadLevel(nextLevel);
        }
    }

    void fadein()
    {
        iTween.CameraFadeAdd();
        iTween.CameraFadeFrom(1.0f, 1.0f);
        //iTween.CameraFadeDestroy();
    }

    void fadeout()
    {
        iTween.CameraFadeAdd();
        //iTween.CameraFadeFrom(1.0f, 1.0f);
        iTween.CameraFadeTo(1.0f, 1.0f);
        //iTween.CameraFadeDestroy();
    }
}
*/
