using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    GameObject BGM;
    AudioSource bgmusic;

    // Start is called before the first frame update
    void Awake()
    {
        BGM = GameObject.Find("BGM");
        bgmusic = BGM.GetComponent<AudioSource>();
        if (bgmusic.isPlaying) return;
        else
        {
            bgmusic.Play();
            DontDestroyOnLoad(bgmusic);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
