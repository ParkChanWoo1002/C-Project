using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // ���� ������
    private int data; // �ν����� ����X
    protected int health; // �ν����� ����X
    public int value = 10;// �ν����Ϳ� ����

    #region ����Ƽ �����ֱ�
    //����Ƽ �����ֱ�

    //���� �¾�� �� (1��) - ���� ������Ʈ�� ü�°� ���ݷ� ����
    //���� ��ư��� ���� �� (���) - ���� ������
    //���� �׾��� �� (1��) - ĳ������ ���ھ� ���� , ���� �������� ����

    // Awake -> OnEnable -> Start  �ʱ�ȭ ����

    //FixedUpdate -> OnTrrigerXXX -> OnCollisionXXX -> Update -> LateUpdate  ������Ʈ ����  

    // OnApplicationQuit() ���� �������� �� ȣ��Ǵ� �Լ� -> OnDisable() ���� ��Ȱ��ȭ -> OnDestroy()  ���� ����
    #endregion

    // Awake : ��ũ��Ʈ ����� �� �� �ѹ��� ����
    // ��ũ��Ʈ�� ��Ȱ��ȭ ������ �� ȣ��˴ϴ�.
    public void Awake()  // �������� ������ �ε�
    {
        Debug.Log("Awake");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �Լ��Դϴ�.
    public void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    //Start : ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� �� �ѹ��� ����Ǵ� �Լ�
    // ��ũ��Ʈ�� ��Ȱ��ȭ ������ ���� ȣ����� �ʽ��ϴ�.
    public void Start() // ������Ʈ �Ӽ� ���� �ʱ�ȭ�� ��
    {
        Debug.Log("Start");
    }

    //FixedUpdate : TimeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �Լ�
    //default : 0.02�� ���� ȣ��
    public void FixedUpdate() // �������� ���� ó���ϴµ� �̿�
    {
        Debug.Log("FixedUpdate");
    }

    //Update : �� �����Ӹ��� ȣ��Ǵ� �Լ�
    public void Update()
    {
        Debug.Log("Update");
        // Debug.Log(Time.deltaTime); //�� �����Ӵ� �����ϴ� �ð�
    }


}

