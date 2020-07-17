using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length <= 1)
			{
				return;
			}
			this.textBox1.Text = commandLineArgs[1];
		}
		private void label1_Click(object sender, EventArgs e)
		{
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XDelta Patch (*.xdelta)|*.xdelta|All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				text = openFileDialog.FileName;
			}
			this.textBox1.Text = text;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				text = openFileDialog.FileName;
			}
			this.textBox2.Text = text;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				text = saveFileDialog.FileName;
			}
			this.textBox3.Text = text;
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
			{
				MessageBox.Show("Please make sure all file targets are set");
				return;
			}
			string arguments = string.Concat(new string[]
			{
				string.Empty,
				" -d -f -s \"",
				this.textBox2.Text,
				"\" \"",
				this.textBox1.Text,
				"\" \"",
				this.textBox3.Text,
				"\""
			});
			string empty = string.Empty;
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "xdelta.exe";
			process.StartInfo.Arguments = arguments;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			string text = process.StandardError.ReadToEnd();
			if (text == "")
			{
				MessageBox.Show("File patched successfully");
			}
			else
			{
				MessageBox.Show(text);
			}
			process.WaitForExit();
		}
		private void button8_Click(object sender, EventArgs e)
		{
			string empty = string.Empty;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
			}
		}
		private void button7_Click(object sender, EventArgs e)
		{
			string empty = string.Empty;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
			}
		}
		private void button6_Click(object sender, EventArgs e)
		{
			string empty = string.Empty;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "xdelta patch (*.xdelta)|*.xdelta|All files (*.*)|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Please make sure all file targets are set");
			string empty = string.Empty;
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "xdelta.exe";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			string text = process.StandardError.ReadToEnd();
			if (text == "")
			{
				MessageBox.Show("Patch created successfully");
			}
			else
			{
				MessageBox.Show(text);
			}
			process.WaitForExit();
		}
    }
}
