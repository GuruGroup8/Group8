using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talkEnter : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talk;
    int clickCount = 0;
    public int lastClick;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject text1;
    public GameObject text2;
    public GameObject image;

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (clickCount == 0)
            {
                talk.text = "엄마아빠가 선물해주신 드림 캐처가 아이를 지켜줄 \n거예요.";
                clickCount++;
            }

            else if (clickCount == 1)
            {
                talk.text = "침대에 다가가면 잠에 들 수 있어요.";
                clickCount++;
            }

            else if (clickCount == 2)
            {
                talk.text = "그 전에 옷장에 다가가보세요. 신기한 일이 벌어질 \n거예요!";
                clickCount++;
            }

            else if (clickCount == 3)
            {
                talkPanel.SetActive(false);
                text1.SetActive(false);
                text2.SetActive(false);
                image.SetActive(false);
            }
        }
    }
}
