using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
     Rigidbody rigid;
    // Start is called before the first frame update
    void Start(){
        rigid = GetComponent<Rigidbody>();
        //요소를 가져올건데 <T>안의 요소를 가져올거다. 이걸 Generic이라 한다.
        //즉, rigid라는 변수안에 Rigidbody안에 있는 요소를 가져온다는 말이 된다.
        
        //rigid.velocity = Vector3.right;//velocity는 현재 속도를 말하고 이를 오른쪽으로 가게하겠다는 의미가 된다.
        
        //rigid.velocity = new Vector3(2,4,3);
        //얘는 호출되면 물체를 그 속도가 되도록 퍽 쳐준다고 생각하면 된다.
        //그래서 만약 얘가 업데이트로 가면 무한히 저 방향으로 치기 때문에 물체는 일정한 속도로 날아간다.
        //그리고 무엇보다 Rigidbody에 관련된 (물리현상) 코드는 Update가 아니라 FixedUpdate에서 호출하는 것을 권장한다.
        
        rigid.AddForce(Vector3.up*50,ForceMode.Impulse);
        //AddForce(Vec): Vec의 방향으로 힘을 준다.->무게가 크면 더 많은 힘이 필요하다.
        //ForceMode: 힘을 주는 방식(가속(Accelation),무게반영(Impulse))
        
    }
    void FixedUpdate(){
        //힘을 가하기
        if(Input.GetButtonDown("Jump")){
            rigid.AddForce(Vector3.up*50,ForceMode.Impulse);
        }
        //이런식으로 점프도 가능하고, GetAxisRaw를 통해 원하는 방향으로 이동을 하게 만들 수도 있다.
        Vector3 vec=new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec,ForceMode.Impulse);
        //2.회전력
        //rigid.AddTorque(Vector3.back);
        //rigid.AddTorque(Vector3.up);
        //Vector3다음에 오는 벡터를 중심축으로 돌게 된다.
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other){//Collsion이 아닌 이유는 얘는 충돌을 보는게 아니라 그냥 겹쳤냐 안겹쳤냐를 보기때문에 hitbox를 관장하는 Collider를 가져온다.
        if(other.name=="Cube")
            rigid.AddForce(Vector3.up*50,ForceMode.Impulse);
    }
    void Update(){
        
    }

}
