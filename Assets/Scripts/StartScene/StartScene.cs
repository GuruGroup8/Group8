using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public Image image;
    public GameObject startButton;
    public GameObject endButton;
    public GameObject copyright;

    public static bool isEndFadeOut = false;
    public string lobbyScene = "LobbyScene";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    //ù �� ����
    static void FirstLoad()
    {
        if(SceneManager.GetActiveScene().name.CompareTo("StartScene") != 0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }

    public void ClickStart()
    {
        isEndFadeOut = false;
        Debug.Log("��ư Ŭ��");
        StartCoroutine(FadeCoroutine());
        
        startButton.SetActive(false);
        endButton.SetActive(false);
        copyright.SetActive(false);

        StartCoroutine(CheckFadeOutCoroutine());
        
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while(fadeCount < 1.0f)
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
        SceneManager.LoadScene(lobbyScene);
    }

    public void ClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

        Debug.Log("���� ����");
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
