using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RecipeGenerator
{
	/// Summary description for RecipeWindow.
	public class RecipeWindow : System.Windows.Forms.Form
	{
		public  RichTextBox recipeText;
		private System.Windows.Forms.Button m_back;
		private System.Windows.Forms.Button m_forward;
		private System.Windows.Forms.GroupBox groupBox1;
		public  DataManager dm = new DataManager();
		public  int Recipe_index=0;
		public string hex;
		/// Required designer variable.
		private System.ComponentModel.Container components = null;

		public RecipeWindow()
		{
			
			// Required for Windows Form Designer support
			InitializeComponent();
			// TODO: Add any constructor code after InitializeComponent call			
		}

		/// Clean up any resources being used.
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RecipeWindow));
			this.recipeText = new System.Windows.Forms.RichTextBox();
			this.m_back = new System.Windows.Forms.Button();
			this.m_forward = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// recipeText
			// 
			this.recipeText.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.recipeText.BackColor = System.Drawing.SystemColors.Window;
			this.recipeText.Location = new System.Drawing.Point(8, 8);
			this.recipeText.Name = "recipeText";
			this.recipeText.ReadOnly = true;
			this.recipeText.Size = new System.Drawing.Size(272, 272);
			this.recipeText.TabIndex = 0;
			this.recipeText.Text = "";
			// 
			// m_back
			// 
			this.m_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.m_back.Image = ((System.Drawing.Bitmap)(resources.GetObject("m_back.Image")));
			this.m_back.Location = new System.Drawing.Point(16, 11);
			this.m_back.Name = "m_back";
			this.m_back.Size = new System.Drawing.Size(32, 24);
			this.m_back.TabIndex = 4;
			// 
			// m_forward
			// 
			this.m_forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.m_forward.Image = ((System.Drawing.Bitmap)(resources.GetObject("m_forward.Image")));
			this.m_forward.Location = new System.Drawing.Point(64, 11);
			this.m_forward.Name = "m_forward";
			this.m_forward.Size = new System.Drawing.Size(32, 24);
			this.m_forward.TabIndex = 2;
			this.m_forward.Click += new System.EventHandler(this.m_forward_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.m_forward,
																					this.m_back});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(0, 285);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 40);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// RecipeWindow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(290, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.recipeText});
			this.Name = "RecipeWindow";
			this.Text = "RecipeWindow";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.RecipeWin_Load);
			this.Activated += new System.EventHandler(this.RecipeWin_Activated);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		#endregion
		private void RecipeWin_Load(object sender, System.EventArgs e)
		{
			ToolTip toolTip1 = new ToolTip();

         // Set up the delays for the ToolTip.
			toolTip1.AutoPopDelay = 3000;
			toolTip1.InitialDelay = 1000;
			toolTip1.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip1.ShowAlways = true;
			// Set up the ToolTip text for the Button and Checkbox.
			toolTip1.SetToolTip(this.m_back, "Back");
         toolTip1.SetToolTip(this.m_forward, "Forward");

		}
		private void RecipeWin_Activated(object sender, System.EventArgs e)
		{			
			dm.SetIndex(Recipe_index);
		}
		public void Update_Notified(bool update)
		{
			if(update) dm.ProcessCycle(hex);
			else return;
		}
		private void m_forward_Click(object sender, System.EventArgs e)
		{	
			recipeText.Rtf = @"{\rtf1\ansi\ "+dm.Forward()[2].ToString()+"\\b\\b0.}";
		}
	}
}
