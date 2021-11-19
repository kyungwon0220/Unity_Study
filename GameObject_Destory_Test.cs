using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_Destory_Test : MonoBehaviour
{
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        GameObject.Destroy(this.gameObject, 3f);
        // 3초 후에 해당 오브젝트를 삭제

        GameObject.Destroy(GetComponent<Rigidbody>());
        // 컴포넌트를 지우기도 가능하다.
    }
}
