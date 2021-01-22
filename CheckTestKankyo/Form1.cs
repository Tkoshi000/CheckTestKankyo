using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckTestKankyo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Openbutton_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(FilePathtextBox.Text.Trim('"'));
			}
			catch (Exception error)
			{

				MessageBox.Show(error.ToString());
			}
		}
	}
}
