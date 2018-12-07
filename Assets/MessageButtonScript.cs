using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class MessageButtonScript : MonoBehaviour
{

    public GameObject MessageLobbyImage;
    public GameObject MessageToButton;

    public void OnClickStart()
    {

        MessageLobbyImage.SetActive(true);
        MessageToButton.SetActive(true);
        Debug.Log("Message Button Clicked");
    }
}
