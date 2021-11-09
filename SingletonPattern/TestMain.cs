using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.GameStart();
        // 싱글톤 패턴 1 : Awake() 에서 초기화 하는 방법
        LazySingleton.GetInstance().GameStart();
        // 싱글톤 패턴 2 : Lazy initialization (게으른 초기화 방법)
    }
}
