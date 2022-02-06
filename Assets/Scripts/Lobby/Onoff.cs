using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onoff : MonoBehaviour
{
    public Button onoff;
    public Text buttonText;
    private bool clickcount = false;

    public GameObject BGM;
    AudioSource bgmusic;

    public void buttonClick()
    {
        if (clickcount == false)
        {
            BGM = GameObject.Find("BGM");
            bgmusic = BGM.GetComponent<AudioSource>();
            buttonText.text = "<color=#919191>" + "OFF" + "</color>";
            clickcount = true;
            bgmusic.Pause();
        }

        else
        {
           buttonText.text = "ON";
           clickcount = false;
           bgmusic.Play();
        }
    }
}
