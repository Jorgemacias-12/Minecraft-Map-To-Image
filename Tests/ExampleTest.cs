namespace Tests
{
    public class ExampleTest
    {
        [Fact]
        public void ThisTestNeverFails()
        {
            var expected = true;
            var actual = true;

            Assert.Equal(expected, actual);
        }
    }
}