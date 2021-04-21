namespace Count
{
    public class Counter
    {
        private int _currentCount;

        public Counter()
        {
            _currentCount = 0;
        }

        public delegate void CounterHandler(int countReached);
        public event CounterHandler OnValueReached;

        public void Count(int neededCount)
        {
            for (int i = 0; i < 100; i++)
            {
                _currentCount = i;
                if (_currentCount == neededCount)
                {
                    OnValueReached?.Invoke(_currentCount);
                }
            }
        }
    }
}
