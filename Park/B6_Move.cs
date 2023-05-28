using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B6_Move : MonoBehaviour
{
    /*
    void Update()
    {
        //KeyDown, Key, KeyUp 존재함. 각각 누를때 누르는중 뗄때
        if(Input.anyKeyDown)
            Debug.Log("aaa");
        if(Input.anyKey)
            Debug.Log("bbb");    
        //anyKeyUp은 안됨
        //Getkey[up, , down](KeyCode.[버튼])으로 버튼 지정 가능

        if(Input.GetMouseButtonDown(0))
            Debug.Log("Get MB(0)은 좌클릭");
        if(Input.GetMouseButtonDown(1))
            Debug.Log("Get MB(1)은 우클릭");

        if (Input.GetButton("Horizontal")) {
            Debug.Log("횡 이동 중..."
             + Input.GetAxisRaw("Horizontal"));
             //GetAxis = 가중치 있음, Raw = 없음
        }
    }
    */
    void Update(){//deltatime = 프레임이 많으면 작고 적으면 큼
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal")* Time.deltatime*0.1f,
            Input.GetAxis("Vertical")* Time.deltatime*0.1f,
            0);//이동값 지정
        transform.Translate(vec);
        //Translate = 이동, Vector3 = 3차원벡터
    }

}
