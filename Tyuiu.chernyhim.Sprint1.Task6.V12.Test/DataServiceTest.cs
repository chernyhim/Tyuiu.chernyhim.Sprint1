using Tyuiu.chernyhim.Sprint1.Task6.V12.Lib;

namespace Tyuiu.chernyhim.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValiExpression()
        {
            DataService ds = new DataService();
            string value = "abc def ghi ghi";
            var res = ds.CheckLastWordRepetiton(value);
            Assert.AreEqual(res,true);
        }
    }
}
