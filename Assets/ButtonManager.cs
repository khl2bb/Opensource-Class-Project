using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allows us to use UI.

public class ButtonManager : MonoBehaviour {

    public GameObject MessageFirstChoiceImage;
    public GameObject MessageLobbyImage;



    public void OnClickToMessageLobbyButton()
    {

        MessageFirstChoiceImage.SetActive(false);


        Debug.Log("ToMessageLobbyButton Clicked");
    }

    public void OnClickToPhoneGround()
    {

        MessageLobbyImage.SetActive(false);


        Debug.Log("ToPhoneGround Clicked");
    }

}
