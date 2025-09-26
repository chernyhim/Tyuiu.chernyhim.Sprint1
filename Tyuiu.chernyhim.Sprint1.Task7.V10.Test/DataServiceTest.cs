using Tyuiu.chernyhim.Sprint1.Task7.V10.Lib;
namespace Tyuiu.chernyhim.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.727, res);
        }
    }
}
