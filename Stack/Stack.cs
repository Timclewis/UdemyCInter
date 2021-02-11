using System;
using System.Collections.Generic;
namespace Stack
{
    public class Stack
    {
        private List<Object> _myStack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object cannot be null");
           
            _myStack.Add(obj);
        }

        public object Pop()
        {
            if (_myStack.Count == 0)
                throw new InvalidOperationException("The stack cannot be empty");

            var LastElement = _myStack[_myStack.Count - 1];
            _myStack.RemoveAt(_myStack.Count - 1);
            return LastElement;       
        }

        public void Clear()
        {         
            _myStack.Clear();
        }
    }
}
