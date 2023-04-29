using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeA : MonoBehaviour
{

    public int data;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // transform.position : 게임 오브젝트 자신의 위치
            // Vector3.forward :  Vector3(0,0,1)
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)) // Vector3(0,0,-1)
        {
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.A)) // Vector3(-1,0,0)
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D)) // Vector3(1,0,0)
        {
            transform.position += Vector3.right;
        }
    }

    // Trigger가 충돌했을때 호출되는 이벤트 함수
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌 했음");
    }

    //Trigger가 충돌 중일 때 호출되는 이벤트 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중...");
    }

    //Trigger의 충돌이 끝났을때 호출되는 이벤트 함수
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌이 끝났음");
    }

}
