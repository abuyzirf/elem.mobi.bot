/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.04.2021
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bot
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox tbAtrib;
		private System.Windows.Forms.Button btAnalize;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.btStart = new System.Windows.Forms.Button();
			this.btStop = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbAtrib = new System.Windows.Forms.TextBox();
			this.btAnalize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(12, 12);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScrollBarsEnabled = false;
			this.webBrowser1.Size = new System.Drawing.Size(498, 898);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.WebBrowserShortcutsEnabled = false;
			// 
			// btStart
			// 
			this.btStart.Location = new System.Drawing.Point(557, 27);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(75, 23);
			this.btStart.TabIndex = 1;
			this.btStart.Text = "Старт";
			this.btStart.UseVisualStyleBackColor = true;
			this.btStart.Click += new System.EventHandler(this.BtStartClick);
			// 
			// btStop
			// 
			this.btStop.Location = new System.Drawing.Point(557, 68);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(75, 23);
			this.btStop.TabIndex = 2;
			this.btStop.Text = "Стоп";
			this.btStop.UseVisualStyleBackColor = true;
			this.btStop.Click += new System.EventHandler(this.BtStopClick);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(638, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(593, 898);
			this.textBox1.TabIndex = 3;
			// 
			// tbAtrib
			// 
			this.tbAtrib.Location = new System.Drawing.Point(532, 109);
			this.tbAtrib.Name = "tbAtrib";
			this.tbAtrib.Size = new System.Drawing.Size(100, 20);
			this.tbAtrib.TabIndex = 4;
			// 
			// btAnalize
			// 
			this.btAnalize.Location = new System.Drawing.Point(546, 135);
			this.btAnalize.Name = "btAnalize";
			this.btAnalize.Size = new System.Drawing.Size(75, 23);
			this.btAnalize.TabIndex = 5;
			this.btAnalize.Text = "Анализ";
			this.btAnalize.UseVisualStyleBackColor = true;
			this.btAnalize.Click += new System.EventHandler(this.BtAnalizeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1243, 922);
			this.Controls.Add(this.btAnalize);
			this.Controls.Add(this.tbAtrib);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btStop);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.webBrowser1);
			this.Name = "MainForm";
			this.Text = "bot";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}	
}