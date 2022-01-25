using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FibonacciCalculator : MonoBehaviour
{
    private uint olderPreviousNumber;
    private uint previousNumber;
    private uint currentFibonacciNumber;

    [SerializeField] FibonacciUI fibonacciUI;

    // Sets all values to zero and updates the UI on start.
    private void Start()
    {
        olderPreviousNumber = 0;
        previousNumber = 0;
        currentFibonacciNumber = 0;
        fibonacciUI.UpdateView(currentFibonacciNumber);
    }

    #region Calculate

    // Calculates what number is next.
    private uint CalculateNextNumber(uint olderPreviousNumber, uint previousNumber)
    {
        uint currentNumber = olderPreviousNumber + previousNumber;

        switch (currentNumber)
        {
            case 0:
                currentNumber = 1;
                return currentNumber;
            default:
                return currentNumber;
        }
    }

    // Calculates what number was previous.
    private uint CalculatePreviousNumber(uint olderPreviousNumber, uint previousNumber)
    {
        // Returns 0 if previous number was 0
        if (previousNumber == 0)
        {
            return 0;
        }

        uint newNumber = currentFibonacciNumber - olderPreviousNumber;

        // ...Otherwise return a new number
        return newNumber;
    }

    #endregion

    #region Show

    // Updates all values if button previous is clicked and shows current value.
    public void ShowPreviousNumber()
    {
        // Can't go below zero
        if (currentFibonacciNumber == 0)
        {
            return;
        }

        currentFibonacciNumber = CalculatePreviousNumber(olderPreviousNumber, previousNumber);
        previousNumber = olderPreviousNumber;
        olderPreviousNumber = currentFibonacciNumber - previousNumber;

        fibonacciUI.UpdateView(currentFibonacciNumber);
    }

    // Updates all values if button next is clicked and shows current value.
    public void ShowNextNumber()
    {
        olderPreviousNumber = previousNumber;
        previousNumber = currentFibonacciNumber;
        currentFibonacciNumber = CalculateNextNumber(olderPreviousNumber, previousNumber);

        fibonacciUI.UpdateView(currentFibonacciNumber);
    }

    #endregion
}
