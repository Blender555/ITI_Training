using System;
using System.Collections;
using System.Collections.Generic;


namespace lab_1_linq
{
    public class CustomCollection : IEnumerable<int>
    {
        private List<int> _numbers = new List<int> { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var number in _numbers)
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class CustomEnumerator : IEnumerator<int>
        {
            private List<int> _numbers;
            private int _position = -1;

            public CustomEnumerator(List<int> numbers)
            {
                _numbers = numbers;
            }

            public int Current
            {
                get
                {
                    if (_position < 0 || _position >= _numbers.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return _numbers[_position];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                _position++;
                return (_position < _numbers.Count);
            }

            public void Reset()
            {
                _position = -1;
            }
        }
    }
}
