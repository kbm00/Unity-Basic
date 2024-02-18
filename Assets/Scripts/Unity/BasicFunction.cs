using UnityEngine;

namespace Unity
{
    public class BasicFunction : MonoBehaviour
    {
        [Header("This")]
        public GameObject thisGameObject;
        public string thisName;
        public bool thisActive;
        public string thisTag;
        public int thisLayer;

        [Space(30)]
        [Header("GameObject")]
        public GameObject newGameObject;
        public GameObject destroyGameObject;
        public GameObject findWithName;
        public GameObject findWithTag;

        [Space(30)]
        [Header("Component")]
        public Component addComponent;
        public Component destroyComponent;
        public Component getComponent;
        public Component findComponent;


        private void Start()
        {
            ThisFunction();
            GameObjectFunction();
            ComponentFunction();
        }

        private void ThisFunction()
        {
            // <���� ���ӿ�����Ʈ ����>
            // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� MonoBehaviour�� ������ gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
            thisGameObject = gameObject;            // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ

            thisName = gameObject.name;             // ���ӿ�����Ʈ�� �̸�
            thisActive = gameObject.activeSelf;     // ���ӿ�����Ʈ�� Ȱ��ȭ ���� (activeInHierarchy : ���Ӿ����� Ȱ��ȭ ����)
            thisTag = gameObject.tag;               // ���ӿ�����Ʈ�� �±�
            thisLayer = gameObject.layer;           // ���ӿ�����Ʈ�� ���̾�
        }

        private void GameObjectFunction()
        {
            // <���ӿ�����Ʈ ����>
            newGameObject = new GameObject("NewGameObject");

            // <���ӿ�����Ʈ ����>
            if (destroyGameObject != null)
            {
                Destroy(destroyGameObject);
            }

            // <�� ���� ���ӿ�����Ʈ Ž��>
            findWithName = GameObject.Find("Main Camera");          // �̸����� ã��
            findWithTag = GameObject.FindWithTag("MainCamera");     // �±׷� ã��
        }

        private void ComponentFunction()
        {
            // <������Ʈ �߰�>
            addComponent = gameObject.AddComponent<Rigidbody>();    // ������Ʈ �߰�
            // newComponent = new Rigidbody();                      // �ǹ̾���, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Ҷ� �ǹ� ����

            // <������Ʈ ����>
            if (destroyComponent != null)
            {
                Destroy(destroyComponent);
            }

            // <������Ʈ Ž�� - ���� ���ӿ�����Ʈ���� ã��>
            getComponent = GetComponent<Collider>();

            // <������Ʈ Ž�� - ������ ã��>
            findComponent = FindObjectOfType<Camera>();
        }
    }
}
