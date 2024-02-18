/****************************************************
 *              ������ ���� Observer                *
 ****************************************************/

/*
 * <������ ����>
 * ��ü�� ���� ��ȭ�� ���� �� ������ ��ü���� ȣ���ϴ� ����� �ƴ�
 * �����ڵ��� �������ü�� ���� ��ȭ�� �����ϴ� ����� �����ϴ� ���
 * 
 * 
 * <����>
 * 0. C#�� ��� event delegate�� �̿��Ͽ� ������ ������ ���밡��
 * 1. Unity�� ��� UnityEvent�� �̿��Ͽ� ������ ������ ���밡��
 * 
 * 1. �������ü�� �����ڵ��� ��ϰ� �������� ���, ������ ����
 * 2. �����ڴ� �������ü�� ���� ��ȭ�� Ȯ���ϰ� ���� ��� ��Ͽ� ���
 * 3. �������ü�� ���� ��ȭ�� �ִ� ��� ����� �����ڵ��� ��ȸ�ϸ� �˸�
 * 
 * <����>
 * 1. Ŭ�������� ������ ���ᱸ���� ������ ��ü���� �ý����� ����
 * 2. ��������Ģ�� �ؼ��ϰ� ��
 * 
 * <������>
 * 1. �˸��� ���� ������ ���������� ����
 * 2. �̺�Ʈ ����, ��ȯ ���� ���� ������ �����ؾ� ��
 */


using System.Collections.Generic;

public class Observer
{
    public void Notify() { }
}

public class Subject
{
    private List<Observer> observerList = new List<Observer>();

    public void RegisterObserver(Observer observer)
    {
        observerList.Add(observer);
    }

    public void UnregisterObserver(Observer observer)
    {
        observerList.Remove(observer);
    }

    private void NotifyObserver()
    {
        foreach (Observer observer in observerList)
        {
            observer.Notify();
        }
    }
}