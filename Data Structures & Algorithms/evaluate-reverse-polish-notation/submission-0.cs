public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string token in tokens){
            if(token == "+"){
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left + right);
            }
            else if(token == "-"){
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left - right);
            }
            else if(token == "*"){
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left * right);
            }
            else if(token == "/"){
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left / right);
            }
            else{
                stack.Push(int.Parse(token));
            }

        }
        return stack.Pop();
    }
}
