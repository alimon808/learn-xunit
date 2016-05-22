using System;
using DateMePlease.Entities;
using Xunit;

namespace DateMePlease.Tests
{
    public class MessageTests
    {
        private Message _sut;

        public MessageTests()
        {
            _sut = new Message();
        }
        [Fact]
        public void ShouldHaveIdAsInt()
        {
            Assert.IsType<int>(_sut.Id);
        }

        [Fact]
        public void ShouldHaveBodyAsString()
        {
            Assert.Equal(null, _sut.Body);

            _sut.Body = "this is the body";

            Assert.Equal("this is the body", _sut.Body);
        }
        
        [Fact]
        public void ShouldHaveMessageSentAsDateTime()
        {
            Assert.IsType<DateTime>(_sut.MessageSent);
        }

        [Fact]
        public void ShouldHaveReadAsBoolean()
        {
            Assert.IsType<bool>(_sut.Read);
            Assert.Equal(false, _sut.Read);
        }

        [Fact]
        public void ShouldHaveRecipientIdAsInt()
        {
            Assert.IsType<int>(_sut.RecipientId);
            Assert.Equal(0, _sut.RecipientId);
        }

        [Fact]
        public void ShouldHaveParentIdAsInt()
        {
            Assert.IsType<int>(_sut.ParentId);
            Assert.Equal(0, _sut.ParentId);
        }
    }
}
