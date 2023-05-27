using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	Vector3 target=new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update() {
		//MoveTowards => 일정한 속도로
        //transform.position= Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime); // Vector3.MoveTowards(now location,target,  speed)
		
		//SmoothDamp => 반비례 함 speed하고
		//Vector3 velo=Vector3.zero;
		//Vector3 velo=Vector3.up * Time.deltaTime;
		//transform.position= Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); // Vector3.SmoothDamp(location, target, REF speed, speed)
    
		//Lerp => 선형 보간 SmoothDamp보다 감속 속도가 느림 + speed와 정비례
		//transform.position= Vector3.Lerp(transform.position, target, 0.01f); // Vector3.Lerp(location, target, speed) speed is between 0 to 1
		
		//Slerp => 구면 선형 보간 simply 호 그리기
		transform.position= Vector3.Slerp(transform.position, target, 0.01f * Time.deltaTime); // Vector3.Slerp(location, target, speed) speed is between 0 to 1
		//deltaTime == 이전 프레임 완료까지 걸린 시간
	}
}
