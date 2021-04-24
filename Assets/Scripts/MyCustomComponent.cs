using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomComponent : MonoBehaviour
{
    // 오브젝트의 트랜스폼에 대한 참조
    private Transform ThisTransform = null;

    // Start is called before the first frame update
    void Start()
    {
        // 트랜스폼에 대한 참조를 캐싱한다
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 위치 업데이트
        if (ThisTransform != null)
        {
            ThisTransform.localPosition
                += Time.deltaTime * 10.0f * ThisTransform.forward;
        }
    }
}
