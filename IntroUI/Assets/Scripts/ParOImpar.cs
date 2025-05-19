using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ParOImpar : MonoBehaviour
{
    public TMP_InputField inputNum1;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void DecirParImpar()
    {
        num1 = int.Parse(inputNum1.text);
        if (num1 % 2 == 0)
        {
            Debug.Log(num1 + " es par");
        }
        else
        {
            Debug.Log(num1 + " es impar");
        }
    }
}
