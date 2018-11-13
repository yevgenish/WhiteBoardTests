using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class ParenthesesVerifier2 : IParenthesesVerifier
    {
        public bool IsValid(string parentheses)
        {
            var openersToClosers = new Dictionary<char, char>
                {
                    { '(', ')' },
                    { '[', ']' },
                    { '{', '}' }
                };

            var openers = new HashSet<char>(openersToClosers.Keys);
            var closers = new HashSet<char>(openersToClosers.Values);

            var openersStack = new Stack<char>();

            foreach (char c in parentheses)
            {
                if (openers.Contains(c))
                {
                    openersStack.Push(c);
                }
                else if (closers.Contains(c))
                {
                    if (openersStack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char lastUnclosedOpener = openersStack.Pop();

                        // If this closer doesn't correspond to the most recently
                        // seen unclosed opener, short-circuit, returning false
                        if (openersToClosers[lastUnclosedOpener] != c)
                        {
                            return false;
                        }
                    }
                }
            }
            return openersStack.Count == 0;
        }
    }
}
