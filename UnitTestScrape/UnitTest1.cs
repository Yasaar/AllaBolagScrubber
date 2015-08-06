using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using ScreenScraperLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScreenScraperLib
{
    [TestClass]
    public class UnitTest1
    {
        string testId = "5565995239";
        [TestMethod]
        public void TestAllaBolagToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeAllaBolag();
           string testResult = "Från Allabolag.se Mattias Asplund Aktiebolag";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }

        [TestMethod]
        public void TestHittaToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeHitta();
           string testResult = "Från Hitta.se Asplund Software";
            Assert.AreEqual(testResult, testVar.findNameByOrgID(testId));

        }

        //[TestMethod]
        //public void TestEniroToSeeIfPredetermendIdReturnsCorrectName()
        //{
        //    var testVar = new ClassScrapeEniro();
        //    string testResult = "Från Eniro.se Mattias Asplund AB";
        //    Assert.AreEqual(testResult,testVar.findNameByOrgID(testId).TrimEnd());
        //}
        [TestMethod]
        public void TestUpplysningToSeeIfPredetermendIdReturnsCorrectName()
        {
            var testVar = new ClassScrapeUpplysning();
            string expected = "Från Upplysning.se Mattias Asplund Aktiebolag";
            string actual = testVar.findNameByOrgID(testId);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestTimeEllapsedForAllSitesSeries()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            TestUpplysningToSeeIfPredetermendIdReturnsCorrectName();

            //timer.Start();
            //TestEniroToSeeIfPredetermendIdReturnsCorrectName();
            //timer.Stop();

            TestHittaToSeeIfPredetermendIdReturnsCorrectName();

            TestAllaBolagToSeeIfPredetermendIdReturnsCorrectName();
            timer.Stop();
            Console.WriteLine(timer.Elapsed.ToString());
        }

        /// <summary>
        /// Async Part
        /// </summary>

        [TestMethod]
        async Task TestAllaBolagToSeeIfPredetermendIdReturnsCorrectNameToAsync()
        {
            var testVar = new ClassScrapeAllaBolag();
            string testResult = "Från Allabolag.se Mattias Asplund Aktiebolag";
            Assert.AreEqual(testResult, (await testVar.findNameByOrgIDAsync(testId)));

        }

        [TestMethod]
        async Task TestHittaToSeeIfPredetermendIdReturnsCorrectNameToAsync()
        {
            var testVar = new ClassScrapeHitta();
            string testResult = "Från Hitta.se Asplund Software";
            Assert.AreEqual(testResult, (await testVar.findNameByOrgIDAsync(testId)));

        }

        [TestMethod]
        async Task TestEniroToSeeIfPredetermendIdReturnsCorrectNameToAsync()
        {
            var testVar = new ClassScrapeEniro();
            string testResult = "Från Eniro.se Mattias Asplund AB";
            Assert.AreEqual(testResult, (await testVar.findNameByOrgIDAsync(testId)).TrimEnd());
        }
        [TestMethod]
        async Task TestUpplysningToSeeIfPredetermendIdReturnsCorrectNameToAsync()
        {
            var testVar = new ClassScrapeUpplysning();
            string expected = "Från Upplysning.se Mattias Asplund Aktiebolag";
            var actual = (await testVar.findNameByOrgIDAsync(testId));
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestTimeEllapsedForAllSitesParallel()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            TestUpplysningToSeeIfPredetermendIdReturnsCorrectNameToAsync();

            //TestEniroToSeeIfPredetermendIdReturnsCorrectNameToAsync();

            TestHittaToSeeIfPredetermendIdReturnsCorrectNameToAsync();

            TestAllaBolagToSeeIfPredetermendIdReturnsCorrectNameToAsync();
            timer.Stop();
            Console.WriteLine(timer.Elapsed.ToString());
        }
    }
}
