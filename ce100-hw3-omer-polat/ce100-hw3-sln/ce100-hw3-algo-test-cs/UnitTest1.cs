using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw3_sln;

namespace ce100_hw3_algo_test_cs
{

    /****************************
*****************************
* @file ce100_hw3_algo_test_cs *
* @author Ömer POLAT *
* @date 10 April 2022 * 
*
* @brief <b> hw-3 Unit test </b> *
*
* 
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*****************************
*****************************/



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LongestCommonSubsquence_TestMethod1()
        {
            string s1 = "FMSMCŞSİDMÜQPWELQĞPFMCSAĞPDÖALSFMŞ";
            string s2 = "MCŞSLMDĞAKEĞQŞLMASDFKSDİŞFMQMWĞEŞF";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "MCŞSMEĞMADSFMŞ";
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void LongestCommonSubsquence_TestMethod2()
        {
            string s1 = "RWEIRPWERIQĞPWEQĞPOQÜOR";
            string s2 = "WEROĞLWEFWEÜFÖÜWLQĞÜWLÖ";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "WERWEWEQĞÜ";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void LongestCommonSubsquence_TestMethod3()
        {
            string s1 = "FSNDLFKNSDFDCMSĞFLMASZ";
            string s2 = "MCŞDSMDASŞFNCAŞSLDMŞLA";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "DSDFCSLMA";
            Assert.AreEqual(result, expected);
        }





        [TestMethod]
        public void MatrixChainOrder_TestMethod1()
        {
            int[] arr = { 1, 2, 3, 4 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 18);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod2()
        {
            int[] arr = new int[] { 1,2,3,4,3 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod3()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 30 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 30000);
        }





       
    }
}
