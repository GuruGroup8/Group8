using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Player player;

    public static GameManager gm;

    public Image image;
    public static bool isEndFadeOut = false;

    public GameObject gameLabel;
    public GameObject optionButton;
    public GameObject gameOver;
    public GameObject gameClear;
    Text gameText;

    public string StartScene = "StartScene";

    private void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
    }

    public enum GameState
    {
        Ready,
        Run,
        Pause,
        GameOver
    }

    public GameState gState;

    public GameObject gameOption;

    // Start is called before the first frame update
    void Start()
    {
        gState = GameState.Ready;
        gameText = gameLabel.GetComponent<Text>();
        gameText.text = "READY?";
        gameText.color = new Color32(250, 149, 114, 255);
        StartCoroutine(ReadyToStart());

        player = GameObject.Find("shootingplayer").GetComponent<Player>();
    }

    IEnumerator ReadyToStart()
    {
        yield return new WaitForSeconds(2f);

        gameText.text = "START!";

        yield return new WaitForSeconds(1f);

        gameLabel.SetActive(false);

        gState = GameState.Run;
    }

    public void OpenOption()
    {
        gameOption.SetActive(true);
        Time.timeScale = 0f;
        gState = GameState.Pause;
    }

    public void CloseOption()
    {
        gameOption.SetActive(false);
        Time.timeScale = 1f;
        gState = GameState.Run;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        StartCoroutine(FadeCoroutine());
        StartCoroutine(CheckFadeOutCoroutine());
        
    }

    IEnumerator CheckFadeOutCoroutine()
    {
        while (isEndFadeOut == false)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        Debug.Log("¿Á Ω√¿€");
        SceneManager.LoadScene(StartScene);
    }


    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.001f);
            image.color = new Color(0, 0, 0, fadeCount);
            isEndFadeOut = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();

        if (player.hp <= 0)
        {
            gState = GameState.GameOver;
            gameOver.SetActive(true);
        }

        if(sm.GetScore() >= 30)
        {
            gState = GameState.GameOver;
            Time.timeScale = 0f;
            gameClear.SetActive(true);
        }
    }
}
