// <fileinfo name="tblPaymentCollection_Base.cs">
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
	/// The base class for <see cref="tblPaymentCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblPaymentCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblPaymentCollection_Base
	{
		// Constants
		public const string Payment_IdColumnName = "Payment_Id";
		public const string Payment_DateColumnName = "Payment_Date";
		public const string ReferenceColumnName = "Reference";
		public const string Vendor_IdColumnName = "Vendor_Id";
		public const string CashBankColumnName = "CashBank";
		public const string ChequeNoColumnName = "ChequeNo";
		public const string Payment_Type_IdColumnName = "Payment_Type_Id";
		public const string Invoice_IdColumnName = "Invoice_Id";
		public const string AmountColumnName = "Amount";
		public const string Donor_IdColumnName = "Donor_Id";
		public const string GL_Act_IdColumnName = "GL_Act_Id";
		public const string Currency_IdColumnName = "Currency_Id";
		public const string Company_IdColumnName = "Company_Id";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_TimeColumnName = "Updated_Time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblPaymentCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblPaymentCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblPayment</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public virtual tblPaymentRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblPayment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblPayment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblPayment_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblPaymentRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblPaymentRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblPaymentRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblPaymentRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public tblPaymentRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects that 
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
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public virtual tblPaymentRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblPayment]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblPaymentRow"/> by the primary key.
		/// </summary>
		/// <param name="payment_Id">The <c>Payment_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblPaymentRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblPaymentRow GetByPrimaryKey(int payment_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_GetByPrimaryKey", true);
			AddParameter(cmd, "Payment_Id", payment_Id);
			tblPaymentRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects 
		/// by the <c>FK_tblPayment_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public virtual tblPaymentRow[] GetByCompany_Id(int company_Id)
		{
			return MapRecords(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblPayment_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByCompany_IdAsDataTable(int company_Id)
		{
			return MapRecordsToDataTable(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblPayment_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_GetBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects 
		/// by the <c>FK_tblPayment_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public virtual tblPaymentRow[] GetByGL_Act_Id(int gL_Act_Id)
		{
			return MapRecords(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblPayment_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByGL_Act_IdAsDataTable(int gL_Act_Id)
		{
			return MapRecordsToDataTable(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblPayment_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_GetBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects 
		/// by the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public tblPaymentRow[] GetByVendor_Id(int vendor_Id)
		{
			return GetByVendor_Id(vendor_Id, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblPaymentRow"/> objects 
		/// by the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <param name="vendor_IdNull">true if the method ignores the vendor_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		public virtual tblPaymentRow[] GetByVendor_Id(int vendor_Id, bool vendor_IdNull)
		{
			return MapRecords(CreateGetByVendor_IdCommand(vendor_Id, vendor_IdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByVendor_IdAsDataTable(int vendor_Id)
		{
			return GetByVendor_IdAsDataTable(vendor_Id, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <param name="vendor_IdNull">true if the method ignores the vendor_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByVendor_IdAsDataTable(int vendor_Id, bool vendor_IdNull)
		{
			return MapRecordsToDataTable(CreateGetByVendor_IdCommand(vendor_Id, vendor_IdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <param name="vendor_IdNull">true if the method ignores the vendor_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByVendor_IdCommand(int vendor_Id, bool vendor_IdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_GetBy_Vendor_Id", true);
			AddParameter(cmd, "Vendor_Id", vendor_IdNull ? null : (object)vendor_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblPayment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblPaymentRow"/> object to be inserted.</param>
		public virtual void Insert(tblPaymentRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_Insert", true);
			AddParameter(cmd, "Payment_Date", value.Payment_Date);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "Vendor_Id",
				value.IsVendor_IdNull ? DBNull.Value : (object)value.Vendor_Id);
			AddParameter(cmd, "CashBank", value.CashBank);
			AddParameter(cmd, "ChequeNo", value.ChequeNo);
			AddParameter(cmd, "Payment_Type_Id", value.Payment_Type_Id);
			AddParameter(cmd, "Invoice_Id",
				value.IsInvoice_IdNull ? DBNull.Value : (object)value.Invoice_Id);
			AddParameter(cmd, "Amount", value.Amount);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			value.Payment_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblPayment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblPaymentRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblPaymentRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_Update", true);
			AddParameter(cmd, "Payment_Date", value.Payment_Date);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "Vendor_Id",
				value.IsVendor_IdNull ? DBNull.Value : (object)value.Vendor_Id);
			AddParameter(cmd, "CashBank", value.CashBank);
			AddParameter(cmd, "ChequeNo", value.ChequeNo);
			AddParameter(cmd, "Payment_Type_Id", value.Payment_Type_Id);
			AddParameter(cmd, "Invoice_Id",
				value.IsInvoice_IdNull ? DBNull.Value : (object)value.Invoice_Id);
			AddParameter(cmd, "Amount", value.Amount);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			AddParameter(cmd, "Payment_Id", value.Payment_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblPayment</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblPayment</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Payment_Id"]);
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
		/// Deletes the specified object from the <c>tblPayment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblPaymentRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblPaymentRow value)
		{
			return DeleteByPrimaryKey(value.Payment_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblPayment</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="payment_Id">The <c>Payment_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int payment_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Payment_Id", payment_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblPayment</c> table using the 
		/// <c>FK_tblPayment_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByCompany_Id(int company_Id)
		{
			return CreateDeleteByCompany_IdCommand(company_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblPayment_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_DeleteBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblPayment</c> table using the 
		/// <c>FK_tblPayment_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByGL_Act_Id(int gL_Act_Id)
		{
			return CreateDeleteByGL_Act_IdCommand(gL_Act_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblPayment_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_DeleteBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblPayment</c> table using the 
		/// <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByVendor_Id(int vendor_Id)
		{
			return DeleteByVendor_Id(vendor_Id, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblPayment</c> table using the 
		/// <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <param name="vendor_IdNull">true if the method ignores the vendor_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByVendor_Id(int vendor_Id, bool vendor_IdNull)
		{
			return CreateDeleteByVendor_IdCommand(vendor_Id, vendor_IdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblPayment_tblVendor</c> foreign key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <param name="vendor_IdNull">true if the method ignores the vendor_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByVendor_IdCommand(int vendor_Id, bool vendor_IdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblPayment_DeleteBy_Vendor_Id", true);
			AddParameter(cmd, "Vendor_Id", vendor_IdNull ? null : (object)vendor_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblPayment</c> records that match the specified criteria.
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
		/// to delete <c>tblPayment</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblPayment]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblPayment</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblPayment_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		protected tblPaymentRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		protected tblPaymentRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblPaymentRow"/> objects.</returns>
		protected virtual tblPaymentRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int payment_IdColumnIndex = reader.GetOrdinal("Payment_Id");
			int payment_DateColumnIndex = reader.GetOrdinal("Payment_Date");
			int referenceColumnIndex = reader.GetOrdinal("Reference");
			int vendor_IdColumnIndex = reader.GetOrdinal("Vendor_Id");
			int cashBankColumnIndex = reader.GetOrdinal("CashBank");
			int chequeNoColumnIndex = reader.GetOrdinal("ChequeNo");
			int payment_Type_IdColumnIndex = reader.GetOrdinal("Payment_Type_Id");
			int invoice_IdColumnIndex = reader.GetOrdinal("Invoice_Id");
			int amountColumnIndex = reader.GetOrdinal("Amount");
			int donor_IdColumnIndex = reader.GetOrdinal("Donor_Id");
			int gL_Act_IdColumnIndex = reader.GetOrdinal("GL_Act_Id");
			int currency_IdColumnIndex = reader.GetOrdinal("Currency_Id");
			int company_IdColumnIndex = reader.GetOrdinal("Company_Id");
			int created_ByColumnIndex = reader.GetOrdinal("Created_By");
			int created_TimeColumnIndex = reader.GetOrdinal("Created_Time");
			int updated_ByColumnIndex = reader.GetOrdinal("Updated_By");
			int updated_TimeColumnIndex = reader.GetOrdinal("Updated_Time");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblPaymentRow record = new tblPaymentRow();
					recordList.Add(record);

					record.Payment_Id = Convert.ToInt32(reader.GetValue(payment_IdColumnIndex));
					record.Payment_Date = Convert.ToDateTime(reader.GetValue(payment_DateColumnIndex));
					if(!reader.IsDBNull(referenceColumnIndex))
						record.Reference = Convert.ToString(reader.GetValue(referenceColumnIndex));
					if(!reader.IsDBNull(vendor_IdColumnIndex))
						record.Vendor_Id = Convert.ToInt32(reader.GetValue(vendor_IdColumnIndex));
					record.CashBank = Convert.ToBoolean(reader.GetValue(cashBankColumnIndex));
					if(!reader.IsDBNull(chequeNoColumnIndex))
						record.ChequeNo = Convert.ToString(reader.GetValue(chequeNoColumnIndex));
					record.Payment_Type_Id = Convert.ToInt32(reader.GetValue(payment_Type_IdColumnIndex));
					if(!reader.IsDBNull(invoice_IdColumnIndex))
						record.Invoice_Id = Convert.ToInt32(reader.GetValue(invoice_IdColumnIndex));
					record.Amount = Convert.ToInt32(reader.GetValue(amountColumnIndex));
					record.Donor_Id = Convert.ToInt32(reader.GetValue(donor_IdColumnIndex));
					record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));
					record.Currency_Id = Convert.ToInt32(reader.GetValue(currency_IdColumnIndex));
					record.Company_Id = Convert.ToInt32(reader.GetValue(company_IdColumnIndex));
					record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					record.Updated_Time = Convert.ToDateTime(reader.GetValue(updated_TimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblPaymentRow[])(recordList.ToArray(typeof(tblPaymentRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblPaymentRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblPaymentRow"/> object.</returns>
		protected virtual tblPaymentRow MapRow(DataRow row)
		{
			tblPaymentRow mappedObject = new tblPaymentRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Payment_Id"
			dataColumn = dataTable.Columns["Payment_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Payment_Id = (int)row[dataColumn];
			// Column "Payment_Date"
			dataColumn = dataTable.Columns["Payment_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Payment_Date = (System.DateTime)row[dataColumn];
			// Column "Reference"
			dataColumn = dataTable.Columns["Reference"];
			if(!row.IsNull(dataColumn))
				mappedObject.Reference = (string)row[dataColumn];
			// Column "Vendor_Id"
			dataColumn = dataTable.Columns["Vendor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Vendor_Id = (int)row[dataColumn];
			// Column "CashBank"
			dataColumn = dataTable.Columns["CashBank"];
			if(!row.IsNull(dataColumn))
				mappedObject.CashBank = (bool)row[dataColumn];
			// Column "ChequeNo"
			dataColumn = dataTable.Columns["ChequeNo"];
			if(!row.IsNull(dataColumn))
				mappedObject.ChequeNo = (string)row[dataColumn];
			// Column "Payment_Type_Id"
			dataColumn = dataTable.Columns["Payment_Type_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Payment_Type_Id = (int)row[dataColumn];
			// Column "Invoice_Id"
			dataColumn = dataTable.Columns["Invoice_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_Id = (int)row[dataColumn];
			// Column "Amount"
			dataColumn = dataTable.Columns["Amount"];
			if(!row.IsNull(dataColumn))
				mappedObject.Amount = (int)row[dataColumn];
			// Column "Donor_Id"
			dataColumn = dataTable.Columns["Donor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Id = (int)row[dataColumn];
			// Column "GL_Act_Id"
			dataColumn = dataTable.Columns["GL_Act_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Act_Id = (int)row[dataColumn];
			// Column "Currency_Id"
			dataColumn = dataTable.Columns["Currency_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Currency_Id = (int)row[dataColumn];
			// Column "Company_Id"
			dataColumn = dataTable.Columns["Company_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Company_Id = (int)row[dataColumn];
			// Column "Created_By"
			dataColumn = dataTable.Columns["Created_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_By = (int)row[dataColumn];
			// Column "Created_Time"
			dataColumn = dataTable.Columns["Created_Time"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_Time = (System.DateTime)row[dataColumn];
			// Column "Updated_By"
			dataColumn = dataTable.Columns["Updated_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_By = (int)row[dataColumn];
			// Column "Updated_Time"
			dataColumn = dataTable.Columns["Updated_Time"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_Time = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblPayment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblPayment";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Payment_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Payment_Date", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Reference", typeof(string));
			dataColumn.MaxLength = 25;
			dataColumn = dataTable.Columns.Add("Vendor_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("CashBank", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("ChequeNo", typeof(string));
			dataColumn.MaxLength = 10;
			dataColumn = dataTable.Columns.Add("Payment_Type_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Invoice_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("Amount", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Donor_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Currency_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Company_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_Time", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_Time", typeof(System.DateTime));
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
				case "Payment_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Payment_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Reference":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Vendor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "CashBank":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "ChequeNo":
					parameter = _db.AddParameter(cmd, paramName, DbType.StringFixedLength, value);
					break;

				case "Payment_Type_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Invoice_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Amount":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Donor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "GL_Act_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Currency_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Company_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Created_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Created_Time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Updated_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Updated_Time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblPaymentCollection_Base class
}  // End of namespace
