using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //게임시간, 게임 실행상태 , 게임 관리

    public CubeA CubeA;
    public int[] array;                                     //new int 메모리 할당
   

    public void Create()
    {
        CubeA.data = 300;
        array[0] = 10;
        Debug.Log("캐릭터 생성");
        Debug.Log(+array[0]);
        Debug.Log(+array[1]);
        Debug.Log(+array[2]);
        Debug.Log(+array[3]);
    }

}
