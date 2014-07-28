using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using wp8_unit_test_example.ViewModel;

namespace wp8_unit_test_example_tests.UnitTests
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestMethod]
        public void MyPropertyTest()
        {
            string expected = "expected";
            var vm = new MainViewModel();
            
            vm.MyProperty = expected;
            Assert.AreEqual(expected, vm.MyProperty);    
        }
    }
}
