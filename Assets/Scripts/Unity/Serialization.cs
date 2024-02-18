using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity
{
    public class UnitySerialization : MonoBehaviour
    {
        /*********************************************************************
         * ����ȭ (Serialization)
         * 
         * ������ ���� �Ǵ� ���ӿ�����Ʈ ���¸� �����ϰ� �����ϴ� ���
         * �ν����� â���� ������Ʈ�� ����ȭ�� ������� ���� ������
         * �̸� �̿��Ͽ� �ҽ��ڵ��� ���� ���� ����Ƽ �����Ϳ��� ���� ���� ����
         **********************************************************************/

        // <������ ����ȭ>
        // ������Ʈ�� ������� ���� Ȯ���ϰų� ����
        // ������Ʈ�� ������� ������ �巡�� �� ��� ������� ����

        [Header("Value")]
        // C# Type
        public bool boolValue;
        public int intValue;
        public float floatValue;
        public string stringValue;

        // Unity Type
        public Vector3 vector3;
        public Vector3Int vector3Int;
        public Vector2 vector2;
        public Vector2Int vector2Int;
        public Color color;
        public Rect rect;
        public LayerMask layerMask;
        public AnimationCurve curve;
        public Gradient gradient;

        // ������
        public ForceMode mode;

        // ����ȭ ������ �ʵ��� �迭 �� List<T>
        public int[] array;
        public List<int> list;

        [Header("Reference")]
        // Object Type
        public new GameObject gameObject;
        public new Transform transform;
        public new Rigidbody rigidbody;
        public new Collider collider;



        // <��Ʈ����Ʈ>
        // Ŭ����, �Ӽ� �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

        [Space(30)]

        [Header("Unity Attribute")]

        [SerializeField]
        private int privateValue;

        [HideInInspector]
        public int publicValue;

        [Range(0, 10)]
        public float rangeValue;

        [TextArea(3, 5)]
        public string textField;

        [Serializable] // ����ü�� ����ȭ ���� �Ӽ��� ����
        public struct StructType
        {
            public int value1;
            public string value2;
        }
        public StructType structField;

        [Serializable] // Ŭ������ ����ȭ ���� �Ӽ��� ����
        public class ClassType
        {
            public int value1;
            public string value2;
        }
        public ClassType classField;
    }
}
