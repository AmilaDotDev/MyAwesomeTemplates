using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EFCoreConfigurationItemTemplate
{
	public class CustomWizard : IWizard
	{
		public void BeforeOpeningFile(global::EnvDTE.ProjectItem projectItem)
		{
			throw new NotImplementedException();
		}

		public void ProjectFinishedGenerating(global::EnvDTE.Project project)
		{
			throw new NotImplementedException();
		}

		public void ProjectItemFinishedGenerating(global::EnvDTE.ProjectItem projectItem)
		{
			throw new NotImplementedException();
		}

		public void RunFinished()
		{
			throw new NotImplementedException();
		}

		public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
		{
			var safeitemnamekey = "$safeitemname$";
			var entitynamekey = "$entityname$";
			var safeitemname = replacementsDictionary[safeitemnamekey];
			
			if (!string.IsNullOrEmpty(safeitemname))
			{
				//where item name doesn't end with Configuration, append it
				if (!safeitemname.ToLower().EndsWith("configuration"))
				{
					//where item name doesn't end with Configuration, I assume the item name is the entity name
					replacementsDictionary[entitynamekey] = safeitemname;

					safeitemname += "Configuration";

				}
				else
				{
					//just in case if someone has entered configuration (character 'c' in lower case)
					safeitemname = Regex.Replace(safeitemname, "configuration", "Configuration", RegexOptions.IgnoreCase);

					//where item name ends with Configuration, replace it with an empty string to get the entity name
					replacementsDictionary[entitynamekey] = Regex.Replace(safeitemname, "configuration", string.Empty, RegexOptions.IgnoreCase);
				}

				replacementsDictionary[safeitemnamekey] = safeitemname;
			}
		}

		public bool ShouldAddProjectItem(string filePath)
		{
			throw new NotImplementedException();
		}
	}
}
