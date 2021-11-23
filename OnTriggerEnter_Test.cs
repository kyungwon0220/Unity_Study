// OnTriggerEnter_Test 사용하여 충돌 처리 예제


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter_Test : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // 충돌한 상대 오브젝트가 other
    {
        Debug.Log("충돌한 상대 : " + other.name);

        // if(other.name.Contains("Cube") == true)
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
