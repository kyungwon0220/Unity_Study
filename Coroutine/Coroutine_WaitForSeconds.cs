// 아래 주석 내용 파일(GameObject_Destory_Test.cs)을 Coroutine 활용하여 동일하게 오브젝트를 삭제하는 예제
/*
// 아래 주석 내용
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_Destory_CoroutineVer : MonoBehaviour
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
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine_WaitForSeconds : MonoBehaviour
{
    private Rigidbody myRigidbody;

    IEnumerator Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        yield return new WaitForSeconds(3f);
        // 다음 줄로 내려가기까지, 3초간 멈춘다

        GameObject.Destroy(this.gameObject);
        // 3초 후에 해당 오브젝트를 삭제
        GameObject.Destroy(GetComponent<Rigidbody>());
        // 컴포넌트를 지우기도 가능하다.
    }
}
