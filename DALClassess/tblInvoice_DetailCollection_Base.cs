// <fileinfo name="tblInvoice_DetailCollection_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;
using System.Data;

namespace IOM.IECFMS.DAL
{
	/// <summary>
	/// The base class for <see cref="tblInvoice_DetailCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblInvoice_DetailCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblInvoice_DetailCollection_Base
	{
		// Constants
		public const string Invoice_Det_IdColumnName = "Invoice_Det_Id";
		public const string Invoice_IdColumnName = "Invoice_Id";
		public const string Item_IdColumnName = "Item_Id";
		public const string PriceColumnName = "Price";
		public const string QuantityColumnName = "Quantity";
		public const string TotalColumnName = "Total";
		public const string GL_Act_IdColumnName = "GL_Act_Id";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblInvoice_DetailCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblInvoice_DetailCollection_Base(FMSDB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="FMSDB"/> object.</value>
		protected FMSDB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public virtual tblInvoice_DetailRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblInvoice_Detail_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblInvoice_DetailRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblInvoice_DetailRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblInvoice_DetailRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblInvoice_DetailRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoice_DetailRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public tblInvoice_DetailRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoice_DetailRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public virtual tblInvoice_DetailRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[tblInvoice_Detail]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblInvoice_DetailRow"/> by the primary key.
		/// </summary>
		/// <param name="invoice_Det_Id">The <c>Invoice_Det_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblInvoice_DetailRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblInvoice_DetailRow GetByPrimaryKey(int invoice_Det_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_GetByPrimaryKey", true);
			AddParameter(cmd, "Invoice_Det_Id", invoice_Det_Id);
			tblInvoice_DetailRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoice_DetailRow"/> objects 
		/// by the <c>FK_tblInvoice_Detail_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public virtual tblInvoice_DetailRow[] GetByGL_Act_Id(int gL_Act_Id)
		{
			return MapRecords(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblInvoice_Detail_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByGL_Act_IdAsDataTable(int gL_Act_Id)
		{
			return MapRecordsToDataTable(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblInvoice_Detail_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_GetBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoice_DetailRow"/> objects 
		/// by the <c>FK_tblInvoice_Detail_tblInvoice</c> foreign key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public virtual tblInvoice_DetailRow[] GetByInvoice_Id(int invoice_Id)
		{
			return MapRecords(CreateGetByInvoice_IdCommand(invoice_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblInvoice_Detail_tblInvoice</c> foreign key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByInvoice_IdAsDataTable(int invoice_Id)
		{
			return MapRecordsToDataTable(CreateGetByInvoice_IdCommand(invoice_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblInvoice_Detail_tblInvoice</c> foreign key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByInvoice_IdCommand(int invoice_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_GetBy_Invoice_Id", true);
			AddParameter(cmd, "Invoice_Id", invoice_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoice_DetailRow"/> objects 
		/// by the <c>FK_tblInvoice_Detail_tblItem</c> foreign key.
		/// </summary>
		/// <param name="item_Id">The <c>Item_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		public virtual tblInvoice_DetailRow[] GetByItem_Id(int item_Id)
		{
			return MapRecords(CreateGetByItem_IdCommand(item_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblInvoice_Detail_tblItem</c> foreign key.
		/// </summary>
		/// <param name="item_Id">The <c>Item_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByItem_IdAsDataTable(int item_Id)
		{
			return MapRecordsToDataTable(CreateGetByItem_IdCommand(item_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblInvoice_Detail_tblItem</c> foreign key.
		/// </summary>
		/// <param name="item_Id">The <c>Item_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByItem_IdCommand(int item_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_GetBy_Item_Id", true);
			AddParameter(cmd, "Item_Id", item_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoice_DetailRow"/> object to be inserted.</param>
		public virtual void Insert(tblInvoice_DetailRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_Insert", true);
			AddParameter(cmd, "Invoice_Id", value.Invoice_Id);
			AddParameter(cmd, "Item_Id", value.Item_Id);
			AddParameter(cmd, "Price", value.Price);
			AddParameter(cmd, "Quantity", value.Quantity);
			AddParameter(cmd, "Total", value.Total);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			value.Invoice_Det_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoice_DetailRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblInvoice_DetailRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_Update", true);
			AddParameter(cmd, "Invoice_Id", value.Invoice_Id);
			AddParameter(cmd, "Item_Id", value.Item_Id);
			AddParameter(cmd, "Price", value.Price);
			AddParameter(cmd, "Quantity", value.Quantity);
			AddParameter(cmd, "Total", value.Total);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Invoice_Det_Id", value.Invoice_Det_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblInvoice_Detail</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblInvoice_Detail</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((int)row["Invoice_Det_Id"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoice_DetailRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblInvoice_DetailRow value)
		{
			return DeleteByPrimaryKey(value.Invoice_Det_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblInvoice_Detail</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="invoice_Det_Id">The <c>Invoice_Det_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int invoice_Det_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Invoice_Det_Id", invoice_Det_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblInvoice_Detail</c> table using the 
		/// <c>FK_tblInvoice_Detail_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByGL_Act_Id(int gL_Act_Id)
		{
			return CreateDeleteByGL_Act_IdCommand(gL_Act_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblInvoice_Detail_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_DeleteBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblInvoice_Detail</c> table using the 
		/// <c>FK_tblInvoice_Detail_tblInvoice</c> foreign key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByInvoice_Id(int invoice_Id)
		{
			return CreateDeleteByInvoice_IdCommand(invoice_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblInvoice_Detail_tblInvoice</c> foreign key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByInvoice_IdCommand(int invoice_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_DeleteBy_Invoice_Id", true);
			AddParameter(cmd, "Invoice_Id", invoice_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblInvoice_Detail</c> table using the 
		/// <c>FK_tblInvoice_Detail_tblItem</c> foreign key.
		/// </summary>
		/// <param name="item_Id">The <c>Item_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByItem_Id(int item_Id)
		{
			return CreateDeleteByItem_IdCommand(item_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblInvoice_Detail_tblItem</c> foreign key.
		/// </summary>
		/// <param name="item_Id">The <c>Item_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByItem_IdCommand(int item_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Detail_DeleteBy_Item_Id", true);
			AddParameter(cmd, "Item_Id", item_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblInvoice_Detail</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
		/// to delete <c>tblInvoice_Detail</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblInvoice_Detail]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblInvoice_Detail_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		protected tblInvoice_DetailRow[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		protected tblInvoice_DetailRow[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="tblInvoice_DetailRow"/> objects.</returns>
		protected virtual tblInvoice_DetailRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int invoice_Det_IdColumnIndex = reader.GetOrdinal("Invoice_Det_Id");
			int invoice_IdColumnIndex = reader.GetOrdinal("Invoice_Id");
			int item_IdColumnIndex = reader.GetOrdinal("Item_Id");
			int priceColumnIndex = reader.GetOrdinal("Price");
			int quantityColumnIndex = reader.GetOrdinal("Quantity");
			int totalColumnIndex = reader.GetOrdinal("Total");
			int gL_Act_IdColumnIndex = reader.GetOrdinal("GL_Act_Id");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblInvoice_DetailRow record = new tblInvoice_DetailRow();
					recordList.Add(record);

					record.Invoice_Det_Id = Convert.ToInt32(reader.GetValue(invoice_Det_IdColumnIndex));
					record.Invoice_Id = Convert.ToInt32(reader.GetValue(invoice_IdColumnIndex));
					record.Item_Id = Convert.ToInt32(reader.GetValue(item_IdColumnIndex));
					record.Price = Convert.ToInt32(reader.GetValue(priceColumnIndex));
					record.Quantity = Convert.ToInt32(reader.GetValue(quantityColumnIndex));
					record.Total = Convert.ToInt32(reader.GetValue(totalColumnIndex));
					record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblInvoice_DetailRow[])(recordList.ToArray(typeof(tblInvoice_DetailRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblInvoice_DetailRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblInvoice_DetailRow"/> object.</returns>
		protected virtual tblInvoice_DetailRow MapRow(DataRow row)
		{
			tblInvoice_DetailRow mappedObject = new tblInvoice_DetailRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Invoice_Det_Id"
			dataColumn = dataTable.Columns["Invoice_Det_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_Det_Id = (int)row[dataColumn];
			// Column "Invoice_Id"
			dataColumn = dataTable.Columns["Invoice_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_Id = (int)row[dataColumn];
			// Column "Item_Id"
			dataColumn = dataTable.Columns["Item_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Item_Id = (int)row[dataColumn];
			// Column "Price"
			dataColumn = dataTable.Columns["Price"];
			if(!row.IsNull(dataColumn))
				mappedObject.Price = (int)row[dataColumn];
			// Column "Quantity"
			dataColumn = dataTable.Columns["Quantity"];
			if(!row.IsNull(dataColumn))
				mappedObject.Quantity = (int)row[dataColumn];
			// Column "Total"
			dataColumn = dataTable.Columns["Total"];
			if(!row.IsNull(dataColumn))
				mappedObject.Total = (int)row[dataColumn];
			// Column "GL_Act_Id"
			dataColumn = dataTable.Columns["GL_Act_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Act_Id = (int)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblInvoice_Detail";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Invoice_Det_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Invoice_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Item_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Price", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Quantity", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Total", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual IDbDataParameter AddParameter(IDbCommand cmd, string paramName, object value)
		{
			IDbDataParameter parameter;
			switch(paramName)
			{
				case "Invoice_Det_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Invoice_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Item_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Price":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Quantity":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Total":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "GL_Act_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblInvoice_DetailCollection_Base class
}  // End of namespace
