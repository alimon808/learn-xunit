﻿using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.Tests
{
    public class MemoryCalculatorTests : IClassFixture<MemoryCalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutput;
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorTests(ITestOutputHelper helper, MemoryCalculatorFixture fixture)
        {
            _testOutput = helper;
            _fixture = fixture;

            _fixture.Sut.Clear();
        }

        [Fact]
        public void ShouldAdd()
        {
            _testOutput.WriteLine("Executing ShouldAdd");

            _fixture.Sut.Add(10);
            _fixture.Sut.Add(5);

            Assert.Equal(15, _fixture.Sut.CurrentValue);
        }

        [Fact]
        public void ShouldSubtract()
        {
            _testOutput.WriteLine("Executing ShouldSubtract");

            _fixture.Sut.Subtract(5);

            Assert.Equal(-5, _fixture.Sut.CurrentValue);
        }

        [Fact]
        public void ShouldDivide()
        {
            _testOutput.WriteLine("Executing ShouldDivide");

            _fixture.Sut.Add(10);
            _fixture.Sut.Divide(2);

            Assert.Equal(5, _fixture.Sut.CurrentValue);
        }
        
    }
}
