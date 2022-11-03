using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork_17
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<string> listOfLocality = new List<string>();
		public MainWindow()
		{
			InitializeComponent();
		}


		public static string GetValueTag(XmlTextReader reader, string Tag)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element && reader.Name == Tag)
				{
					reader.Read();
					return reader.Value;
				}
			}
			return null;
		}


		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (Locality == null)
			{
				MessageBox.Show("Виберіть місцевість", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
				return;
			}

			var w = new JobsGrid(Locality.Text);
			w.ShowDialog();
			w.Close();
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			XmlTextReader xml = new XmlTextReader("vacancy.xml");
			xml.WhitespaceHandling = WhitespaceHandling.None;
			
			while (xml.Read())
			{
				if (xml.NodeType == XmlNodeType.Element && xml.Name == "job" && xml.HasAttributes)
				{ 
					xml.MoveToAttribute(0);
					
					string region = GetValueTag(xml, "region");
					if (!region.Contains("М.Київ"))
					region = region.Substring(8, region.Length - 10).Split(',',' ')[0] + " " + region.Substring(8, region.Length - 10).Split(',', ' ')[1];
					else
					region = region.Substring(8, region.Length - 10).Split(',')[0];

					if (!listOfLocality.Contains(region))
						listOfLocality.Add(region);
				}
			}

			listOfLocality.Sort();
			Locality.ItemsSource = listOfLocality;
		}
	}
}
