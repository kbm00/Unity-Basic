using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance;
    

    [SerializeField] GameManager gameManager;
    [SerializeField] DataManager dataManager;

    public static Manager Inst { get { return instance; } }
    public static GameManager Game { get { return instance.gameManager; } }
    public static DataManager Data { get { return instance.dataManager; } }


    

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Singleton already exist");
            Destroy(this);

            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    private void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }
}
