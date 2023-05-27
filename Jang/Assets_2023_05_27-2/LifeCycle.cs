using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//initialize => (Activation) => phusical => logic =>  (inactive) => dismantle
public class LifeCycle : MonoBehaviour
{
	void Start() {
		//오브젝트 변수는 항상 transform을 가짐
		
		Vector2 vec = new Vector2(0,10); //this is vector
		transform.Translate(vec); //벡터값 + 현재 위치 만큼 이동
		
		//int num = 4; //this is scalar value
		
	}
    void Update() { //게임 "로직" 업데이트 => 비고정 주기로 주기가 변할 수도 있음
		if (Input.anyKeyDown) { // down hold up 3개의 케이스
			Debug.Log("플레이어가 아무 키를 눌렀습니다.");
		}
		
		//if (Input.anyKey) {
		//	Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
		//}
		
		if (Input.GetKeyDown(KeyCode.Return)) { //esc == escape Return == enter
			Debug.Log("아이템 구입");
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) {
			Debug.Log("좌측으로 이동 중");
		}
		
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			Debug.Log("우측으로 이동을 멈추었습니다");
		}
		
		if (Input.GetMouseButtonDown(0)) { // 0 -> 마우스 좌클릭 1 마우스 우클릭
			Debug.Log("Missle Lock Fox two");
		}
		
		if (Input.GetMouseButton(0)) {
			Debug.Log("charging");
		}
		
		if (Input.GetMouseButtonUp(0)) {
			Debug.Log("Missle Lock Fox two Fire!");
		}
		
		// Edit => Project_setting => Input_manager
		
		if (Input.GetButtonDown("Jump")){
			Debug.Log("뛰어!");
		}
		
		if (Input.GetButton("Jump")){
			Debug.Log("charging");
		}
		
		if (Input.GetButtonUp("Jump")){
			Debug.Log("하나! 둘! 뛰어!");
		}
		
		//다른 키를 쓰고 싶다? size를 늘리고 추가하면 된다.
		
		//if (Input.GetButton("Horizontal")) {
		//	Debug.Log("횡 이동중" + Input.GetAxis("Horizontal"));
		//}
		
		if (Input.GetButton("Horizontal")) {
			Debug.Log("횡 이동중" + Input.GetAxisRaw("Horizontal") * Time.deltaTime); //deltaTIme == 이전 프레임의 완료까지 걸린 시간
		}
		
		if (Input.GetButton("Vertical")) {
			Debug.Log("종 이동중" + Input.GetAxisRaw("Vertical"));
		}
		
		Vector2 vec1 = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		transform.Translate(vec1);
	}
	
	
}
