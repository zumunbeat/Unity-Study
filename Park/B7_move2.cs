﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B7_move2 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    

    void Update()
    {
        /*
        transform.position = 
            Vector3.MoveTowards(transform.position, target, 0.1f);
*/
       /* 
        Vector3 velo = Vector3.zero;
        transform.position = 
            Vector3.SmoothDamp(transform.position, target
                            , ref velo,0.1f);
*/
        /*
        transform.position = 
            Vector3.Lerp(transform.position,
                            target, 0.1f);
*/

        transform.position = 
            Vector3.Slerp(transform.position
                            , target, 0.005f);



    }
}
