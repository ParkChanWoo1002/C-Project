using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 접근 제한자
    private int data; // 인스펙터 공개X
    protected int health; // 인스펙터 공개X
    public int value = 10;// 인스펙터에 공개

    #region 유니티 생명주기
    //유니티 생명주기

    //내가 태어났을 떄 (1번) - 몬스터 오브젝트의 체력과 공격력 설정
    //내가 살아가고 있을 때 (계속) - 몬스터 움직임
    //내가 죽었을 때 (1번) - 캐릭터의 스코어 증가 , 게임 아이템을 생성

    // Awake -> OnEnable -> Start  초기화 영역

    //FixedUpdate -> OnTrrigerXXX -> OnCollisionXXX -> Update -> LateUpdate  업데이트 영역  

    // OnApplicationQuit() 게임 종료했을 때 호출되는 함수 -> OnDisable() 게임 비활성화 -> OnDestroy()  삭제 영역
    #endregion

    // Awake : 스크립트 실행될 때 단 한번만 실행
    // 스크립트가 비활성화 상태일 때 호출됩니다.
    public void Awake()  // 서버에서 데이터 로드
    {
        Debug.Log("Awake");
    }

    // 게임 오브젝트가 활성화되었을 때 호출되는 함수입니다.
    public void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    //Start : 스크립트가 활성화되었을 때 한번만 실행되는 함수
    // 스크립트가 비활성화 상태일 때는 호출되지 않습니다.
    public void Start() // 오브젝트 속성 값을 초기화할 때
    {
        Debug.Log("Start");
    }

    //FixedUpdate : TimeStep에 설정된 값에 따라서 일정한 간격으로 호출되는 함수
    //default : 0.02초 마다 호출
    public void FixedUpdate() // 물리적인 연산 처리하는데 이용
    {
        Debug.Log("FixedUpdate");
    }

    //Update : 매 프레임마다 호출되는 함수
    public void Update()
    {
        Debug.Log("Update");
        // Debug.Log(Time.deltaTime); //한 프레임당 실행하는 시간
    }


}

