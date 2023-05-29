using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour {
	Rigidbody rigid;
    // Start is called before the first frame update
	
	public void Jump_() {
		rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
	}
	
    void Start() {
        rigid=GetComponent<Rigidbody>();
		
		//rigid.velocity=Vector3.right;
		//rigid.velocity=new Vector3(2,4,3);
		rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()    { //물리현상이니 권장
        //rigid.velocity=new Vector3(2,4,3);
		if (Input.GetButtonDown("Jump")) {
			rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
		}
		
		Vector3 vec=new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		rigid.AddForce(vec, ForceMode.Impulse);
		
		//회전력 토크! 토크는 팔을 쭉 뻗고 힘차게 돌리면 가장 세지
		//rigid.AddTorque(Vector3.up); // 준 벡터가 축으로 사용됩니다
    }
	
	void OnTriggerStay(Collider other) {
		if (other.name == "Cube") {
			rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
		}
		
		//실제 물리적 충돌로 발생하는 이벤트
		//void OnCollisionEnter(Collistion collision){}
		//void OnCollisionStay(Collistion collision){}
		//void OnCollisionExit(Collistion collision){}
		
		//콜라이더 충돌로 발생하는 이벤트
		//void OnTrigerEnter(Collider other){}
		//void OnTrigerStay(Collider other){}
		//void OnTrigerExit(Collider other){}
	}
	

}
