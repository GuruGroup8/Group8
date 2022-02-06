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

    Vector3 moveLimit = new Vector3(4f, 4f);

    void Update()
    {
        if(GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);

        transform.localPosition = ClampPosition(transform.localPosition);
        transform.position += dir * speed * Time.deltaTime;

        hpSlider.value = (float)hp / (float)maxHp;
    } 
    
    public Vector3 ClampPosition(Vector3 position)
    {
        return new Vector3
        (
            Mathf.Clamp(position.x, -moveLimit.x, moveLimit.x), Mathf.Clamp(position.y, -moveLimit.y, moveLimit.y), 0
            );
    }
}

