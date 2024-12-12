using Tyuiu.MolchankinaAP.Sprint6.Task1.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint6.Task1.V15.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;
            int len = stopVal - startVal + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = 59.49;
            WaitArray[1] = 38.47;
            WaitArray[2] = -2.81;
            WaitArray[3] = -19.67;
            WaitArray[4] = -8.42;
            WaitArray[5] = 0.57;
            WaitArray[6] = -6.30;
            WaitArray[7] = -20.14;
            WaitArray[8] = -3.51;
            WaitArray[9] = 38.13;
            WaitArray[10] = 59.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startVal, stopVal);
            CollectionAssert.AreEqual(WaitArray, res);
        }
    }
}