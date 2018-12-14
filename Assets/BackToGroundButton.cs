using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class BackToGroundButton : MonoBehaviour
{

    public GameObject MessageLobbyImage;
    public GameObject GoToFirstChoiceButton;
    public GameObject PhoneGroundImage;
    public GameObject GoToMessageLobbyButton;
    

    public void OnClickStart()
    {

        MessageLobbyImage.SetActive(false);
        GoToFirstChoiceButton.SetActive(false);
        PhoneGroundImage.SetActive(true);
        GoToMessageLobbyButton.SetActive(true);
        Debug.Log("Go to MessageLobby Button Clicked");
    }
}
