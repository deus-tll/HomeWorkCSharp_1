using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace HomeWork_17
{
	/// <summary>
	/// Interaction logic for JobsGrid.xaml
	/// </summary>
	public partial class JobsGrid : Window
	{
		public JobsGrid(string locality)
		{
			InitializeComponent();

			_locality = locality;

			_jobs = new List<Job>();
		}

		private readonly List<Job> _jobs;

		private readonly string _locality;

		NumberFormatInfo numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = ",", };

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			XmlTextReader xml = new XmlTextReader("vacancy.xml");
			xml.WhitespaceHandling = WhitespaceHandling.None;
			
			while (xml.Read())
			{
				if (xml.NodeType == XmlNodeType.Element && xml.Name == "job" && xml.HasAttributes)
				{
					Job job = new Job();


					string _jobName;
					string _region;
					string _salary;


					xml.MoveToAttribute(0);


					job.ID = Convert.ToInt64(xml.Value);


					_jobName = MainWindow.GetValueTag(xml, "name");
					job.JobName = _jobName.Substring(8, _jobName.Length - 10);


					_region = MainWindow.GetValueTag(xml, "region");
					_region = _region.Substring(8, _region.Length - 10);


					_salary = MainWindow.GetValueTag(xml, "salary");
					job.Salary = Decimal.Parse((_salary.Substring(8, _salary.Length - 10).Split('₴')[0]), numberFormatInfo);


					if (_region.Contains(_locality))
						_jobs.Add(job);
				}
			}

			JobsList.ItemsSource = _jobs;
		}
	}
}
