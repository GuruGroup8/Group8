using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkEnter : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talk;
    int clickCount = 0;
    public int lastClick;
    PlayerMove player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.currentWalkCount > 0)
        {
            talkPanel.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (clickCount == 0)
            {
                talk.text = "�����ƺ��� �������ֽ� �帲 ĳó�� ���̸� ������ \n�ſ���.";
                clickCount++;
            }
            
             else if (clickCount == 1)
            {
                talk.text = "ħ�뿡 �ٰ��� ���콺�� Ŭ���ϸ� �ῡ �� �� �־�\n��.";
                clickCount++;
            }

            else if (clickCount == 2)
            {
                talk.text = "�� ���� ���忡 �ٰ��� ���콺�� Ŭ���غ�����. \n�ű��� ���� ������ �ſ���!";
                clickCount++;
            }

            else if (clickCount == 3)
            {
                talkPanel.SetActive(false);
            }
        }
    }
}
