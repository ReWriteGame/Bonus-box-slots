using UnityEngine;
using UnityEngine.Events;

public class Chest : MonoBehaviour
{
    [SerializeField] private GameObject open;
    [SerializeField] private GameObject close;

    public UnityEvent openEvent;
    public UnityEvent closeEvent;

    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        close.SetActive(true);
        open.SetActive(false);
    }

    public void Open()
    {
        close.SetActive(false);
        open.SetActive(true);
        openEvent?.Invoke();
    }

    public void Close()
    {
        close.SetActive(true);
        open.SetActive(false);
        closeEvent?.Invoke();
    }

}
