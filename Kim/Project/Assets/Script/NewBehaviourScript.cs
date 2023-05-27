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

    // Update is called once per frame
    void Update()
    {
         Vector3 vec=new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);
        transform.Translate(vec);
    }
}
