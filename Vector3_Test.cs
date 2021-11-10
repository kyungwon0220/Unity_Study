// Vector3() 함수로 Transform.position 조정하여 큐브를 이동시키는 예제


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Test : MonoBehaviour
{
    private Transform _tr;
    public float speed = 5f;
    // public로 speed 변수를 선언하였으니 유니티 화면에서 실시간으로 조절이 가능하다.

    private void Awake()
    {
        _tr = this.GetComponent<Transform>();
        // Transform 참조 변수를 만들어야 속도 관리에 옳다(캐싱
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _tr.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
