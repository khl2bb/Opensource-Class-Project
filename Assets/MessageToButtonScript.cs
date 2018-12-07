
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Allows us to use UI.

public class MessageToButtonScript : MonoBehaviour
{

    public GameObject MessageFirstChoiceImage;





    public void OnClickStart()
    {

        MessageFirstChoiceImage.SetActive(true);

        Debug.Log("MessageToButton Clicked");
    }
}
