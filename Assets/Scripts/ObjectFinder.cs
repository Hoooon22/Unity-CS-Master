using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    // 검색할 오브젝트의 태그 이름
    public string TagName = "Enemy";

    // 일치하는 태그를 가진 검색된 오브젝트의 배열
    public GameObject[] FoundObjects;

    // Start is called before the first frame update
    void Start()
    {
        FoundObjects = GameObject.FindGameObjectsWithTag(TagName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
