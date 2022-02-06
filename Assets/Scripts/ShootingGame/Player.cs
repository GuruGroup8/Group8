using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float speed = 5;

    public int hp = 5;
    int maxHp = 5;
    public Slider hpSlider;

    void Update()
    {
        if(GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);

        transform.position += dir * speed * Time.deltaTime;

        hpSlider.value = (float)hp / (float)maxHp;
    }  
}

