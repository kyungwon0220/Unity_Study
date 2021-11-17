// Input.GetAxis 이용하여 x, z축을 Transform.position 사용시보다, 부드럽게 이동해보는 예제


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
        // 유니티 Edit > Project Settings... > Input Manager > Axis (mapping
        
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed); // Vector3형 newVelocity 선언
        _rb.velocity = newVelocity; // 기존의 속도(관성 를(을) 제거(무시 하고 newVelocity 속도로 변경한다.
        

        // 디버깅용 Log 출력
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Arrow key Pressed");
        }
        
        
        
        
        // x, z 이동과 동시에 Jump 구현
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            _rb.AddForce(xSpeed, 10f, zSpeed, ForceMode.Impulse);
        }
        // Rigidbody.velocity로 구현이 가능한지와, ForceMode 개념은 모르는 상태
        // xSpeed 와 zSpeed 를 0f 로 변경시, 연속 점프 이상
        // ForceMode.Impulse 제거시, 점프 미실행
    }
}
