using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce = 8f; // 점프 힘
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 점프 패드 위에 올라갔을 때 자동 점프
        if (collision.gameObject.CompareTag("JumpPad"))
        {
            AutoJump();
        }
    }

    void AutoJump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z); // Y속도 초기화
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);     // 위로 힘 적용
    }
   
}

