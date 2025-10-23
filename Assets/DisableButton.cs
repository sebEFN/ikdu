using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public GameObject myButton;
    float curentTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (curentTime <= 3f)
        {
            curentTime += Time.deltaTime;
            GetComponent<Button>().interactable = false;
            Debug.Log("meow");
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
    }
}
