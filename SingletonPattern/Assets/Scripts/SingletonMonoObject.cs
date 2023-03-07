using UnityEngine;

public abstract class SingletonMonoObject<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; protected set; }

    protected virtual void Awake()
    {
        SetSingletonMono();
    }

    protected abstract void SetSingletonMono();
}

public abstract class SingletonDestroyMono<T> : SingletonMonoObject<T> where T: MonoBehaviour
{
    protected override void SetSingletonMono()
    {
        Instance = this as T;
    }
}

public abstract class SingletonDontDestroyMono<T> : SingletonMonoObject<T> where T : MonoBehaviour
{
    protected override void SetSingletonMono()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}