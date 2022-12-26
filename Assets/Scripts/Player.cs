using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �ϥ� LoadScene ���n���ޥε{���ԭz !!

public class Player : MonoBehaviour
{
    Rigidbody2D rigid2D;          // �Ψө�߫}�����餽�}�ܼ�
    Animator animator;            // �Ψө�߫}���ʵe������}�ܼ�
    public float jumpForce = 680.0f;     // ���D�O�w�]��
    public float walkForce = 30.0f;      // ���ʱ��O�w�]��
    public float maxWalkSpeed = 2.0f;    // ����ʪ��t�׭�

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();  // ���o�߫}������
        animator = GetComponent<Animator>();    // ���o�߫}���ʵe���
    }

    void Update()
    {
        // ���D
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("JumpTrigger"); // Ĳ�o���D�ʵe
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // ���k����
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // �C�����⪺�t��
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        // �t�׭���
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        // (�l�[)�̷Ӧ�i��V½��
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // �̹C�����⪺�t�ק��ܰʵe���t��
        if (rigid2D.velocity.y == 0)
        {
            animator.speed = speedx / 2.0f; // �p�GY�b�t�׬�0�A�t�׭Ȱ��H�G
        }
        else
        {
            animator.speed = 1.0f;
        }
    }

    // ��F���I
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
    }

}
