using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReplacer
{
	public interface Configurable
	{
		Configuration getConfiguration();
		void setConfiguration(Configuration config);
	}

	public struct Option
	{
		public bool createNewFiles;
		public bool createByGroup;
		public bool createFileManuallyOnCreate;
		public bool matchCase;
	}

	public struct Configuration
	{
		public Option options;
		public VisualFile[] files;
		public WordPair[] pairs;
	}
}
