/* Satellite DataManager class
 * TKL K96a 207 (c) 2002-2004  
 * Portions Proton
 */
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace RecipeGenerator
{
	public class DataManager
	{
		string  strAccessConn,strAccessSelect;
		private OleDbDataAdapter myDataAdapter1,myDataAdapter2;
		private OleDbCommand myAccessCommand1,myAccessCommand2;
		private OleDbConnection myAccessConn;
		private DataSet myDataSet;
		private DataTable myTable;
		private DataRow[] foundRows,childRows;
		private DataRelation m_Rel;
		private int c=0;
		private ArrayList m_Recipelist;		

		public DataManager()
		{
			// TODO: Add constructor logic here
		    m_Recipelist = new ArrayList();
			c=0;
			DataBind();
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

		}//DataBind func

		public void ProcessCycle(string hex)
		{
			m_Recipelist.Clear();
			this.c=0;
			string strExpr;//criteria of filtering
			strExpr = "Index="+"'"+hex.ToString()+"'";
			// Use the Select method to find all rows matching the filter.
			foundRows = myTable.Select(strExpr);

			foreach(DataRow myRow in foundRows)
			{
				childRows = myRow.GetChildRows(m_Rel);				
				foreach( DataRow r in childRows )
				{
					m_Recipelist.Add(r[1]);
				}
			} 						
		}
		public void SetIndex(int c)
		{
			this.c=c;
		}
		public DataRow Forward()
		{
			if(m_Recipelist.Count > 1 )
			{
				this.c++;
				if( this.c >= m_Recipelist.Count){ this.c=0; }		
			}
			return childRows[this.c];
		}
		
	}
}
