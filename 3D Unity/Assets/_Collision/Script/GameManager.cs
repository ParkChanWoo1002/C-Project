using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //���ӽð�, ���� ������� , ���� ����

    public CubeA CubeA;
    public int[] array;                                     //new int �޸� �Ҵ�
   

    public void Create()
    {
        CubeA.data = 300;
        array[0] = 10;
        Debug.Log("ĳ���� ����");
        Debug.Log(+array[0]);
        Debug.Log(+array[1]);
        Debug.Log(+array[2]);
        Debug.Log(+array[3]);
    }

}
