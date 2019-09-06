using Microsoft.Build.Locator;

namespace Nunit3DiscoveryFailure
{
	public sealed class Initialization
	{
		public static void EnsureInitialized()
		{
			if (MSBuildLocator.IsRegistered)
			{
				return;
			}
		}
	}
}
