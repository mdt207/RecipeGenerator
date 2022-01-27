/*************************************
 * TKL K96A 207			     *
 * copyright 2002-2004		     *
 * portions Proton Computing Intl.   *
 ************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RecipeGenerator
{
	// Summary description for AboutUs.
	public class AboutUs : System.Windows.Forms.Form
	{
		private LinkLabel linkLabel1;
		private Label label1;
		private GroupBox groupBox1;
		private PictureBox pictureBox1;
		public  bool isSplash=true,trigger;
		private Timer myTimer = new Timer();
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;


		// Required designer variable.
		private System.ComponentModel.Container components = null;
		public AboutUs(bool isSplash)
		{
			this.isSplash = isSplash;
			// Required for Windows Form Designer support
			InitializeComponent();
			if(isSplash) doSplash();
			else doFlash();
			// TODO: Add any constructor code after InitializeComponent call
			//this.linkLabel1.Links.Add(0,24,"www.internetyazilim.com");
		}

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		// Required method for Designer support - do not modify
		// the contents of this method with the code editor.
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutUs));
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			//this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 24);
			this.linkLabel1.Location = new System.Drawing.Point(108, 189);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(136, 16);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "www.internetyazilim.com";
			this.linkLabel1.Links.Add(0,24,"www.internetyazilim.com");
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label1.Location = new System.Drawing.Point(64, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 48);
			this.label1.TabIndex = 4;
			this.label1.Text = "Copyright ©  TKL K96A 207   portions©  Proton Computing";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.pictureBox1,
																					this.linkLabel1,
																					this.label1,
																					this.checkBox1});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 224);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.ForeColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(144, 152);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(32, 16);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.TabStop = false;
			this.checkBox1.Text = "&i";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(272, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Demo 0.9 b";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(14, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(338, 96);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// AboutUs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(392, 248);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutUs";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Click += new System.EventHandler(this.about_Click);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		protected override void OnKeyDown(KeyEventArgs kevent)
		{
			if(kevent.Modifiers != Keys.Alt)
				this.Close();
		}

		private void about_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void groupBox1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public void doSplash()
		{
			init_Mytimer();
		}
		private void doFlash()
		{
			this.BackColor = System.Drawing.Color.Blue;
			this.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.HighlightText;
			init_Mytimer();
		}

		private void Flash()
		{
			if(trigger)
				pictureBox1.Image = Image.FromFile("splashoff.jpg");
			else 
				pictureBox1.Image = Image.FromFile("splashon.jpg");
		}

		private void init_Mytimer()
		{
    		this.myTimer.Tick += new EventHandler(this.TimerEventProcessor);
			if(isSplash)
        		this.myTimer.Interval = 2000;
			else 
				this.myTimer.Interval = 500;
			this.myTimer.Start();
		}

		private void TimerEventProcessor(Object myObject,
			EventArgs myEventArgs) 
		{
			if(isSplash)
			{
				this.myTimer.Stop();
				this.Close();
				this.Dispose();
			}
			else
			{
				//do Flash
				if(trigger) trigger=false;
				else trigger=true; 
				Flash();
			} 
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Determine which link was clicked within the LinkLabel.
			linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
			// Display the appropriate link based on the value of the LinkData property of the Link object.
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Programmed by: Zohid K96A 207 from TKL\nIdea: Yusuf Erturk \nCopyright (c) 2002-2005\n\n       zohid81@mail.ru","You found secret :(");
			this.linkLabel1.Focus();
		}
	}
}
