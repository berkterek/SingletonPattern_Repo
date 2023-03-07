using UnityEngine;

public class BackendManager : SingletonDestroyMono<BackendManager>
{
    [SerializeField] int _data1 = 5;
    [SerializeField] int _data2 = 10;
    [SerializeField] int _data3 = 15;
    
    public void DoSomething()
    {
        Debug.Log("BackendManager do something");
    }
}