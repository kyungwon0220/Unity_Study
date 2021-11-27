// 3D 큐브를 생성하여 Rigidbody 컴포넌트를 참조하여 점프시키는 예제


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody_GetComponent_Test : MonoBehaviour
{
    public Rigidbody myRigidbody;

    public float speed = 10f;

    void Awake()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DoJump();
        }
    }

    private void DoJump()
    {
        myRigidbody.AddForce(0f, speed, 0f, ForceMode.Impulse);
        // 캐릭터 점프에서 주로 Impulse 옵션을 사용하며 가장 많이 사용한다고 한다.
    }
}
