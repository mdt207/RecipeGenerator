using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RecipeGenerator
{

	public class Language : System.Windows.Forms.Form
	{
		private RadioButton m_turk;
		private RadioButton m_uzbek;
		private RadioButton m_english;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Language()
		{
			InitializeComponent();	
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
			this.m_turk = new System.Windows.Forms.RadioButton();
			this.m_uzbek = new System.Windows.Forms.RadioButton();
			this.m_english = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// m_turk
			// 
			this.m_turk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.m_turk.Location = new System.Drawing.Point(48, 38);
			this.m_turk.Name = "m_turk";
			this.m_turk.TabIndex = 0;
			this.m_turk.Text = "Turkce";
			// 
			// m_uzbek
			// 
			this.m_uzbek.Location = new System.Drawing.Point(48, 78);
			this.m_uzbek.Name = "m_uzbek";
			this.m_uzbek.TabIndex = 1;
			this.m_uzbek.Text = "Uzbekcha";
			// 
			// m_english
			// 
			this.m_english.Location = new System.Drawing.Point(48, 118);
			this.m_english.Name = "m_english";
			this.m_english.TabIndex = 2;
			this.m_english.Text = "English";
			// 
			// Language
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(200, 181);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_english,
																		  this.m_uzbek,
																		  this.m_turk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Language";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Language";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
