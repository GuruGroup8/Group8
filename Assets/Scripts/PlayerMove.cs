using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float JumpPower = 3;
    private Rigidbody2D rigid;
    private bool facingRight = true;
    private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float hor = Input.GetAxis("Horizontal");        //이동 : 1 = 오른쪽, -1 = 왼쪽
 
        transform.Translate(Vector3.right * speed * hor * Time.deltaTime);
        if (Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f) {    // 만약 왼쪽 혹은 오른쪽 이동 중 0.5f 이상인 경우
 
            if(Input.GetAxis("Horizontal") > 0.5f && !facingRight)      //facingRight 가 false이면서 오른쪽 이동키 누른 경우.
            {
                Flip();
                facingRight = true;
            }
            else if(Input.GetAxis("Horizontal") < -0.5f && facingRight)     // gacingRight 가 true이면서 왼쪽 이동키 누른 경우.
            {
                Flip();
                facingRight = false;
            }
        }
 
        if (Input.GetKey(KeyCode.Space))        //스페이스바 키 누를 시 점프
        {
            rigid.velocity = Vector3.up * JumpPower;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;             // 1 = 오른쪽 방향, -1 = 왼쪽방향
        transform.localScale = theScale;
    }
}
