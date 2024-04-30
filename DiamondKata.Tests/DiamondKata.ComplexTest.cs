namespace DiamondKata.Tests
{
    public class DiamondKataComplexTest
    {
        //I do have an idea on how to create a generic unitTest for the whole alphabet
        //but it would require a implemented virtual method for DiamondKata.Print, and an overloaded one that should
        //in theory be orewritten, but this kind of a scenario would work better for a different type of data comparissons

        //something like:
        //DiamondTestDataAttribute : DataAttribute class that would get the original output from the virtual class
        //and return ad IEnumerable with the diamonds
        //and in the bellow method change expectedDiamonds with the result from above

        private static readonly Dictionary<char, string> ExpectedDiamonds = new Dictionary<char, string>
        {
            {'A', "A"},
            {'B', " A\nB B\n A"},
            {'C', "  A\n B B\nC   C\n B B\n  A"},
            {'D', "   A\n  B B\n C   C\nD     D\n C   C\n  B B\n   A"},
            {'E', "    A\n   B B\n  C   C\n D     D\nE       E\n D     D\n  C   C\n   B B\n    A"}
            // Add the rest of expected diamond shapes
        };

        [Theory]
        [MemberData(nameof(GetAlphabetTestData))]
        public void Print_Returns_Correct_Diamond(char inputLetter)
        {
            var expected = ExpectedDiamonds[inputLetter];

            var result = DiamondPrinter.Print(inputLetter);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetAlphabetTestData()
        {
            const char startChar = 'A';
            const char endChar = 'E';//change endChar if added more tests

            for (char c = startChar; c <= endChar; c++)
            {
                yield return new object[] { c };
            }
        }
    }
}
