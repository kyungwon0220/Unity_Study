using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoroutine_Test : MonoBehaviour
{
    private Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        destory(this.gameObject, 4f);
    }

    public void destory(GameObject go, float delay)
    {
        StartCoroutine(_destory(go, delay));
    }

    IEnumerator _destory(GameObject go, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(go);
        Debug.Log(delay + "초 후에 삭제 되었음");
    }
}
