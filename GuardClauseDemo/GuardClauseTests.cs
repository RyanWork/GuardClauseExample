using System;
using FluentAssertions;
using Moq;
using Xunit;

namespace GuardClauseDemo
{
    public class GuardClauseTests
    {
        [Fact]
        public void CustomMessageGuardClause()
        {
            Action objectCreationAction = () => new SomeDomainObject(string.Empty, It.IsAny<string>());

            objectCreationAction.Should().Throw<ArgumentException>()
                .WithMessage("Custom Message (Parameter 'property1')");
        }

        [Fact]
        public void CustomGuardClause()
        {
            Action objectCreationAction = () => new SomeDomainObject("asdf", "Zeshan");

            objectCreationAction.Should().Throw<ArgumentException>()
                .WithMessage("Disgusting*");
        }
    }
}