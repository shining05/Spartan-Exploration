using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
        Rigidbody m_Rigidbody;
        float power = 5.0f;

        void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
        }

        void AddForceTest()
        {
            m_Rigidbody.AddForce(transform.up * power, ForceMode.Impulse);
        }
}




