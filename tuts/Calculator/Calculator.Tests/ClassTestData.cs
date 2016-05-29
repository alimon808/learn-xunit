using System.Collections;
using System.Collections.Generic;

namespace Calculator.Tests
{
    public abstract class ClassTestData : IEnumerable<object[]>
    {
        protected abstract List<object[]> TestData { get; }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<object[]> GetEnumerator() => TestData.GetEnumerator();

    }
}
