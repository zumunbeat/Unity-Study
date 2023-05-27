using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        //Vector3는 3차원이라 3를 쓴거고 Translate는 그 좌표만큼 이동시킨다는 의미다.
    }

    Vector3 target = new Vector3(8,1.5f,0);
    // Update is called once per frame
    void Update()
    {
        //1. MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position,target, 1f);
        //등속 이동 , parameter는 (현재위치, 목표위치, 속도)로 구성

        //2. SmoothDamp
        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position,target,ref velo,1f);
        //부드러운 감속 이동, parameter는 (현재위치,목표위치,참조 속도,속도)로 구성
        //얘는 마지막 parameter에 반비례해서 속도가 증가한다.
        //ref는 참조 접근자로서 실시간으로 바뀌는 값을 적용할 수 있다.
        //근데 여기서 ref의 값이 실시간으로 바뀌게 되면 target의 위치 + 참조하는 속도*가는데 걸리는 시간만큼 좌표가 바뀌기 때문에
        //사실상 목표지점에 도착한다는 부분에서 의미가 크게 없다
        //그래서 목표지점으로 도달하는 SmoothDamp에서 ref값은 zero다.
        
        //3.Lerp : 선형 보간 운동인데 그냥 SmoothDamp보다 감속시간이 길다고 이해하면 된다.
        transform.position = Vector3.Lerp(transform.position,target,0.05f);
        //마지막 매개변수에 비례해서 속도가 증가한다.
        
        //4.SLerp 구면 선형 보간 -> 호를 그리면서 움직인다.
        transform.position = Vector3.Slerp(transform.position,target,0.05f);
        
        //DeltaTime
    }
}
