using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TalkManager : MonoBehaviour
{
    public Image image;
    public GameObject talkPanel;
    public Text talk;
    public GameObject YesButton;
    public GameObject NoButton;
    public string ShootingGameScene = "ShootingGame";

    public static bool isEndFadeOut = false;

    void Start()
    {
        talkPanel = GameObject.Find("talkPanel");
        YesButton = GameObject.Find("Yes");
        NoButton = GameObject.Find("No");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bed")
        {
            
            YesButton.SetActive(true);
            NoButton.SetActive(true);
            talkPanel.SetActive(true);
            talk.text = "잠에 드시겠습니까?";
 
        }
    }

    public void ClickYes()
    {
        isEndFadeOut = false;
        Debug.Log("시작 버튼 클릭");
        StartCoroutine(FadeCoroutine());

        StartCoroutine(CheckFadeOutCoroutine());

    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
            isEndFadeOut = true;
        }
    }

    IEnumerator CheckFadeOutCoroutine()
    {
        while (isEndFadeOut == false)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1.5f);
        Debug.Log("게임 시작");
        SceneManager.LoadScene(ShootingGameScene);
    }

    public void ClickNo()
    {
        talkPanel.SetActive(false);
    }
}
