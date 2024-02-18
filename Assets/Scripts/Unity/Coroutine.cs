using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    /**********************************************************************************
        * �ڷ�ƾ (Coroutine)
        * 
        * �۾��� �ټ��� �����ӿ� �л��Ͽ� ó���ϴ� �񵿱�� �۾�
        * ������ �Ͻ������ϰ� �ߴ��� �κк��� �簳�Ͽ� ó���ϴ� ������ �۾��� �л�ó����
        * �ڷ�ƾ�� �����尡 �ƴϸ� �ڷ�ƾ�� �۾��� ���� �����忡�� ����
        **********************************************************************************/

    // <�ڷ�ƾ �ݺ� �۾�>
    // IEnumerator�� ��ȯ������ �Լ��� ����
    IEnumerator Routine()
    {
        Debug.Log(0);
        yield return new WaitForSeconds(1f);
        Debug.Log(1);
        yield return new WaitForSeconds(1f);
        Debug.Log(2);
        yield return new WaitForSeconds(1f);
        Debug.Log(3);
        yield return new WaitForSeconds(1f);
        Debug.Log(4);
        yield return new WaitForSeconds(1f);
        Debug.Log(5);
    }

    // <�ڷ�ƾ ����>
    // �ڷ�ƾ�� �����ϴ� ��ü�� �����ϴ� ����
    Coroutine coroutine;

    // <�ڷ�ƾ ����>
    // StartCoroutine�� ���� ����
    private void OnEnable()
    {
       // coroutine = StartCoroutine(Routine());
    }

    // <�ڷ�ƾ ����>
    // StopCoroutine�� ���� �ڷ�ƾ ����
    // StopAllCoroutines�� ���� �������� ��� �ڷ�ƾ ����
    // �ݺ������� �۾��� ��� �Ϸ�Ǿ��� ��� �ڵ� ����
    // �ڷ�ƾ�� �������� ���ӿ�����Ʈ�� ��Ȱ��ȭ�� ��� �ڵ� ����
    private void OnDisable()
    {
       /* StopCoroutine(coroutine);
       StopAllCoroutines(); */
    }

    // <�ڷ�ƾ ����>
    // �ڷ�ƾ�� �ݺ��۾� �� ����ó���� �����Ͽ� �۾��� ���� Ÿ�̹��� ������ �� ����
    IEnumerator CoroutineWait()
    {
        yield return null;                              // �� ������ ����
        yield return new WaitForSeconds(1f);            // n�ʰ� �ð� ����
        yield return new WaitForSecondsRealtime(1f);    // ���� n�ʰ� �ð� ����
        yield return new WaitForFixedUpdate();          // FixedUpdate ���� ����
        yield return new WaitForEndOfFrame();           // �������� ������ ����
        yield return new WaitUntil(() => true);         // ������ �����Ҷ����� ����
    }
}
