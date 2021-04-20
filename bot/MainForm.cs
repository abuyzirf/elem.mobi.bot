/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.04.2021
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bot
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			webBrowser1.Url=new Uri("http://elem.mobi/login");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
	
		}
		void BtStartClick(object sender, EventArgs e)
		{
			Login("as","a");
			
		}
		
		void Login(String name, String password)
		{
			HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elem in elems)
            {
                String nameStr = elem.GetAttribute("name");
                if (nameStr == "plogin")
                	{
                      elem.SetAttribute(nameStr, "Vi Ex");
                       elem.InnerText = "Vi Ex";
 
            	}
           		 if (nameStr == "ppass")
           			 {
              		  elem.SetAttribute(nameStr, "Ecs848pa");
               			 elem.InnerText = "Ecs848pa";
 
           		 }
            }
            elems = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elem in elems)
            {
	
			    String nameStr = elem.GetAttribute("value");
			    if (nameStr == "Вход")
			    {
				    elem.InvokeMember("Click");
			    }
            }
		}
		
		
		void BtStopClick(object sender, EventArgs e)
		{
			textBox1.Text="";
			HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName("a");
			foreach (HtmlElement elem in elems)
			{
//				string link = elem.GetAttribute("href");
//				textBox1.Text+= link+Environment.NewLine;
				//textBox1.Text+= elem.InnerText+Environment.NewLine;
				if (elem.InnerText == "Записаться"){
					elem.InvokeMember("Click");
				}
			}
			
			
			
        }
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
            
		}
	}


