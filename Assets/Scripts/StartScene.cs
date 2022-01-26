using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public string playScene = "PlayScene";
    public string loadScene = "LoadingScene";

    public void ClickStart()
    {
        Debug.Log("게임 시작");
        SceneManager.LoadScene(playScene);
    }

    public void ClickLoad()
    {
        Debug.Log("게임 로딩");
        SceneManager.LoadScene(loadScene);
    }

    public void ClickExit()
    {
        Debug.Log("게임 종료");
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
