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


    public class Failing_Test_Given_B_Should_Return_B_Diamond_Test
    {
        [Fact]
        public void Given_B_Should_Return_B_Diamond()
        {
            var input = 'B';

            var result = DiamondPrinter.Print(input);

            Assert.Equal(" A \nB B\n A ", result);

        //             ↓ (pos 2)
        //Expected: " A \nB B\n A "
        //Actual: " A\nB B\n A"
        //            ↑ (pos 2)

            //In TDD there's 2 approaches, Red-Green-Refacor and Test-First Approach
            //This should be a RedGreenRefactor cycle approach where you write the
            //failing test and implement the simplest solution to make the test pass, then refactor the code
            //while ensuring the test still passes, but for my solution I chose to not use trailling spaces
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