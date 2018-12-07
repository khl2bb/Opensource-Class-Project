using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class StartButtonScript : MonoBehaviour
{

    public GameObject IntroImage;
 

   

    
    public void OnClickStart()
    {
        
        IntroImage.SetActive(true);
   
        Debug.Log("Start Button Clicked");
    }
}
