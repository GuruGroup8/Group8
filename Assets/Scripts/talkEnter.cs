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

    // Update is called once per frame
    void Update()
    {
        talkPanel.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {
            
            if(clickCount == 0)
            {
                
                clickCount++;
            }
            
             else if (clickCount == 1)
            {
                talk.text = "침대에 다가가 마우스를 클릭하면 잠에 \n들 수 있어요.";
                clickCount++;
            }

            else if (clickCount == 2)
            {
                talk.text = "그 전에 옷장에 다가가 마우스를 클릭해보세요. \n신기한 일이 벌어질 거예요!";
                clickCount++;
            }

            else if (clickCount == 3)
            {
                talkPanel.SetActive(false);
            }
        }
    }
}
