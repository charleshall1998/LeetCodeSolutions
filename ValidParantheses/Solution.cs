namespace ValidParantheses
{
    public class Solution
    {
        /**
         * Pseudo Code:
         * 1) If the string length is odd, return false
         * 2) Create a stack
         * 3) Iterate over the string
         * 4) If the character is an opening bracket, push it to the stack
         * 5) If the character is a closing bracket, check if the stack is empty or the top of the stack is not the corresponding opening bracket
         * 6) If it is not corrsponding to the opening bracket or the stack is empty, return false
         * 7) Else, pop the top of the stack
         * 8) If the stack is empty after iteration, return true
         */
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                {
                    stack.Push(c);
                }
                else if (c.Equals(')') && stack.Count() != 0 && stack.Peek().Equals('(')) stack.Pop();
                else if (c.Equals(']') && stack.Count() != 0 && stack.Peek().Equals('[')) stack.Pop();
                else if (c.Equals('}') && stack.Count() != 0 && stack.Peek().Equals('{')) stack.Pop();
                else return false;
            }

            return stack.Count == 0;
        }
    }
}
