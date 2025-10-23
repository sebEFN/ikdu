using UnityEngine;
using TMPro;

public class math : MonoBehaviour
{
    public TextMeshProUGUI voresText;
    public int startingNumber = 10;
    private int curentNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curentNumber = startingNumber;
        updateNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateNumber()
    {
        voresText.text = curentNumber.ToString();
    }
    public void plusNumber(int numberToPlus)
    {
        curentNumber += numberToPlus;
        updateNumber();
    }

     public void minusNumber(int numberToMinus)
    {
        curentNumber -= numberToMinus;
        updateNumber();
    }

    
}
