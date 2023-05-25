Console.WriteLine("20ValidParentheses!");

// using Stack
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var k = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(') { k.Push(')'); continue; }
            if (c == '{') { k.Push('}'); continue; }
            if (c == '[') { k.Push(']'); continue; }
            if (k.Count == 0 || c != k.Pop()) return false;
        }
        return k.Count == 0;
    }
}

// using .Replace
//public class ValidParentheses
//{
//    public bool IsValid(string s)
//    {
//        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
//        {
//            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
//        }

//        return s.Length == 0;
//    }
//}