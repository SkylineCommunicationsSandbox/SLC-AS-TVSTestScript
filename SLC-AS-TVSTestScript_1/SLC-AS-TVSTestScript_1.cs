namespace SLC_AS_TVSTestScript_1
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;
	using Empower.Library.Room0;
	using Skyline.DataMiner.Automation;

    /// <summary>
    /// Represents a DataMiner Automation script.
    /// </summary>
	public class Script
	{
		/// <summary>
		/// The script entry point.
		/// </summary>
		/// <param name = "engine" > Link with SLAutomation process.</param>
		public void Run(IEngine engine)
		{
			engine.GenerateInformation("Hello World 123");
			var order = OrderFactory.CreateOrder("JansChange Bacon Burger");
			order.Dispatch("Thomas Verschuere");
        }
	}
}