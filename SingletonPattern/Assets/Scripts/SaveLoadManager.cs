

public class SaveLoadManager
{
    static SaveLoadManager _instance;
    static object _lock = new object();

    private SaveLoadManager()
    {
        
    }

    public static SaveLoadManager SingletonCreate()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new SaveLoadManager();
            }

            return _instance;    
        }
    }
    
    public void SaveData(string key, object value)
    {
        
    }

    public T LoadData<T>(string key)
    {
        return default;
    }
}