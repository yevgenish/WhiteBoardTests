using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class ParenthesesVerifier : IParenthesesVerifier
    {
        private enum PType
        {
            Opening,
            Closing
        }

        public bool IsValid(string parentheses)
        {
            //bool res = false;

            Stack<char> stack = new Stack<char>();
            foreach (var item in parentheses)
            {
                if(item == default(char))
                {
                    //break;
                    return false;
                }

                char lastAdded = default(char);
                if (stack.Any())
                {
                    lastAdded = stack.Peek();
                }                

                //PType lastAddedPType = GetPType(lastAdded);
                PType itemPType = GetPType(item);
                char itemOpposite = GetOpposite(item);

                if (lastAdded == default(char) && itemPType == PType.Closing)
                {
                    //res = false;
                    //break;
                    return false;
                }
                else if((lastAdded == default(char) || (lastAdded != default(char)
                    && GetPType(lastAdded) == PType.Opening)) && itemPType == PType.Closing && lastAdded != itemOpposite)
                {
                    //res = false;
                    //break;
                    return false;
                }
                else
                {
                    if (lastAdded == itemOpposite)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(item);
                    }
                }
            }

            if (!stack.Any())
            {
                //res = true;
                return true;
            }

            //return res;

            return false;
        }

        private char GetOpposite(char item)
        {
            char res = default(char);
            switch (item)
            {
                case '(':
                    res = ')';
                    break;
                case ')':
                    res = '(';
                    break;
                case '[':
                    res = ']';
                    break;
                case ']':
                    res = '[';
                    break;
                case '{':
                    res = '}';
                    break;
                case '}':
                    res = '{';
                    break;
                default:
                    throw new KeyNotFoundException("Specified element was not found: " + item.ToString());
                    break;
            }

            return res;
        }

        private PType GetPType(char item)
        {
            char[] opening = new char[3] { '(', '[', '{'};
            char[] closing = new char[3] { ')', ']', '}' };
            if (opening.Contains(item))
            {
                return PType.Opening;
            }
            else if (closing.Contains(item))
            {
                return PType.Closing;
            }
            else
            {
                throw new KeyNotFoundException("Specified element was not found: " + item.ToString());
            }
        }

    }
}
