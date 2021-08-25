using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }
}
