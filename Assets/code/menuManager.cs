using UnityEngine;

public class menuManager : MonoBehaviour
{

[SerializeField]
    private GameObject notwork;
    [SerializeField]
    public GameObject math;
    [SerializeField]
    public GameObject madPanel;
 

    public void ChangeThat(string nameOfPanel)
    {
        notwork.SetActive(nameOfPanel == "notwork");
        //math.SetActive(nameOfPanel == "math");
        madPanel.SetActive(nameOfPanel == "mad");
 
   }
}
