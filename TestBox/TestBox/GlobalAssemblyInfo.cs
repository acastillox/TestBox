using System.Reflection;
using static ThisAssembly;

// AssemblyVersion = full version info, since it's used to determine agents versions
[assembly: AssemblyVersion(TestBox.ThisAssembly.Version)]
// FileVersion = release-like simple version (i.e. 3.11.2 for cycle 5, SR2).
[assembly: AssemblyFileVersion(TestBox.ThisAssembly.SimpleVersion)]
// InformationalVersion = full version + branch + commit sha.
[assembly: AssemblyInformationalVersion(TestBox.ThisAssembly.InformationalVersion)]

namespace TestBox
{
	partial class ThisAssembly
	{
		/// <summary>
		/// Full version, including commits since base version file, like 4.0.1.598
		/// </summary>
		public const string Version = SimpleVersion + "." + Git.Commits;

		/// <summary>
		/// Simple release-like version number, like 4.0.1 for a cycle 5, SR1 build.
		/// </summary>
		public const string SimpleVersion = Git.BaseVersion.Major + "." + Git.BaseVersion.Minor + "." + Git.BaseVersion.Patch;

		/// <summary>
		/// Full version, plus branch and commit short sha, like 4.0.1.598-cycle6+39cf84e
		/// </summary>
		public const string InformationalVersion = Version + "-" + Git.Branch + "+" + Git.Commit;
	}
}