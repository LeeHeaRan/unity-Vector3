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
        //덧셈과 뺄셈, 스칼라 곱
        Vector3 v1 = new Vector3(1f, 2f);
        Vector3 v2 = new Vector3(2f, 1f);

        Debug.Log("v1+v2= " + (v1 + v2));
        Debug.Log("v1-v2= " + (v1 - v2));
        Debug.Log("v1*-1=" + (v1 * -1));
    }

    private void VectorLength()
    {
        //벡터의 길이(속도)를 구하는 함수 magnitude -스칼라 반환
        Vector3 v1 = new Vector3(2f, 2f);
        Debug.Log("length of v1= " + v1.magnitude); //길이를 구하는 함수.
    }
    private void NormalizeVector3()
    {
        //정규화하는 함수 nomalized -벡터 반환
        Vector3 v1 = new Vector3(2f, 2f);
        Debug.Log("nomalized v1= " + v1.normalized); //정규화 하는 함수.
        Debug.Log("length of nomalized v1= " + v1.normalized.magnitude); //스칼라 반환
    }

    private void DotVectro()
    {
        Vector3 v0 = new Vector3(2f, 0f);
        Vector3 v1 = new Vector3(1f, 1f);
        Vector3 v2 = new Vector3(0f, 2f);
        Vector3 v3 = new Vector3(-1f, 1f);

        //내적을 구하는 함수 Dot -실수형 반환
        Debug.Log("벡터의 내적값45: " + Vector3.Dot(v0, v1)); //90도 보다 작으니까 2
        Debug.Log("벡터의 내적값90: " + Vector3.Dot(v0, v2)); //90도 와 같으니까 0
        Debug.Log("벡터의 내적값135: " + Vector3.Dot(v0, v3)); //90도 보다 크니까 -2

        //v0와 vN사이의 각도를 구하는 함수 Angle =각도 반환 실수형
        Debug.Log("벡터의 각도45: " + Vector3.Angle(v0, v1));
        Debug.Log("벡터의 각도90: " + Vector3.Angle(v0, v2));
        Debug.Log("벡터의 각도135: " + Vector3.Angle(v0, v3));

    }

   private void CrossVector()
    {
        Vector3 v1 = new Vector3(2, 0, 0);
        Vector3 v2 = new Vector3(0, 0, 2);

        //외적을 구하는 함수 Cross -벡터 반환
        //v1과 v2사이의 90도를 이루는 벡터를 구함.
        Debug.Log("v1 * v2: " + Vector3.Cross(v1, v2));
        Debug.Log("angle v1 to Cross result = " + Vector3.Angle(v1, Vector3.Cross(v1, v2))); //v1과의 각도를 계산하면 90도이다.
        Debug.Log("angle v2 to Cross result = " + Vector3.Angle(v2, Vector3.Cross(v1, v2))); //v2과의 각도를 계산하면 90도이다.
    }
}
