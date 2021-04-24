using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptFile : MonoBehaviour
{
    // Array of Scene's GameObject
    public GameObject[] MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        // 배열의 내용을 코드로 채운다
        MyObjects = new GameObject[3];
        // 씬에 MainCamera 태그로 설정된 카메라가 있어야 한다
        MyObjects[0] = Camera.main.gameObject;

        // GameObject.Find 함수를 사용해 씬의 오브젝트를 이름으로 찾는다
        MyObjects[1] = GameObject.Find("Cube");
        MyObjects[2] = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
