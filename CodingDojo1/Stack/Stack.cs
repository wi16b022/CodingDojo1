using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class Stack<T>
    {
        private StackElement<T> presentElement;

        public void Push(T element)
        {
            if (presentElement == null)
            {
                presentElement = new StackElement<T>() { Value = element, Predecessor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T> { Value = element, Predecessor = presentElement };
                presentElement = temp;
            }

        }

        public T Pop()
        {

            if (presentElement == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                T temp = presentElement.Value;
                presentElement = presentElement.Predecessor;
                return temp;
            }

        }

        public T Peek()
        {
            if (presentElement == null)
            {
                return default(T);
            }
            else
            {
                return presentElement.Value;
            }
        }
    }
}
