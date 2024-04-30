namespace DiamondKata.Tests
{
    public class Given_A_Should_Return_A_Test
    {
        [Fact]
        public void Given_A_Should_Return_A()
        {
            // Arrange
            var input = 'A';

            // Act
            var result = DiamondPrinter.Print(input);

            // Assert
            Assert.Equal("A", result);
        }
    }

    public class Given_C_Should_Return_C_Diamond_Test
    {
        [Fact]
        public void Given_C_Should_Return_C_Diamond()
        {
            var input = 'C';

            var result = DiamondPrinter.Print(input);

            Assert.Equal("  A\n B B\nC   C\n B B\n  A", result);
        }
    }

    public class Given_E_Should_Return_E_Diamond_Test
    {
        [Fact]
        public void Given_E_Should_Return_E_Diamond()
        {
            var input = 'E';

            var result = DiamondPrinter.Print(input);

            Assert.Equal("    A\n   B B\n  C   C\n D     D\nE       E\n D     D\n  C   C\n   B B\n    A", result);
        }
    }
}