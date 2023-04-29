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
            // transform.position : ���� ������Ʈ �ڽ��� ��ġ
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

    // Trigger�� �浹������ ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�浹 ����");
    }

    //Trigger�� �浹 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�浹 ��...");
    }

    //Trigger�� �浹�� �������� ȣ��Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�浹�� ������");
    }

}
