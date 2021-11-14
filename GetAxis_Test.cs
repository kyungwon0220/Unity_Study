// Input.GetAxis 이용하여 x, z축을 position 사용시보다, 부드럽게 이동해보는 예제


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis_Test : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed = 8f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // Vector3형) newVelocity 선언
        
        _rb.velocity = newVelocity;
        

        // 디버깅용 Log 출력
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Arrow key Pressed");
        }
    }

    private void FixedUpdate()
    {
        // jump_ing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            _rb.velocity = new Vector3(0f, 10f, 0f);
            // 연속 점프시 log는 찍히나, 딜레이 있는지가(점프가 씹히는 상태 의문
        }
    }
}
