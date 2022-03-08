using System;
using NUnit.Framework;


namespace Test_Automation_Selenium_NUnit
{
    [TestFixture]
    public class TC_005_Move_Card : BaseClass
    {
        [SetUp]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
        }

        [Category("Regression")]
        [Test, Order(5)]
        public void TC005_Move_Card()
        {
            try
            {
                ReportLogger.Info("Starting test script for moving a card.");
                //This is a call to a method for cmoving a card.
                objTrelloHome.moveCard();
                ReportLogger.Info("Card is moved successfully to another list.");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC005_Move_Card Test Case.");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC005_Move_Card Test Case. ");
            }
        }

        [TearDown]
        public void CleanUp()
        {
            try
            {

            }
            finally
            {
                objGeneric.deleteBoard();
                //driver close and Report writing
                TestCleanup();
            }
        }
    }
}
