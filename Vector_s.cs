using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_s : MonoBehaviour
{
    void Start()
    {
        AddSubVector();
        VectorLength();
        NormalizeVector3();
        DotVectro();
        CrossVector();

    }
    
    private void AddSubVector()
    {
        //������ ����, ��Į�� ��
        Vector3 v1 = new Vector3(1f, 2f);
        Vector3 v2 = new Vector3(2f, 1f);

        Debug.Log("v1+v2= " + (v1 + v2));
        Debug.Log("v1-v2= " + (v1 - v2));
        Debug.Log("v1*-1=" + (v1 * -1));
    }

    private void VectorLength()
    {
        //������ ����(�ӵ�)�� ���ϴ� �Լ� magnitude -��Į�� ��ȯ
        Vector3 v1 = new Vector3(2f, 2f);
        Debug.Log("length of v1= " + v1.magnitude); //���̸� ���ϴ� �Լ�.
    }
    private void NormalizeVector3()
    {
        //����ȭ�ϴ� �Լ� nomalized -���� ��ȯ
        Vector3 v1 = new Vector3(2f, 2f);
        Debug.Log("nomalized v1= " + v1.normalized); //����ȭ �ϴ� �Լ�.
        Debug.Log("length of nomalized v1= " + v1.normalized.magnitude); //��Į�� ��ȯ
    }

    private void DotVectro()
    {
        Vector3 v0 = new Vector3(2f, 0f);
        Vector3 v1 = new Vector3(1f, 1f);
        Vector3 v2 = new Vector3(0f, 2f);
        Vector3 v3 = new Vector3(-1f, 1f);

        //������ ���ϴ� �Լ� Dot -�Ǽ��� ��ȯ
        Debug.Log("������ ������45: " + Vector3.Dot(v0, v1)); //90�� ���� �����ϱ� 2
        Debug.Log("������ ������90: " + Vector3.Dot(v0, v2)); //90�� �� �����ϱ� 0
        Debug.Log("������ ������135: " + Vector3.Dot(v0, v3)); //90�� ���� ũ�ϱ� -2

        //v0�� vN������ ������ ���ϴ� �Լ� Angle =���� ��ȯ �Ǽ���
        Debug.Log("������ ����45: " + Vector3.Angle(v0, v1));
        Debug.Log("������ ����90: " + Vector3.Angle(v0, v2));
        Debug.Log("������ ����135: " + Vector3.Angle(v0, v3));

    }

   private void CrossVector()
    {
        Vector3 v1 = new Vector3(2, 0, 0);
        Vector3 v2 = new Vector3(0, 0, 2);

        //������ ���ϴ� �Լ� Cross -���� ��ȯ
        //v1�� v2������ 90���� �̷�� ���͸� ����.
        Debug.Log("v1 * v2: " + Vector3.Cross(v1, v2));
        Debug.Log("angle v1 to Cross result = " + Vector3.Angle(v1, Vector3.Cross(v1, v2))); //v1���� ������ ����ϸ� 90���̴�.
        Debug.Log("angle v2 to Cross result = " + Vector3.Angle(v2, Vector3.Cross(v1, v2))); //v2���� ������ ����ϸ� 90���̴�.
    }
}
