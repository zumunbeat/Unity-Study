using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B5LS : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake 되었습니다.");
    }

    void OnEnable()
    {
        
    Debug.Log("활성")
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aa");
    }

    void FixedUpdate()
    {
        Debug.Log("픽스된 업데이트");
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("업데이트");
    }

    void LateUpdate()
    {
        Debug.Log("레이트 업데이트");
    }

    void OnDisable()
    {
        
    Debug.Log("비활성")
    }
    void OnDestory()
    {
        Debug.Log("파괴됨");
    }
}