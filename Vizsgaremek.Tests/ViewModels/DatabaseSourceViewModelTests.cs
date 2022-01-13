namespace VizsgaremekProjekt.ViewModels.Tests
{
    [TestClass()]
    public class DatabaseSourceViewModelTests
    { 
        [TestMethod()]
        public void DatabaseSourceViewModelTest()
        {
            DatabaseSourceViewModelTest databaseSourceViewModel = new DatabaseSourceViewModel();
            databaseSourceViewModel.SelectedDatabaseSource = "localhost";
            DbSource expectedDbSource = DbSource.LOCALHOST;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'localhost', de nem váltott át DbSource.LOCALHOST-ra");
        }

    }
