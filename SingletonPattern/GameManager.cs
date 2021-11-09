// 싱글톤 패턴 1: Awake 에서 초기화 하는 방법




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private void Awake()
    {
        /*
         *  GameManager 의 인스턴스는 한 번에 하나만 존재 하므로
         *  instance 가 이미 존재하는지 아니면 인스턴스와 다른 인스턴스인지 확인 한다.
         */
        if (instance != null && instance != this) // 현재 인스턴스와 다른 인스턴스인지 확인
        {
            // 인스턴스가 이미 존재 하면 중복된 인스턴스를 제거한다
            Destroy(this.gameObject);
        } else
        {
            // 현재 인스턴스가 유일하다면 instance 변수에 현재 오브젝트를 할당 한다
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void GameStart()
    {
        print("게임 시작");
    }
}
