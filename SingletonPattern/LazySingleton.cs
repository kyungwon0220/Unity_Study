// 싱글톤 패턴 2 : Lazy initialization (게으른 초기화 방법)




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazySingleton : MonoBehaviour
{
    private static LazySingleton instance;
    public static LazySingleton GetInstance()
    {
        // 만약 인스턴스가 존재하지 않을 경우
        if(!instance)
        {
            // 인스턴스를 찾는다
            instance = GameObject.FindObjectOfType(typeof(LazySingleton)) as LazySingleton;
            if(!instance)
            {
                // 찾아봐도 존재하지 않는 경우 새로 만든다
                GameObject obj = new GameObject("GameManager(Lazy)"); // 이름이 GameManager(Lazy)인 빈 게임 오브젝트를 생성한다
                instance = obj.AddComponent(typeof(LazySingleton)) as LazySingleton;
            }
        }

        return instance;
    }

    public void GameStart ()
    {
        print("game start : lazwy singleton");
    }
}
