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
using System.Threading;
using System.Diagnostics;

namespace bot
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Random rnd;
		
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
			
			rnd = new Random();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
	
		}
		void BtStartClick(object sender, EventArgs e)
		{
			Login("Vi Ex","Ecs848pa");
			textBox1.Text = "Логин"+Environment.NewLine;
			
		}
		
		void Login(String userName, String userPassword)
		{
			// Ищем поля для ввода логинопароля, если нашли - заполняем
	
			HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elem in elems)
            {
                String nameStr = elem.GetAttribute("name");
                if (nameStr == "plogin")
                	{
      //                elem.SetAttribute(nameStr, "");
                       elem.InnerText = userName;
 
            	}
           		 if (nameStr == "ppass")
           			 {
              		  //elem.SetAttribute(nameStr, "Ecs848pa");
               			 elem.InnerText = userPassword;
 
           		 }
            }
            // Ищем кнопку Вход. Нашли? Нажали!
            
            elems = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elem in elems)
            {
			    String nameStr = elem.GetAttribute("value");
			    if (nameStr == "Вход")
			    {
				    elem.InvokeMember("Click");
				    break;
			    }
            }
		}
		
		void FindAndClick(String TagName, String InText)
		{
			HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName(TagName);
			foreach (HtmlElement elem in elems)
			{			
				if (elem.InnerText.Contains(InText)) {
					elem.InvokeMember("Click");
					break;
				}
			}
		}
		
		private void Delay (int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }
		
		void BtStopClick(object sender, EventArgs e)
		{
			FindAndClick("a", "Записаться");
			textBox1.Text = "==="+Environment.NewLine;
			Delay(rnd.Next(1500, 1900));
			
			Boolean reload;
			do
			{
				HtmlElementCollection elems = webBrowser1.Document.All;//.GetElementsByTagName("div");
				reload = true;
				textBox1.Text +="==="+Environment.NewLine;
				foreach (HtmlElement elem in  elems)
				{					
					textBox1.Text += elem.InnerText +Environment.NewLine;
					if (elem.InnerText!=null)
					{
						if (elem.InnerText.Contains("Бой начнется")) 
						{
							reload = false;
							FindAndClick("a","Обновить");
							break;
						}
					}
				
				}
				Delay(rnd.Next(300, 500));
			}
			while (reload);	//
			
			
			
			
			
        }
		           
	}
}


