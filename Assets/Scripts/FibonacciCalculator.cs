using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FibonacciCalculator : MonoBehaviour
{
    private uint olderPreviousNumber;
    private uint previousNumber;
    private uint currentFibonacciNumber;

    [SerializeField] FibonacciUI fibonacciUI;

    private void Start()
    {
        olderPreviousNumber = 0;
        previousNumber = 0;
        currentFibonacciNumber = 0;
        fibonacciUI.UpdateView(currentFibonacciNumber);
    }

    private uint CalculateNumber(uint olderPreviousNumber, uint previousNumber)
    {
        uint newNumber = olderPreviousNumber + previousNumber;
        switch (newNumber)
        {
            case 0:
                newNumber = 1;
                return newNumber;
            default:
                return newNumber;
        }
    }

    public void UpdateNumbers()
    {
        currentFibonacciNumber = CalculateNumber(olderPreviousNumber, previousNumber);
        olderPreviousNumber = previousNumber;
        previousNumber = currentFibonacciNumber;

        fibonacciUI.UpdateView(currentFibonacciNumber);
    }
}
