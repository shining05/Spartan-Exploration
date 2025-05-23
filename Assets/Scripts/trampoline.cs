using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce = 8f; // ���� ��
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� �е� ���� �ö��� �� �ڵ� ����
        if (collision.gameObject.CompareTag("JumpPad"))
        {
            AutoJump();
        }
    }

    void AutoJump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z); // Y�ӵ� �ʱ�ȭ
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);     // ���� �� ����
    }
   
}

