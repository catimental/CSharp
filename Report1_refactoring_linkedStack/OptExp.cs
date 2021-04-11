namespace Report1
{
    public class OptExp
    {
        private string _expression;
        
        public string Expression
        {
            get => _expression;
            set => _expression = value;
        }

        public bool TestPair(string expression)
        {
            this.Expression = expression;
            return this.TestPair();
        }

        public bool TestPair()
        {
            var linkedStackForTest = new LinkedStack();
            
            foreach (var expressionCharacter in this.Expression)
            {
                if (IsOpenedBracketCharacter(expressionCharacter))
                {
                    linkedStackForTest.Push(expressionCharacter);
                } 
                else if (IsClosedBracketCharacter(expressionCharacter))
                {
                    if (linkedStackForTest.IsEmpty())
                    {
                        return false;
                    }
                    else 
                    {
                        //_openPair = linkedStackForTest.Pop();
                        char openPair = linkedStackForTest.Pop();
                        //if ((openPair == '(' && currentExpression != ')') || (openPair == '{' && currentExpression != '}')
                        //                                                  || (openPair == '[' && currentExpression != ']'))
                        if(!IsValidCloseBracketCharacter(openPair, expressionCharacter))
                            return false;
                    }
                }

            }
            return linkedStackForTest.IsEmpty();
        }

        private static bool IsValidCloseBracketCharacter(char openedBracket, char currentBracket)
        {
            char? closedBracketCharacter = GetClosedBracketCharacter(openedBracket);
            //closedBracketCharacter가 null이면 등록된 Bracket가 아님
            //closedBracketCharacter이랑 현재 열린 currentBracket이 같다면 valid이므로 return true
            return closedBracketCharacter != null && closedBracketCharacter == currentBracket;
        }
        
        private static char? GetClosedBracketCharacter(char openedBracket)
        {
            switch (openedBracket)
            {
                case '(': return ')';
                case '[': return ']';
                case '{': return '}';
                default:
                    return null;
            }
        }
        
        private static bool IsOpenedBracketCharacter(char openedBracket)
        {
            switch (openedBracket)
            {
                case '(':
                case '{':
                case '[':
                    return true;
                default:
                    return false;
            }
        }

        private static bool IsClosedBracketCharacter(char closedBracket)
        {
            switch (closedBracket)
            {
                case ')':
                case '}':
                case ']':
                    return true;
                default:
                    return false;
            }
        }        
    }
}