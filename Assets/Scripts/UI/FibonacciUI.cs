using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FibonacciUI : MonoBehaviour
{
    [SerializeField] private Text fibonacciNumber;

    // Updates the value of the fibonacci number.
    public void UpdateView(uint newFibonacciNumber)
    {
        fibonacciNumber.text = newFibonacciNumber.ToString();
    }
}
