using UnityEngine;

public class menuManager : MonoBehaviour
{

[SerializeField]
    private GameObject video;
    [SerializeField]
    public GameObject math;
    [SerializeField]
    public GameObject madPanel;
 

    public void ChangeThat(string nameOfPanel)
    {
        video.SetActive(nameOfPanel == "video");
        math.SetActive(nameOfPanel == "math");
        madPanel.SetActive(nameOfPanel == "mad");
 
   }
}
