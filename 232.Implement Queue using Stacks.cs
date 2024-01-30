﻿using System.Collections.Generic;

public class MyQueue
{
    Stack<int> st = new();
    Stack<int> rev = new();

    public void Push(int x)
    {
        Pump(from: rev, to: st);
        st.Push(x);
    }

    public int Pop() => GetFirst(isPop: true);

    public int Peek() => GetFirst(isPop: false);

    public bool Empty() => st.Count + rev.Count == 0;

    private int GetFirst(bool isPop)
    {
        Pump(from: st, to: rev);
        return isPop ? rev.Pop() : rev.Peek();
    }

    private void Pump(Stack<int> from, Stack<int> to)
    {
        while (from.Count > 0) to.Push(from.Pop());
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */