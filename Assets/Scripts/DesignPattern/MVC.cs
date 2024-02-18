/****************************************************
 *                 ������ ���� MVC                  *
 ****************************************************/

/*
 * <MVC (Model-View-Controller) ����>
 * ����� �������̽�, ������, �������� �и��Ͽ� ���α׷��� �����ϴ� ����
 * 
 * <����>
 * Model
 *  ���α׷��� ������
 *  Controller�� ���� ����
 *  �������� ������ View���� �˸�
 * View
 *  ����� �������̽�
 *  Model�� �����͸� ������� ����ڿ��� ���� ǥ��
 *  ����ڿ��� �Է��� �޾� Controller���� �˸�
 * Controller
 *  ������
 *  View�� �Է��� �޾� �������� ó��
 *  �������� ����� Model�� ����
 * 
 * <����>
 * 1. �������� �� ���� �ܼ��ϰ� ��������
 * 2. ���α׷��� ���� ��Ҹ� ������� ���� ��ĥ �� �ֵ��� ����
 * 3. ����������, ���ø����̼��� Ȯ�强, �������� �ڵ����뼺�� ������
 * 
 * <������>
 * 1. Model�� View ������ �������� ���� �ʵ��� ����
 * 
 * <�� ��>
 * MVC ������ �Ļ����� MVP(Model-View-Presenter), MVVM(Model-View-ViewModel) ������ ����
 */

using UnityEngine;
using UnityEngine.Events;

public class Model
{
    private int data;
    public int Data
    {
        set
        {
            Debug.Log("[Model] changed event");
            data = value;
            OnDataChanged?.Invoke(value);
        }
        get
        {
            return data;
        }
    }

    public UnityAction<int> OnDataChanged;
}

public class View
{
    public Controller controller;

    public void UpdateData(int data)
    {
        Debug.Log("[View] Update data");
    }

    public void Input()
    {
        Debug.Log("[View] Input");
        controller.Logic();
    }
}

public class Controller
{
    public Model model;

    public void Logic()
    {
        Debug.Log("[Controller] Logic");
        model.Data += 1;
    }
}

public class MVCTester
{
    public void Test()
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller();

        view.controller = controller;
        controller.model = model;
        model.OnDataChanged += view.UpdateData;

        view.Input();
        // 1. [View] Input
        // 2. [Controller] Logic
        // 3. [Model] changed event
        // 4. [View] Update data
    }
}
