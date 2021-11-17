using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Test : MonoBehaviour
{
    private Transform _tr;
    private Rigidbody myRigidbody;

    public float speed = 5f;

    private void Awake()
    {
        _tr = this.GetComponent<Transform>();
        myRigidbody = this.GetComponent<Rigidbody>();        
    }

    private void Start()
    {
        myRigidbody.velocity = Vector3.forward * speed;
        // velocity 를 재설정 안하면, 현재 속도는 그대로 유지된다.
        // Vector3.forward 는 게임內(월드 Z축 방향을 바라본다.
    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow key Pressed");
            _tr.position += new Vector3(speed * Time.deltaTime, 0, 0); // Vector3.forward 는 게임內(월드 Z축 방향을 바라본다.
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("with the gaze of Transform");
            myRigidbody.velocity = _tr.forward * speed; //Transform.forward 는 나의 시선에서 Z축 방향을 바라본다.
        }
    }
}
