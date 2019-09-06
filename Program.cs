using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Nunit3DiscoveryFailure
{
	public class Program
	{
		[TestCaseSource(nameof(AllTypes))]
		public void Test(Type type) => Assert.That(type, Is.Not.Null);


		public static IEnumerable<Type> AllTypes
		{
			get
			{
				Initialization.EnsureInitialized();

				yield return typeof(Program);
			}
		}
	}
}
