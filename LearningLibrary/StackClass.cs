using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class StackClass
    {
        private readonly List<object> _stack = new List<object>();
        public void Push(object obj)   
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Value it shouldn't be null");
            }
         _stack.Add(obj);                     
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("No elements in stack");
            }
            var index = _stack.Count - 1;
            var toReturn = _stack[index];

            _stack.RemoveAt(index);
            return (toReturn);
        }   
        
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
