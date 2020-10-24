using System;
using System.Collections.Generic;
using System.Text;

namespace LogFileSample
{
    public class AddNumber
    {
        NLog nLog = new NLog();
        public int Add(int firstNumber, int secondNumber)
        {
            if(firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug unsuccessfull: Add()");
                nLog.LogError("Values entered by user should be greater than zero..");
                nLog.LogWarn("First or second number should be greater than zero");
            }                          
            int sum = firstNumber + secondNumber;
            nLog.LogDebug("Debug successfully: Add()");
            nLog.LogInfo("Add() passed.." + sum);
            return sum;
        }
    }
}
