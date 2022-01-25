using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FibonacciUI : MonoBehaviour
{
    [SerializeField] private Text fibonacciNumber;

    [SerializeField] private Text[] fibonacciNumbers;

    private void Start()
    {
        foreach (Text text in fibonacciNumbers)
        {
            text.gameObject.GetComponent<Text>().color = Color.black;
        }
    }

    // Updates the value of the fibonacci number & updates color of text.
    public void UpdateView(uint newFibonacciNumber)
    {
        fibonacciNumber.text = newFibonacciNumber.ToString();

        foreach (Text text in fibonacciNumbers)
        {
            text.gameObject.GetComponent<Text>().color = Color.black;
            if (newFibonacciNumber.ToString() == text.text)
            {
                text.gameObject.GetComponent<Text>().color = Color.green;
            }
        }
    }
}
