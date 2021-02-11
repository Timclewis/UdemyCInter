using System;
using System.Collections.Generic;
namespace Stack
{
    public class Stack
    {
        private List<object> _myStack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object cant be null");

            _myStack.Add(obj);

        }

        public object Pop()
        {
            if (_myStack.Count == 0)
                throw new InvalidOperationException("Stack cant be empty");

            var FinalElement = _myStack[_myStack.Count - 1];
            _myStack.RemoveAt(_myStack.Count  - 1);

            return FinalElement;

        }

        public void Clear()
        {
            _myStack.Clear();
        }
    }
}
