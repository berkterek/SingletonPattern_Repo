using System.Collections;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        GameManager.Instance.DoSomething();
        BackendManager.Instance.DoSomething();
    }
}
