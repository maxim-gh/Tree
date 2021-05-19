using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        private Element _current;
        private Element _first;
        public int Count { get; private set; }

        public Tree()
        {
            _current = null;
            Count = 0;
        }

        private void AddElement(Element _current, int value)
        {
            if (_current.Value < value)
            {
                if (_current.Right == null)
                {
                    var newElement = new Element
                    {
                        Right = null,
                        Left = null,
                        Counter = 0,
                        Value = value
                    };
                    _current.Right = newElement;
                }
                else
                { 
                    _current = _current.Right;
                    AddElement(_current,value);
                    return;
                }
            }
            if (_current.Value > value)
            {
                if (_current.Left == null)
                {
                    var newElement = new Element
                    {
                        Right = null,
                        Left = null,
                        Counter = 0,
                        Value = value
                    };
                    _current.Left = newElement;
                }
                else
                {
                    _current = _current.Left;
                    AddElement(_current, value);

                }
                
            }
            if (_current.Value == value && Count != 0)
            {
                _current.Counter++;
            }
        }
        public void AddElement(int value)
        {
            if (Count == 0)
            {
                var newElement = new Element
                {
                    Right = null,
                    Left = null,
                    Counter = 0,
                    Value = value
                };
                _current = newElement;
                _first = _current;
            }
            else
            {
                _current = _first;
                AddElement(_current, value); 
            }
            Count++;
        }

        private bool Search(int value, Element _current, out int counter)
        {
            counter = 0;

            if (value > _current.Value)
            {
                if (_current.Right == null)
                {
                    return false;
                }
                else
                {
                    _current = _current.Right;
                    return Search(value, _current, out counter);
                }
                
            }
            else if (value < _current.Value)
            {
                if (_current.Left == null)
                {
                    return false;
                }
                else
                {
                    _current = _current.Left;
                    return Search(value, _current, out counter);
                }
            }
            else
            {
                counter = _current.Counter;
                return true;
            }
        }
        public bool Search(int value, out int counter)
        {
            _current = _first;
            return Search(value, _current, out counter);
        }
    }
}