using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDontDestroyMono<GameManager>
{
    [SerializeField] int _data1 = 5;
    [SerializeField] int _data2 = 10;
    [SerializeField] int _data3 = 15;

    public void DoSomething()
    {
        Debug.Log(nameof(DoSomething));
    }

    [ContextMenu(nameof(SetSameScene))]
    public void SetSameScene()
    {
        SaveLoadManager saveLoadManager = SaveLoadManager.SingletonCreate();
        SceneManager.LoadScene(0);
    }
}