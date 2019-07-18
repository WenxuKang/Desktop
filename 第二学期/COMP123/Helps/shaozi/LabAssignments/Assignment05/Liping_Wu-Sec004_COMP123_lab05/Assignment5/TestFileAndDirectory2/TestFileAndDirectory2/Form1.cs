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

namespace TestFileAndDirectory2
{
	public partial class TestFileandDirectoryForm : Form
	{
		private String[] fileList;
		private String rootPath="c:\\datafiles";

		public TestFileandDirectoryForm()
		{
			InitializeComponent();
		}

		private void TestFileandDirectoryForm_Load(object sender, EventArgs e)
		{
			rootPath = Directory.GetCurrentDirectory();			

			// inital the checkbox to display all files under a directory
			lblSelect.Text = "Select a file under directory: " + rootPath;
			lblCreateDetail.Text = "";			
			fileList = Directory.GetFiles(rootPath);
			// output sub files list under this directory
			checkedListBox1.Items.Clear();
			foreach (var filename in fileList)
			{
				checkedListBox1.Items.Add(new FileInfo(filename, rootPath));
			}			
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//select a file in the list checkbox, will display it's properties
			String fileDetails = "";

			foreach (FileInfo fileInfo in checkedListBox1.CheckedItems.OfType<FileInfo>().ToArray())
			{
				fileDetails += fileInfo.FileName + " was created " + File.GetCreationTime(fileInfo.FileName) + "\n";
			}
			lblCreateDetail.Text = fileDetails;
		}
	}

	public class FileInfo 
	{
		// property
		public String FileName { get; set; }
		public String ParentDirectory { get; set; }

		public FileInfo()
		{ }

		public FileInfo(String fileName, String parentDirectory)
		{
			this.FileName = fileName;
			this.ParentDirectory = parentDirectory;
		}

		//ToString to display instance data.
		public override string ToString()
		{
			return this.FileName;
		}
	}
}
