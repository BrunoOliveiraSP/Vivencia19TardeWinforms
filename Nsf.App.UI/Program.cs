﻿using System;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new UI.frmInicial());
        }
	}
}