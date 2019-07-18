using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CustomizeAForm
{
	public partial class YellowForm : Form
	{
		private string settingFile = "setting.ini";
		private string currentPath;
		private Hashtable settings;

		const char DELIM = '=';

		private void writeSettingFile()
		{
			List<string> allTexts = new List<string>();
			// get all key:value pairs
			foreach (string key in settings.Keys)
			{
				allTexts.Add(key + "=" + settings[key]);
			}
			// overrite all setting into the config file setting.ini
			File.WriteAllLines(settingFile, allTexts.ToArray());
		}

		private void readSettingFile()
		{
			FileStream inFile = new FileStream(settingFile, FileMode.OpenOrCreate, FileAccess.Read);
			StreamReader reader = new StreamReader(inFile);

			string recordIn;
			recordIn = reader.ReadLine();
			while (recordIn != null)
			{
				// skip empty line
				if (recordIn.Trim() == "")
				{
					continue;
				}
				// split to get the key:value in each line for the form setting
				string[] pair = recordIn.Split(DELIM);
				settings.Add(pair[0], pair[1]);

				// read next line
				recordIn = reader.ReadLine();
			}
			reader.Close();
			inFile.Close();
		}


		private void loadFormSettingOptions()
		{
			// load all form options to the setting button
			// get all key:value pairs
			foreach (string key in settings.Keys)
			{
				switch (key)
				{
					case "title":
						tbTitle.Text = settings[key].ToString();
						break;
					case "size":
						this.tagRadioButton(groupBox1, settings[key].ToString());
						break;
					case "color":
						this.tagRadioButton(groupBox2, settings[key].ToString());
						break;
				}
			}
		}

		private void tagRadioButton(GroupBox gb1, string value)
		{
			// find the match radiobutton, then checked it
			for (int i = 0; i < gb1.Controls.Count; i++)
			{
				RadioButton rdb = (RadioButton)gb1.Controls[i];
				if (rdb.Text == value)
				{
					rdb.Checked = true;
					return;
				}
			}
		}

		private void refreshFormBySettings()
		{
			// read all settings and update to current form
			// get all key:value pairs
			foreach (string key in settings.Keys)
			{
				switch (key)
				{
					case "title":
						this.Text = settings[key].ToString();
						break;
					case "size":
						this.Font = this.getFont(settings[key].ToString());
						break;
					case "color":
						this.BackColor = this.getBackgroundColor(settings[key].ToString());
						break;
				}
			}
			this.Update();
		}

		private Color getBackgroundColor(string colorName)
		{
			switch (colorName)
			{
				case "Blue":
					return Color.Blue;
				case "Red":
					return Color.Red;
				case "Yellow":
					return Color.Yellow;
				default:
					return Color.Black;
			}
		}

		private Font getFont(string sizeName)
		{
			switch (sizeName)
			{
				case "Small":
					return new Font(FontFamily.GenericSansSerif, 10);
				case "Large":
					return new Font(FontFamily.GenericSansSerif, 18);
				default:
					return new Font(FontFamily.GenericSansSerif, 14);
			}

		}

		public YellowForm()
		{
			InitializeComponent();
		}

		private void YellowForm_Load(object sender, EventArgs e)
		{
			// initial hashtable and the setting file's full path
			// Create and return new Hashtable.
			settings = new Hashtable();
			currentPath = Directory.GetCurrentDirectory();
			settingFile = Path.Combine(currentPath, settingFile);

			//read key:value pairs from setting file to the hashtable
			this.readSettingFile();
			
			// update the setting options 
			this.loadFormSettingOptions();

			// update the form style by the setting.
			this.refreshFormBySettings();
			//done the form load
		}

		private void YellowForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Do you want to save changes to your setting file?",
								"My Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.writeSettingFile();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.writeSettingFile();
			btnSave.Enabled = false;
		}

		private void tbTitle_TextChanged(object sender, EventArgs e)
		{			
			settings["title"] = tbTitle.Text;
			this.refreshFormBySettings();
		}

		private void colors_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbColor = sender as RadioButton;
			if (rbColor.Checked == true)
			{ //limited only checked button do function
				settings["color"] = rbColor.Text;
			}
			this.refreshFormBySettings();
		}

		private void sizes_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbSize = sender as RadioButton;
			if (rbSize.Checked == true)
			{ //limited only checked button do function
				settings["size"] = rbSize.Text;
			}
			this.refreshFormBySettings();
		}


	}
}
