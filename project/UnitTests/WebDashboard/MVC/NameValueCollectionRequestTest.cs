using NUnit.Framework;
using ThoughtWorks.CruiseControl.WebDashboard.MVC;

namespace ThoughtWorks.CruiseControl.UnitTests.WebDashboard.MVC
{
	[TestFixture]
	public class NameValueCollectionRequestTest
	{
		[Test]
		public void ShouldReturnFileNameWithoutExtension()
		{
			NameValueCollectionRequest request = new NameValueCollectionRequest(null, "/ccnet/file1.aspx");
			Assert.AreEqual("file1", request.FileNameWithoutExtension);

			request = new NameValueCollectionRequest(null, "/file2.aspx");
			Assert.AreEqual("file2", request.FileNameWithoutExtension);

			request = new NameValueCollectionRequest(null, "/ccnet/file3");
			Assert.AreEqual("file3", request.FileNameWithoutExtension);

			request = new NameValueCollectionRequest(null, "/file4");
			Assert.AreEqual("file4", request.FileNameWithoutExtension);

			request = new NameValueCollectionRequest(null, "/");
			Assert.AreEqual("", request.FileNameWithoutExtension);
		}
	}
}
