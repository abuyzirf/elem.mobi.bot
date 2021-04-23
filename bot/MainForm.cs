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
		
		Boolean FindAndClick(String TagName, String InText)
		{
			HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName(TagName);
			foreach (HtmlElement elem in elems)
			{			
				if (elem.InnerText != null)
				if (elem.InnerText.Contains(InText)) {
					elem.InvokeMember("Click");
					return true;
				}
			}
			return false;
		}
		
		private void Delay (int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value);
                Application.DoEvents();
        }
		
		void BtStopClick(object sender, EventArgs e)
		{
			
			HtmlElementCollection elems;
			
			while ( !FindAndClick("a", "Записаться") )
			{Delay(250);}
			Delay(250);
			
			textBox1.Text = "==="+Environment.NewLine;
			Delay(1950);
			textBox1.Text += "===delay"+Environment.NewLine;
			
			while (webBrowser1.IsBusy){ Application.DoEvents();}
			
			textBox1.Text += "==="+webBrowser1.IsBusy+Environment.NewLine;
			Boolean reload;
			do
			{
				while (webBrowser1.IsBusy){ Application.DoEvents();}
				textBox1.Text = "";
				 elems = webBrowser1.Document.GetElementsByTagName("div");
				reload = false;
				foreach (HtmlElement elem in  elems)
				{					
					textBox1.Text += elem.InnerText;
				}
				if (textBox1.Text.Contains("Бой")) 
				{
					reload = true;
					textBox1.Text += "+++++++++ нашел";
					
					while ( !FindAndClick("a", "Обновить") )
					{Delay(250);}
					
					
				}
				
				
				
				Delay(rnd.Next(800, 1500));
				
				textBox1.Text += "+++++++++ delay";
				
			}
			while (reload);	//
			
			
			textBox1.Text = "Бой начался";
			
			while (webBrowser1.IsBusy){ Application.DoEvents();}
			
			textBox1.Text = "Бой начался";
				 elems = webBrowser1.Document.GetElementsByTagName("div");
				
				foreach (HtmlElement elem in  elems)
				{					
					textBox1.Text += elem.InnerText;
					if (elem.GetAttribute("id")!="")
					{
					   textBox1.Text += elem.GetAttribute("class") + "++++++++";
					}
				}
			
			
						
			
        }
		void BtAnalizeClick(object sender, EventArgs e)
		{
			HtmlElementCollection elems = webBrowser1.Document.All;
			textBox1.Text += Environment.NewLine+ " Attribute " + tbAtrib.Text+Environment.NewLine;
			foreach (HtmlElement elem in  elems)
				{					
					
					if (elem.GetAttribute(tbAtrib.Text)!="")
					{
					   textBox1.Text += elem.GetAttribute(tbAtrib.Text) + "   -  ";
					}
				}
			textBox1.Text += Environment.NewLine+ " id " + tbAtrib.Text+Environment.NewLine;
			
			 elems = webBrowser1.Document.GetElementsByTagName(tbAtrib.Text);
			foreach (HtmlElement elem in  elems)
				{					
					
					
					{
					   textBox1.Text += elem.Id + "   -  ";
					}
				}
			 elems = webBrowser1.Document.GetElementsByTagName(tbAtrib.Text);
			foreach (HtmlElement elem in  elems)
				{					
					
					
					{
					textBox1.Text += elem.InnerText + "   -==  ";
				}
			}
	
		}
		           
	}
}


