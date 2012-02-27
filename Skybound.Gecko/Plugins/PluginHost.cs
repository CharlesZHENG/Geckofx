﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Plugins
{
	public static class PluginHost
	{
		private static ServiceWrapper<nsIPluginHost> _pluginHost;

		static PluginHost()
		{
			_pluginHost = new ServiceWrapper<nsIPluginHost>(Contracts.PluginHost);
		}

		public static void ReloadPlugins(bool reloadPages)
		{
			
			_pluginHost.Instance.ReloadPlugins( reloadPages );
		}

		public static PluginTag[] GetPluginTags()
		{
			uint count = 10;
			nsIPluginTag[] tags = new nsIPluginTag[10];
			//var_pluginHost.GetPluginTags();
			return null;
		}

		public static bool SiteHasData(PluginTag tag, string domain)
		{
			return nsString.Pass(_pluginHost.Instance.SiteHasData, tag._pluginTag, domain);
		}

		public static void ClearSiteData(PluginTag tag, string domain, ulong flags, long maxAge)
		{
			nsString.Set(x => _pluginHost.Instance.ClearSiteData(tag._pluginTag, x, flags, maxAge), domain);
		}
	}
}
