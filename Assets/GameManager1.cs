using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class GameManager1 : MonoBehaviour {

    public GameObject MenuImage;
    public GameObject IntroImage;
    public GameObject MessageLobbyImage;
    public GameObject MessageToButton;
    public GameObject MessageFirstImage;
    // Use this for initialization
    void Start () {
        MenuImage.SetActive(true);
        IntroImage.SetActive(false);
        MessageLobbyImage.SetActive(false);
        MessageToButton.SetActive(false);
        MessageFirstImage.SetActive(false);
        Debug.Log("GameManager Started");
    }
	
	
}
