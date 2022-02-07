using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    Vector3 dir;

    public float speed = 5;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        
        int randValue = UnityEngine.Random.Range(0, 10);

        if(randValue < 3)
        {
            GameObject target = GameObject.Find("shootingplayer");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }

        else
        {
            dir = Vector3.down;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        
        if (other.gameObject.tag == "PlayerBullet")
        {
            sm.SetScore(sm.GetScore() + 1);
        }
   
        if (other.gameObject.tag == "Player")
        {
            player = GameObject.Find("shootingplayer").GetComponent<Player>();
            player.hp--;
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
