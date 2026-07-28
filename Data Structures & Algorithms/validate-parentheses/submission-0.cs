public class Solution {
    public bool IsValid(string s) {
        if (s.Length %2 !=0 ) return false;
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> CloseToOpen = new Dictionary<char, char>{
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        foreach (char c in s){
            if(CloseToOpen.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == CloseToOpen[c]){
                    stack.Pop();
                }
            
                else{
                    return false;
                }
            }
            else{
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
