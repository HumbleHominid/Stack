namespace Stack
{
    public class Stack<T>
    {
        #region Members
        private T[] _stack_array;
        private int _maximum_length;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            _maximum_length = length;
            _stack_array = new T[length];
        }
        #endregion

        #region Public Methods
        public void Push(T value)
        {
            if (Size == _maximum_length)
            {
                throw new ExceededSizeException();
            }

            _stack_array[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }
            return _stack_array[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }

            return _stack_array[Size - 1];
        }
        #endregion
    }
}
