﻿

using Alfred.Model.Core;

namespace Alfred.Client.Plugins
{
	public class Meteo
	{        
		public void MeteoToday()
        {
            AlfredPluginsWebsocket.Client.SendCommand(new AlfredTask
            {
                Command = "Meteo_MeteoToday"
            });
		}
	}
}
