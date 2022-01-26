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
       float hor = Input.GetAxis("Horizontal");        //�̵� : 1 = ������, -1 = ����
 
        transform.Translate(Vector3.right * speed * hor * Time.deltaTime);
        if (Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f) {    // ���� ���� Ȥ�� ������ �̵� �� 0.5f �̻��� ���
 
            if(Input.GetAxis("Horizontal") > 0.5f && !facingRight)      //facingRight �� false�̸鼭 ������ �̵�Ű ���� ���.
            {
                Flip();
                facingRight = true;
            }
            else if(Input.GetAxis("Horizontal") < -0.5f && facingRight)     // gacingRight �� true�̸鼭 ���� �̵�Ű ���� ���.
            {
                Flip();
                facingRight = false;
            }
        }
 
        if (Input.GetKey(KeyCode.Space))        //�����̽��� Ű ���� �� ����
        {
            rigid.velocity = Vector3.up * JumpPower;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;             // 1 = ������ ����, -1 = ���ʹ���
        transform.localScale = theScale;
    }
}
