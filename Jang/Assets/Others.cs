using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Others : MonoBehaviour
{
    
	MeshRenderer mesh;
	Material mat;
    void Start()
    {
        mesh=GetComponent<MeshRenderer>();
		mat=mesh.material;
    }
	
	void OnCollisionEnter(Collision collision) { //물리적 충돌이 시작 될 때 호출당하는 함수
		if (collision.gameObject.name == "ball") { //와 내가 쳐맞으면 대미지가 들어오게 할 수 있네?
				mat.color=new Color(0,0,0);
		}
		
	}
	
	//void OnCollisionStay(Collision collision) { }//물리적 충돌이 도중에
	
	
	void OnCollisionExit(Collision collision) { //물리적 충돌이 끝날 때 호출당하는 함수
		if (collision.gameObject.name == "ball") { //와 내가 쳐맞으면 대미지가 들어오게 할 수 있네?
				mat.color=new Color(1,1,1);
		}
		
	}
}
