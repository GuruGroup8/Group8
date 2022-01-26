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
        Debug.Log("���� ����");
        SceneManager.LoadScene(playScene);
    }

    public void ClickLoad()
    {
        Debug.Log("���� �ε�");
        SceneManager.LoadScene(loadScene);
    }

    public void ClickExit()
    {
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
