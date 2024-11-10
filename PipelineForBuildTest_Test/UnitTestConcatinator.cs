using PipelineForBuildTest;
namespace PipelineForBuildTest_Test
{
    [TestClass]
    public class UnitTestConcatinator
    {
        private Concatinator _Concatinator { get; set; }

        public UnitTestConcatinator()
        {
            _Concatinator = new Concatinator();
        }
        [TestMethod]
        public void ShouldReturnIntResponse()
        {
            var resp = _Concatinator.AddorConcat(12, 12);
            Assert.AreEqual(24, resp);
        }

        [TestMethod]
        public void ShouldReturnStringResponse()
        {
            var resp = _Concatinator.AddorConcat("12", "12");
            Assert.AreEqual("1212", resp);
        }

        
    }
}