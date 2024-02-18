using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    public UnityAction<int> OnFireCountChanged;

    public int FireCount { set { fireCount = value; OnFireCountChanged?.Invoke(value); } get { return fireCount; } }

    
}
