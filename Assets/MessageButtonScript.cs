using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class MessageButtonScript : MonoBehaviour
{

    public GameObject MessageLobbyImage;
    public GameObject MessageToButton;
    public GameObject MessageFirstChoice;
    public GameObject GoToSNGButton;
    public GameObject NotGoingSNGButton;

    public void OnClickStart()
    {

        MessageLobbyImage.SetActive(true);
        MessageToButton.SetActive(true);
        MessageFirstChoice.SetActive(false);
        GoToSNGButton.SetActive(false);
        NotGoingSNGButton.SetActive(false);
        Debug.Log("Go to MessageLobby Button Clicked");
    }
}
