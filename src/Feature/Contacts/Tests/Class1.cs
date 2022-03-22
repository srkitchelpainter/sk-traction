using Xunit;
using Sitecore.Feature.Contacts.Controllers;

//Unit Testing Competency: + You understand the purpose of unit testing.

namespace Sitecore.Feature.Contacts.Tests
{
    public class Class1
    {
        //Sample Xunit test
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}

//Run tests with the xUnit.net console runner
//PS C:\Users\srkit\source\repos\sitecore-traction-repo\LearnSc93Proj> packages\xunit.runner.console.2.4.1\tools\net472\xunit.console C:\Users\srkit\source\repos\sitecore-traction-repo\LearnSc93Proj\src\Feature\Contacts\Tests\bin\Debug\Sitecore.Feature.Contacts.Tests.dll
//xUnit.net Console Runner v2.4.1 (64-bit Desktop .NET 4.7.2, runtime: 4.0.30319.42000)
//  Discovering: Sitecore.Feature.Contacts.Tests
//  Discovered:  Sitecore.Feature.Contacts.Tests
//  Starting:    Sitecore.Feature.Contacts.Tests
//    Sitecore.Feature.Contacts.Tests.Class1.FailingTest [FAIL]
//      Assert.Equal() Failure
//      Expected: 5
//      Actual:   4
//      Stack Trace:
//        src\Feature\Contacts\Tests\Class1.cs(20,0): at Sitecore.Feature.Contacts.Tests.Class1.FailingTest()
//  Finished:    Sitecore.Feature.Contacts.Tests
//=== TEST EXECUTION SUMMARY ===
//   Sitecore.Feature.Contacts.Tests Total: 2, Errors: 0, Failed: 1, Skipped: 0, Time: 0.177s
