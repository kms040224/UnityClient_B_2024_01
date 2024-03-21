using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    //public ���� ����� ������ �ٸ� ��ũ��Ʈ���� ���� ���� ����
    public int publicValue;

    //private ���� ����� ������ ���� Ŭ���� �������� ���� ����
    private int privateValue;

    //protected�� ����� ������  ���� Ŭ���� �� �Ļ� Ŭ�������� ���� ����
    protected int protectedValue;

    //internal�� ����� ������ ���� �����(������Ʈ �� �ٸ� ��ũ��Ʈ) ������ ���� ����
    internal int internalValue;


}

public class ParentClass  : MonoBehaviour
{
    public int protectedValueParent;
}

public class ChildClass : ParentClass
{ 
    void start()
    {
        Debug.Log(protectedValueParent);
    }
}


