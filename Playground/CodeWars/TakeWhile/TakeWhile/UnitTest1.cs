namespace TakeWhile
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new int[] { 2, 4, 6, 8, 1, 2, 5, 4, 3, 2 };
            Func<int, bool> isEven = (value) => value % 2 == 0;

            var result = DropWhile(test, isEven);
            Assert.IsTrue(result.Length == 6);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(5, result[2]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Func<int, bool> isEven = (value) => value % 2 == 0;
            var expected = new int[] { };
            var actual = DropWhile(new int[] { 2, 4, 10, 100, 64, 78, 92 }, isEven);

            Assert.AreEqual(string.Join(", ", expected), string.Join(", ", actual));
        }

        public static int[] DropWhile(int[] input, Func<int, bool> isEven)
        {
            //loop through input arr
            //count how many nums we go through to get to an odd
            //set a result array to the input length - the nums we counted
            //populate result array with the remaining nums
            int start;
            for (start = 0; start < input.Length; start++)
            {
                if (!isEven(input[start])) { break; }            
            }
            
            return input[start..];
        }
    }

}