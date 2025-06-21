namespace Tests
{
    public class UnitTest1
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