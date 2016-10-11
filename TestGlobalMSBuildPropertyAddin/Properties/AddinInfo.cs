using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"TestGlobalMSBuildProperty", 
	Namespace = "TestGlobalMSBuildProperty",
	Version = "1.0"
)]

[assembly:AddinName ("TestGlobalMSBuildProperty")]
[assembly:AddinCategory ("TestGlobalMSBuildProperty")]
[assembly:AddinDescription ("TestGlobalMSBuildProperty")]
[assembly:AddinAuthor ("Matt Ward")]

//[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
//[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]