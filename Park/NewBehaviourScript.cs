using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test start");

        int level = 1;
        float p_atack = 1.1f;
        string p_name = "김씨";
        bool isFullLevel = false;

        Debug.Log("이름");
        Debug.Log(p_name);
        Debug.Log("레벨");
        Debug.Log(level);
        Debug.Log("공격력");
        Debug.Log(p_atack);
        Debug.Log("만렙인가");
        Debug.Log(isFullLevel);    

        //그룹형 변수
        string[] exObjects = {"공", "주사위", "판때기"};
        int[] exObjectsNumb = new int[3];
        exObjectsNumb[0] = 0;
        exObjectsNumb[1] = 6;
        exObjectsNumb[2] = 2;

        Debug.Log("오브젝트의 면 수");
        Debug.Log(exObjectsNumb[0]);
        Debug.Log(exObjectsNumb[1]);
        Debug.Log(exObjectsNumb[2]);
        
        List<string> items = new List<string>();
        items.Add("돌");
        items.Add("화장지");

        //items.RemoveAt(0);

        //연산자
        int exp = 1500;

        exp += 330;
        exp -= 15;
        level = exp/300;
        p_atack = level * 3.3f;
        //float는 f붙이기

        Debug.Log("총 경험치");
        Debug.Log(exp);
        Debug.Log("레벨");
        Debug.Log(level);
        Debug.Log("공격력");
        Debug.Log(p_atack);

        int nextLvu = 300-(exp%300);
        Debug.Log("다음 레벨까지 경험치");
        Debug.Log(nextLvu);

        string title_a = "연약한";
        string title_b = "노가다꾼";
        Debug.Log("이름");
        Debug.Log(title_a + " " + title_b + " " + p_name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
