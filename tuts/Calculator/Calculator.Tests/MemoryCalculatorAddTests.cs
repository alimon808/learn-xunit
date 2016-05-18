﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    [Collection("MemoryCalculator Collection")]
    public class MemoryCalculatorAddTests
    {
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorAddTests(MemoryCalculatorFixture fixture)
        {
            _fixture = fixture;
            _fixture.Sut.Clear();
        }

        [Fact]
        public void ShouldAddPositiveNumbers()
        {
            _fixture.Sut.Add(10);
            _fixture.Sut.Add(5);

            Assert.Equal(15, _fixture.Sut.CurrentValue);
        }

        [Fact]
        public void ShouldAddNegativeNumbers()
        {
            _fixture.Sut.Add(-5);
            _fixture.Sut.Add(-5);

            Assert.Equal(-10, _fixture.Sut.CurrentValue);
        }
    }
}
