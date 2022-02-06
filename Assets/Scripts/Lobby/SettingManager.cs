using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject settingPanel;
    public GameObject back;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Cabinet")
        {
            audioSource.Play();
            settingPanel.SetActive(true);
        }
    }

    public void ClickBack()
    {
        settingPanel.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
