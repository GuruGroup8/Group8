using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject StartPage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickStartButton()
    {
        StartPage.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
