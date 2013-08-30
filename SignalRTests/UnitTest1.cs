using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignalR.Infrastructure;



namespace SignalRTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.IsNotNull(MongoDataProvider.Get("MessageBoard"));
    }

    [TestMethod]
    public void NotNullCollections()
    {
      var provider = MongoDataProvider.Get("MessageBoard");
      var test = provider.GetCollection("MessageBoard");

    }
  }
}
