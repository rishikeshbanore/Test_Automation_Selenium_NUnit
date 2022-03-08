using System;
using NUnit.Framework;


namespace Test_Automation_Selenium_NUnit
{
    [TestFixture]
    public class TC_001_Create_Board : BaseClass
    {
        [SetUp]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);

            //This is a call to a method for deleting test data created by test script during previous test run
           // objGeneric.deleteBoard();
        }

        [Category("Regression")]
        [Test, Order(1)]
        public void TC001_Create_Board()
        {
            try
            {
                //This is a call to a method for creating board.
                ReportLogger.Info("Starting test script for creating new board");
                objTrelloHome.createBoard(JSONDataReader.Text_Board_Title);
                ReportLogger.Info("New Board is created Successfully");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC_001_Create_Board Test Case. Board is NOT Created");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC_001_Create_Board Test Case. ");
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
