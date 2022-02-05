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
    public GameObject SelectPanel;
    public GameObject yesButton;
    public GameObject noButton;
    public string ShootingGame = "ShootingGame";

    public static bool isEndFadeOut = false;

    void Start()
    {
        talkPanel = GameObject.Find("talkPanel");
        SelectPanel = GameObject.Find("selectPanel");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bed")
        {
            talkPanel.SetActive(true);
            SelectPanel.SetActive(true);
            talk.text = "�ῡ ��ðڽ��ϱ�?";
 
        }
    }

    public void ClickYes()
    {
        isEndFadeOut = false;
        Debug.Log("���� ��ư Ŭ��");
        SelectPanel.SetActive(false);
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
        Debug.Log("���� ����");
        SceneManager.LoadScene(ShootingGame);
    }

    public void ClickNo()
    {
        Debug.Log("�ڷ� ����");
        SelectPanel.SetActive(false);
        talkPanel.SetActive(false);
    }
}
