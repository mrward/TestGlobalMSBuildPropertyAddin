using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace TestGlobalMSBuildPropertyAddin
{
	public class RunBuildHandler : CommandHandler
	{
		protected override void Update (CommandInfo info)
		{
			var project = IdeApp.ProjectOperations.CurrentSelectedProject as DotNetProject;
			if (project == null) {
				info.Enabled = false;
			}
		}

		protected override void Run ()
		{
			var project = IdeApp.ProjectOperations.CurrentSelectedProject as DotNetProject;
			if (project == null)
				return;

			var context = new ProjectOperationContext ();
			context.GlobalProperties.SetValue ("PackOnBuild", "true");
			IdeApp.ProjectOperations.Build (project, operationContext: context);
		}
	}
}
