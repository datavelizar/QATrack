using System;

namespace TestingFramework.Utilities.Atributes
{
	[System.AttributeUsage(System.AttributeTargets.Method)]
	public class TestCaseId : Attribute
	{
		private string Id;

		public TestCaseId(string id)
		{
			this.Id = id;
		}

		public TestCaseId(int id)
		{
			this.Id = id.ToString();
		}
	}
}
