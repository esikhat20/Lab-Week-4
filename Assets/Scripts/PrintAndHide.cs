using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        rand = Random.Range(200, 251);
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        //deactive game object
        if ( (gameObject.tag == "Red") && (i == 100) ) {
            gameObject.SetActive(false);
        }
        //disable renderer component of game object 
        if ( (gameObject.tag == "Blue") && (i == rand) ) {
            rend.enabled = false;
        }
    }
}
