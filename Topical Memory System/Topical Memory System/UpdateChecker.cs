﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public class UpdateChecker
	{
		public static void CheckForUpdate()
		{
			XmlTextReader reader;
			try
			{
				// provide the XmlTextReader with the URL of our xml document
				string xmlURL = "http://code.google.com/feeds/p/topicalmemorysystem/downloads/basic.xml";
				reader = new XmlTextReader(xmlURL);
				reader.MoveToContent();
				bool foundEntry = false;
				bool foundTitle = false;
				bool foundLink = false;
				string title = "";
				string downloadUrl = "";		//brings to page about download
				string directDownloadUrl = "";	//links directly to executable
				if ((reader.NodeType == XmlNodeType.Element))
				{
					while (reader.Read())
					{	//navigate to the correct node
						if (reader.NodeType == XmlNodeType.Element)
						{
							if (reader.Name == "entry")
							{
								foundEntry = true;
							}
							else if (reader.Name == "title")
							{
								if (foundEntry)
								{
									foundTitle = true;
								}
							}
							else if (reader.Name == "link")
							{
								if (foundEntry && !foundLink)
								{
									foundLink = true;
									downloadUrl = reader.GetAttribute("href");
								}
							}
						}
						else if (reader.NodeType == XmlNodeType.Text)
						{
							if (foundTitle)
							{
								if (reader.Value != null && reader.Value.Contains("TMS Assistant"))
								{
									title = reader.Value;
									break;
								}
								else
								{	//different type of file (like custom verses)
									foundEntry = false;
									foundTitle = false;
									foundLink = false;
								}
							}
						}
					}
				}
				directDownloadUrl = GetDirectDownloadUrl(title);
				if (title != null && title.Trim() != "" && title.Contains("TMS Assistant"))
				{
					//title is in format: "TMS Assistant x.x.x.msi (size)"
					title = title.Trim().Replace("TMS Assistant ", "");
					string[] nums = title.Split('.');
					if (nums.Length >= 3)
					{
						title = nums[0] + "." + nums[1] + "." + nums[2];
					}
					else
					{
						throw new Exception();
					}
					UpdateNeeded(Constants.Version, title, downloadUrl, directDownloadUrl);
				}
				else
				{
					throw new Exception();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred while checking for updates.  Please check your internet connection or try again later.");
			}
		}

		private static string GetDirectDownloadUrl(string title)
		{
			string result = "http://topicalmemorysystem.googlecode.com/files/";
			int index = title.IndexOf("(");
			result += title.Substring(0, index).Trim();
			return result;
		}

		private static void UpdateNeeded(string currentVersion, string latestVersion, string downloadUrl, string directDownloadUrl)
		{	//incoming format: x.x.x
			//currentVersion == application being used
			//latestVersion == latest version found via feed
			int update = -1;
			try
			{
				string[] cv = currentVersion.Split('.');
				string[] lv = latestVersion.Split('.');
				if (Convert.ToInt32(cv[0]) < Convert.ToInt32(lv[0]))
				{	//first number
					update = 1;
				}
				else if (Convert.ToInt32(cv[0]) == Convert.ToInt32(lv[0]))
				{
					if (Convert.ToInt32(cv[1]) < Convert.ToInt32(lv[1]))
					{	//second number
						update = 1;
					}
					else if (Convert.ToInt32(cv[1]) == Convert.ToInt32(lv[1]))
					{
						if (Convert.ToInt32(cv[2]) < Convert.ToInt32(lv[2]))
						{	//third number
							update = 1;
						}
						else if (Convert.ToInt32(cv[2]) == Convert.ToInt32(lv[2]))
						{
							update = 0;	//versions are the same
						}
					}
				}
				if (update == 0)
				{	//no update needed, we are using the same version as the feed
					UpdateForm uf = new UpdateForm(false, downloadUrl);
					uf.ShowDialog();
				}
				else if (update == 1)
				{	//need an update
					UpdateForm uf = new UpdateForm(true, downloadUrl);
					uf.ShowDialog();
				}
				else if (update == -1)
				{	//shouldn't ever get here, but putting it in anyway
					//this is hit when you are using a later version than the download feed shows
					UpdateForm uf = new UpdateForm(false, downloadUrl);
					uf.ShowDialog();
				}
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}
	}
}
