using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class divisionProhibida : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    int num1;
    int num2;
    string txtResultado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Dividirnumeros()
    {
        num1 = int.Parse(inputNum1.text);
        num2 = int.Parse(inputNum2.text);
    
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir entre cero");
        }
        else
        {
            txtResultado = (num1 / num2).ToString();
            Debug.Log(num1 + " entre " + num2 + " da " + txtResultado);
        }
    }
}

