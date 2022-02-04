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
                talk.text = "�����ƺ��� �������ֽ� �帲 ĳó�� ���̸� ������ \n�ſ���.";
                clickCount++;
            }

            else if (clickCount == 1)
            {
                talk.text = "ħ�뿡 �ٰ����� �ῡ �� �� �־��.";
                clickCount++;
            }

            else if (clickCount == 2)
            {
                talk.text = "�� ���� ���忡 �ٰ���������. �ű��� ���� ������ \n�ſ���!";
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
