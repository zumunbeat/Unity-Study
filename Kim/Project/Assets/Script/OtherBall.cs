using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat=mesh.material;
    }

    private void OnCollisionEnter(Collision collision){ //보통 이벤트 함수 앞에는 On이 붙는다.
        //물리적인 충돌이 시작될 때 호출되는 함수이다.
        if(collision.gameObject.name == "My ball")//Collision은 충돌을 관장하는 클래스이다.
            mat.color=new Color(1,1,1);
    }
    private void OnCollisionStay(Collision collision){ //보통 이벤트 함수 앞에는 On이 붙는다.
        //물리적인 충돌중일때 호출되는 함수이다.

    }
    private void OnCollisionExit(Collision collision){ //보통 이벤트 함수 앞에는 On이 붙는다.
        //물리적인 충돌이 끝났을 때 호출되는 함수이다.
         if(collision.gameObject.name == "My ball")//Collision은 충돌을 관장하는 클래스이다.
            mat.color=new Color(0,0,0);
            //이러면 충돌이 끝나면 검은색으로 바뀌게 된다.
    }
    // Update is called once per frame 
    void Update()
    {
        
    }
}
