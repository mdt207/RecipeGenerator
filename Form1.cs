/* Made by 207[MZ] from TKL K96
 * for Proton Softawre Division MP
 * greetingz go to TKL K96,out of limit
 * electric man,Jimi,AE,Sherzod 
 * (c) 2002-2005 Proton MP
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace RecipeGenerator
{
	/// Summary description for Form1.
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox m_meat;
		private System.Windows.Forms.CheckBox m_vegetableoil;
		private System.Windows.Forms.CheckBox m_carrot,m_onion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox m_pumpkin,m_garlik;
		private System.Windows.Forms.Button m_start;
		private System.Windows.Forms.CheckBox m_potato,m_tomato,m_cabbage;
		private System.Windows.Forms.ListBox m_Recipelist;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		//private BindingManagerBase bmRecipesRTB;

		/// Required designer variable.
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			this.about.ShowDialog();
			// Required for Windows Form Designer support
			InitializeComponent();
			// TODO: Add any constructor code after InitializeComponent call
			hex=new string(' ',3);
			//for(short c=0; c<15; c++) m_stream[c]=0;
		}
		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.m_meat = new System.Windows.Forms.CheckBox();
			this.m_vegetableoil = new System.Windows.Forms.CheckBox();
			this.m_carrot = new System.Windows.Forms.CheckBox();
			this.m_onion = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.m_cabbage = new System.Windows.Forms.CheckBox();
			this.m_tomato = new System.Windows.Forms.CheckBox();
			this.m_potato = new System.Windows.Forms.CheckBox();
			this.m_garlik = new System.Windows.Forms.CheckBox();
			this.m_pumpkin = new System.Windows.Forms.CheckBox();
			this.m_start = new System.Windows.Forms.Button();
			this.m_Recipelist = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_meat
			// 
			this.m_meat.Location = new System.Drawing.Point(24, 32);
			this.m_meat.Name = "m_meat";
			this.m_meat.Size = new System.Drawing.Size(56, 16);
			this.m_meat.TabIndex = 0;
			this.m_meat.Text = "Meat";
			this.m_meat.CheckedChanged += new System.EventHandler(this.m_meat_CheckedChanged);
			// 
			// m_vegetableoil
			// 
			this.m_vegetableoil.Location = new System.Drawing.Point(104, 32);
			this.m_vegetableoil.Name = "m_vegetableoil";
			this.m_vegetableoil.Size = new System.Drawing.Size(88, 16);
			this.m_vegetableoil.TabIndex = 1;
			this.m_vegetableoil.Text = "VegetableOil";
			this.m_vegetableoil.CheckedChanged += new System.EventHandler(this.m_vegetableoil_CheckedChanged);
			// 
			// m_carrot
			// 
			this.m_carrot.Location = new System.Drawing.Point(24, 64);
			this.m_carrot.Name = "m_carrot";
			this.m_carrot.Size = new System.Drawing.Size(56, 16);
			this.m_carrot.TabIndex = 2;
			this.m_carrot.Text = "Carrot";
			this.m_carrot.CheckedChanged += new System.EventHandler(this.m_carrot_CheckedChanged);
			// 
			// m_onion
			// 
			this.m_onion.Location = new System.Drawing.Point(104, 64);
			this.m_onion.Name = "m_onion";
			this.m_onion.Size = new System.Drawing.Size(64, 16);
			this.m_onion.TabIndex = 3;
			this.m_onion.Text = "Onion";
			this.m_onion.CheckedChanged += new System.EventHandler(this.m_onion_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.m_cabbage,
																					this.m_tomato,
																					this.m_potato,
																					this.m_garlik,
																					this.m_pumpkin,
																					this.m_vegetableoil,
																					this.m_onion,
																					this.m_meat,
																					this.m_carrot});
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 160);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingredients";
			// 
			// m_cabbage
			// 
			this.m_cabbage.Location = new System.Drawing.Point(208, 96);
			this.m_cabbage.Name = "m_cabbage";
			this.m_cabbage.Size = new System.Drawing.Size(72, 16);
			this.m_cabbage.TabIndex = 8;
			this.m_cabbage.Text = "Cabbage";
			this.m_cabbage.CheckedChanged += new System.EventHandler(this.m_cabbage_CheckedChanged);
			// 
			// m_tomato
			// 
			this.m_tomato.Location = new System.Drawing.Point(104, 96);
			this.m_tomato.Name = "m_tomato";
			this.m_tomato.Size = new System.Drawing.Size(64, 16);
			this.m_tomato.TabIndex = 7;
			this.m_tomato.Text = "Tomato";
			this.m_tomato.CheckedChanged += new System.EventHandler(this.m_tomato_CheckedChanged);
			// 
			// m_potato
			// 
			this.m_potato.Location = new System.Drawing.Point(24, 96);
			this.m_potato.Name = "m_potato";
			this.m_potato.Size = new System.Drawing.Size(56, 16);
			this.m_potato.TabIndex = 6;
			this.m_potato.Text = "Potato";
			this.m_potato.CheckedChanged += new System.EventHandler(this.m_potato_CheckedChanged);
			// 
			// m_garlik
			// 
			this.m_garlik.Location = new System.Drawing.Point(208, 64);
			this.m_garlik.Name = "m_garlik";
			this.m_garlik.Size = new System.Drawing.Size(56, 16);
			this.m_garlik.TabIndex = 5;
			this.m_garlik.Text = "Garlik";
			this.m_garlik.CheckedChanged += new System.EventHandler(this.m_garlik_CheckedChanged);
			// 
			// m_pumpkin
			// 
			this.m_pumpkin.Location = new System.Drawing.Point(208, 32);
			this.m_pumpkin.Name = "m_pumpkin";
			this.m_pumpkin.Size = new System.Drawing.Size(72, 16);
			this.m_pumpkin.TabIndex = 4;
			this.m_pumpkin.Text = "Pumpkin";
			this.m_pumpkin.CheckedChanged += new System.EventHandler(this.m_pumpkin_CheckedChanged_1);
			// 
			// m_start
			// 
			this.m_start.BackColor = System.Drawing.Color.LightGray;
			this.m_start.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_start.Location = new System.Drawing.Point(16, 272);
			this.m_start.Name = "m_start";
			this.m_start.Size = new System.Drawing.Size(80, 24);
			this.m_start.TabIndex = 5;
			this.m_start.Text = "Start";
			this.m_start.Click += new System.EventHandler(this.m_start_Click);
			// 
			// m_Recipelist
			// 
			this.m_Recipelist.BackColor = System.Drawing.SystemColors.Info;
			this.m_Recipelist.Location = new System.Drawing.Point(8, 15);
			this.m_Recipelist.Name = "m_Recipelist";
			this.m_Recipelist.Size = new System.Drawing.Size(152, 134);
			this.m_Recipelist.TabIndex = 7;
			this.m_Recipelist.SelectedIndexChanged += new System.EventHandler(this.m_Recipelist_Select);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.m_Recipelist});
			this.groupBox2.Location = new System.Drawing.Point(384, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(168, 160);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recipes";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem6});
			this.menuItem1.Text = "Option";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Language";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Clear All";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "Exit";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "Help";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "About";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_start,
																		  this.groupBox1,
																		  this.groupBox2});
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "RecipeGenerator";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintHandler);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			DataBind();

		}
		#endregion

		/// The main entry point for the application.
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void PaintHandler(Object sender, PaintEventArgs e)
		{
			DrawStr(e);
		}

		private void Process()
		{
			if(m_meat.Checked)         m_stream[0]=1;
			else m_stream[0]=0;
			if(m_vegetableoil.Checked) m_stream[1]=1;
			else m_stream[1]=0;
			if(m_carrot.Checked)       m_stream[2]=1;
			else m_stream[2]=0;
			if(m_onion.Checked)        m_stream[3]=1; 
			else m_stream[3]=0;
			if(m_potato.Checked)       m_stream[4]=1;
			else m_stream[4]=0;
			if(m_tomato.Checked)       m_stream[5]=1;
			else m_stream[5]=0;
			if(m_pumpkin.Checked)      m_stream[6]=1;
			else m_stream[6]=0;
			if(m_garlik.Checked)       m_stream[7]=1;
			else m_stream[7]=0;
			if(m_cabbage.Checked)      m_stream[8]=1;
			else m_stream[8]=0;
			Refresh();
		
		}

		private void m_meat_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}
		private void m_vegetableoil_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_carrot_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_onion_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_pumpkin_CheckedChanged_1(object sender, System.EventArgs e)
		{
			Process();		
		}

		private void m_garlik_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_potato_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_tomato_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}

		private void m_cabbage_CheckedChanged(object sender, System.EventArgs e)
		{
			Process();
		}


		private void m_Recipelist_Select(object sender, System.EventArgs e)
		{	
			//System.Windows.Forms.MessageBox.Show(m_Recipelist.SelectedIndex.ToString());
			/*c+=dir;
			System.Windows.Forms.MessageBox.Show(c.ToString());
			if( c > m_Recipelist.Items.Count) 
			{
				if((m_Recipelist.SelectedIndex+1) == m_Recipelist.Items.Count)
				{dir=-1; c=m_Recipelist.Items.Count;}
				else { dir=1; c=0;}
			}*/
		
		/*	switch(c)
			{
				case 0:str="test 0";break;
				case 1:str="test 1";break;
				case 2:str="test 2";break;
				case 3:str="test 3";break;
				default:break;
			}
			//DataRow[] childRows;
			rwin.recipeText.Rtf = @"{\rtf1\ansi\ " + str + "\\b\\b0.}";*/
			rwin.recipeText.Clear();
			rwin.recipeText.Refresh();
			//bmRecipesRTB.Position += 1 ;
			/*foreach(DataRow myRow in foundRows)
			{
				childRows = myRow.GetChildRows(m_Rel);				
				/*foreach( DataRow r in childRows )
				{					
					rwin.recipeText.Rtf = @"{\rtf1\ansi\ "+r[2].ToString()+"\\b\\b0.}";
				}
			}*/
			if(rwin.IsDisposed)
			{
				rwin = new RecipeWindow();
				rwin.dm.ProcessCycle(hex);
			}
			rwin.Recipe_index = m_Recipelist.SelectedIndex;
			rwin.recipeText.Rtf = @"{\rtf1\ansi\ "+childRows[m_Recipelist.SelectedIndex][2].ToString()+"\\b\\b0.}";
			rwin.Show();
		}

    	protected void DrawStr(PaintEventArgs e)
		{	
			for(int c=0;c<9;c++)
			e.Graphics.DrawString(m_stream[c].ToString(),font,
				brush,10+c*10,215);
			e.Graphics.DrawString(dec.ToString(),font,
				brush,120,215);
			for(int c1=hex.Length-1; c1>=0; --c1)
				e.Graphics.DrawString(hex[c1].ToString(),font,
					brush,170-c1*9,215);
			//DataTableCollection dta = myDataSet.Tables;
			/*DataRowCollection dra = myDataSet.Tables["Categories"].Rows; 
			if(dec<17)
			e.Graphics.DrawString(dra[dec][2].ToString(),font,
				brush,10,200);*/
			for(int i=0;i<foundRows.Length;++i)
			e.Graphics.DrawString(foundRows[0][1].ToString(),font,
				brush,10,230+i*15);
		}
		private void m_start_Click(object sender, System.EventArgs e)
		{
			this.m_Recipelist.Items.Clear();

			Bin2Dec();Bin2Hex();
			string strExpr;//criteria of filtering
			strExpr = "Index="+"'"+hex.ToString()+"'";
			//strExpr = "Index<="+" '"+"005"+"'";
			// Use the Select method to find all rows matching the filter.
			foundRows = myTable.Select(strExpr);
			
			//DataTable mTable = myDataSet.Tables[0];

			foreach(DataRow myRow in foundRows)
			{
				childRows = myRow.GetChildRows(m_Rel);				
				foreach( DataRow r in childRows )
				{
					m_Recipelist.Items.Add(r[1].ToString());	
				}
			} 						
			//c=m_Recipelist.Items.Count;
			rwin.hex=hex;
			rwin.Update_Notified(true);
			Refresh();
		}
		private void Bin2Hex()
		{
			int dec=0;
			short b=0;
			char hexdigit=new char();
			rwin.hex=hex=string.Empty;
			for(short c=0; c < 3; ++c)
			{
				switch(c)
				{
					case 1:b=4;break;
					case 2:b=8;break;
					default:break;
				} 
				for(short i=b; i<=b+3; ++i)
					dec+=m_stream[i]*Convert.ToInt32(Math.Pow(2,i-b));
				switch(dec)
				{
					case 0:hexdigit='0'; break;
					case 1:hexdigit='1'; break;
					case 2:hexdigit='2'; break;
					case 3:hexdigit='3'; break;
					case 4:hexdigit='4'; break;
					case 5:hexdigit='5'; break;
					case 6:hexdigit='6'; break;
					case 7:hexdigit='7'; break;
					case 8:hexdigit='8'; break;
					case 9:hexdigit='9'; break;
					case 10:hexdigit='A'; break;
					case 11:hexdigit='B'; break;
					case 12:hexdigit='C'; break;
					case 13:hexdigit='D'; break;
					case 14:hexdigit='E'; break;
					case 15:hexdigit='F'; break;
					default:hex=dec.ToString(); break;
				}
				dec=0;	hex+=hexdigit.ToString();
			}
		}
		private void Bin2Dec()
		{
			dec=0;
			for(short c=0 ; c<m_stream.Length ; c++)
				dec+=m_stream[c]*Convert.ToInt32(Math.Pow(2,c));
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			AboutUs about = new AboutUs(false);
			about.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Language lang = new Language();
			lang.ShowDialog();
		}
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//clears all check boxes
			this.m_cabbage.Checked = false;
			this.m_carrot.Checked = false;
			this.m_garlik.Checked = false;
			this.m_meat.Checked = false;
			this.m_onion.Checked = false;
			this.m_potato.Checked = false;
			this.m_pumpkin.Checked = false;
			this.m_tomato.Checked = false;
			this.m_vegetableoil.Checked = false;
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			//exit main programm
			this.Close();
		}
		private void DataBind()
		{
			//Data initializing part
#if USINGPROJECTSYSTEM
           strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Visual Studio Projects\\RecipeGenerator\\BugTypes.MDB";
#else
			strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BugTypes.MDB";
#endif
			strAccessSelect = "SELECT * FROM Categories";
			string sSubRecipes = "SELECT * FROM SubRecipes";
			//strAccessSelect="SELECT * FROM Categories WHERE Index IN ('001', '009', '00A', '00D')";
			// Create the dataset and add the Categories table to it:
			myDataSet = new DataSet();
			myDataSet.Tables.Add("Categories");
			myTable = myDataSet.Tables["Categories"];
			// Create Access objects:
			myAccessConn = new OleDbConnection(strAccessConn);
			myAccessCommand1 = new OleDbCommand(strAccessSelect,myAccessConn);
			myAccessCommand2 = new OleDbCommand(sSubRecipes,myAccessConn);
			myDataAdapter1 = new OleDbDataAdapter(myAccessCommand1);
			myDataAdapter2 = new OleDbDataAdapter(myAccessCommand2);

			foundRows = myTable.Select(null, null, DataViewRowState.CurrentRows);
			myAccessConn.Open();
			try
			{
				myDataAdapter1.Fill(myDataSet,"Categories");
				myDataAdapter2.Fill(myDataSet,"SubRecipes");

			}
			finally
			{
				myAccessConn.Close();
			}
		 m_Rel = myDataSet.Relations.Add("Relation",
				myDataSet.Tables["Categories"].Columns["Index"],
				myDataSet.Tables["SubRecipes"].Columns["Index"]);
		
		//rwin.recipeText.DataBindings.Add(new Binding("Text", myDataSet, "SubRecipes.RichText"));
		//bmRecipesRTB = this.BindingContext[myDataSet,"SubRecipes.RichText"];
			
		}


		private int[] m_stream=new int[15];
		private Font font=new Font("Arial",10);
		private SolidBrush brush = new SolidBrush(Color.AliceBlue);
		int dec;
		string strAccessConn,strAccessSelect;
		public  string hex;
		private OleDbDataAdapter myDataAdapter1,myDataAdapter2;
		private OleDbCommand myAccessCommand1,myAccessCommand2;
		private OleDbConnection myAccessConn;
		private DataSet myDataSet;
		private DataTable myTable;
		private DataRow[] foundRows,childRows;
		private DataRelation m_Rel;
		private RecipeWindow rwin = new RecipeWindow();
		private AboutUs about = new AboutUs(true);

	}
}
