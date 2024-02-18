using TMPro;
using UnityEngine;

public class FireCountView : MonoBehaviour
{
    public TMP_Text text;
    

    private void OnEnable()
    {
        UpdateView(Manager.Data.FireCount);
        Manager.Data.OnFireCountChanged += UpdateView;   
    }
    private void OnDisable()
    {
        Manager.Data.OnFireCountChanged -= UpdateView;
    }
    private void UpdateView(int value)
    {
        text.text = value.ToString();
    }
}
