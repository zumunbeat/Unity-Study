using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B10_Rigid_2 : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(1, 2, 3);
        //벡터값 만큼의 힘으로 지정
        //rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        //벡터값 만큼 힘을 가함
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
                               0, Input.GetAxisRaw("Vertical"));
        //rigid.AddForce(vec, ForceMode.Impulse);
        rigid.AddTorque(vec);

    }
}
