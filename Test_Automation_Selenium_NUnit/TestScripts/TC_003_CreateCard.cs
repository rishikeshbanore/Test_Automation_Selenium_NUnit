using System;
using NUnit.Framework;


namespace Test_Automation_Selenium_NUnit
{
    [TestFixture]
    public class TC_002_Add_Card : BaseClass
    {
        [SetUp]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
        }

        [Category("Regression")]
        [Test, Order(3)]
        public void TC003_Add_Card()
        {
            try
            {
                ReportLogger.Info("Starting test script for adding new card");
                //This is a call to a method for creating a card.
                objTrelloHome.createCard(JSONDataReader.Text_Task_Title);
                ReportLogger.Info("New Card is created Successfully");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC002_Add_Card Test Case.");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC002_Add_Card Test Case. ");
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
                //driver close and Report writing
                TestCleanup();
            }
        }
    }
}
