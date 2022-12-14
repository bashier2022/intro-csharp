using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataStack
/// </summary>
public class DataStack
{
    private Stack<int> dataStack = new Stack<int>();

    public Action<int> stackViewPush;
    public Action stackViewPop;

    public DataStack(Action<int> stackViewerPush, Action stackViewerPop)
    {
        stackViewPush = stackViewerPush;
        stackViewPop = stackViewerPop;
    }
    public void PUSH(int data)
    {
        dataStack.Push(data);
        stackViewPush(data);
    }
    public int POP()
    {
        stackViewPop();
        return dataStack.Pop();
    }

    public int TOP()
    {
        return dataStack.Peek();
    }
    public bool EMPTY()
    {
        return dataStack.Count == 0;
    }
    public void CLEAR()
    {
        while (!EMPTY()) POP();
    }
    public int Count => dataStack.Count;
}