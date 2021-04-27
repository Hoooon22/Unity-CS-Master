using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 두 오브젝트 사이에 빈 경로가 존재하는지 확인하는 예제 클래스
public class ObjectPath : MonoBehaviour
{
    // 적 예제 오브젝트에 대한 참조
    public GameObject Enemy = null;

    // 선 검출을 제한하기 위한 레이어 마스크
    public LayerMask LM;

    // Update is called once per frame
    void Update()
    {
        // 오브젝트 사이에 빈 경로가 있는지 검사
        if(!Physics.Linecast(transform.position, Enemy.transform.position, LM))
        {
            // 빈 경로가 존재한다.
            Debug.Log ("Path clear");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, Enemy.transform.position);
    }

}
