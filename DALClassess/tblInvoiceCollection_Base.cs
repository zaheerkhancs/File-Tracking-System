// <fileinfo name="tblInvoiceCollection_Base.cs">
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
	/// The base class for <see cref="tblInvoiceCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblInvoiceCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblInvoiceCollection_Base
	{
		// Constants
		public const string Invoice_IdColumnName = "Invoice_Id";
		public const string Invoice_NoColumnName = "Invoice_No";
		public const string Invoice_DateColumnName = "Invoice_Date";
		public const string Vendor_IdColumnName = "Vendor_Id";
		public const string ReferenceColumnName = "Reference";
		public const string Purchase_NoColumnName = "Purchase_No";
		public const string Gross_TotalColumnName = "Gross_Total";
		public const string DiscountColumnName = "Discount";
		public const string Net_TotalColumnName = "Net_Total";
		public const string Donor_IdColumnName = "Donor_Id";
		public const string Company_IdColumnName = "Company_Id";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_TimeColumnName = "Updated_Time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblInvoiceCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblInvoiceCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblInvoice</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		public virtual tblInvoiceRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblInvoice</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblInvoice</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblInvoice_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblInvoiceRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblInvoiceRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblInvoiceRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblInvoiceRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoiceRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		public tblInvoiceRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoiceRow"/> objects that 
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
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		public virtual tblInvoiceRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblInvoice]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblInvoiceRow"/> by the primary key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblInvoiceRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblInvoiceRow GetByPrimaryKey(int invoice_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_GetByPrimaryKey", true);
			AddParameter(cmd, "Invoice_Id", invoice_Id);
			tblInvoiceRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblInvoiceRow"/> objects 
		/// by the <c>FK_tblInvoice_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		public virtual tblInvoiceRow[] GetByCompany_Id(int company_Id)
		{
			return MapRecords(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblInvoice_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByCompany_IdAsDataTable(int company_Id)
		{
			return MapRecordsToDataTable(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblInvoice_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_GetBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblInvoice</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoiceRow"/> object to be inserted.</param>
		public virtual void Insert(tblInvoiceRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Insert", true);
			AddParameter(cmd, "Invoice_No", value.Invoice_No);
			AddParameter(cmd, "Invoice_Date", value.Invoice_Date);
			AddParameter(cmd, "Vendor_Id",
				value.IsVendor_IdNull ? DBNull.Value : (object)value.Vendor_Id);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "Purchase_No", value.Purchase_No);
			AddParameter(cmd, "Gross_Total", value.Gross_Total);
			AddParameter(cmd, "Discount", value.Discount);
			AddParameter(cmd, "Net_Total", value.Net_Total);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			value.Invoice_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblInvoice</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoiceRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblInvoiceRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_Update", true);
			AddParameter(cmd, "Invoice_No", value.Invoice_No);
			AddParameter(cmd, "Invoice_Date", value.Invoice_Date);
			AddParameter(cmd, "Vendor_Id",
				value.IsVendor_IdNull ? DBNull.Value : (object)value.Vendor_Id);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "Purchase_No", value.Purchase_No);
			AddParameter(cmd, "Gross_Total", value.Gross_Total);
			AddParameter(cmd, "Discount", value.Discount);
			AddParameter(cmd, "Net_Total", value.Net_Total);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			AddParameter(cmd, "Invoice_Id", value.Invoice_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblInvoice</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblInvoice</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Invoice_Id"]);
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
		/// Deletes the specified object from the <c>tblInvoice</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblInvoiceRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblInvoiceRow value)
		{
			return DeleteByPrimaryKey(value.Invoice_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblInvoice</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="invoice_Id">The <c>Invoice_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int invoice_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Invoice_Id", invoice_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblInvoice</c> table using the 
		/// <c>FK_tblInvoice_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByCompany_Id(int company_Id)
		{
			return CreateDeleteByCompany_IdCommand(company_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblInvoice_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblInvoice_DeleteBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblInvoice</c> records that match the specified criteria.
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
		/// to delete <c>tblInvoice</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblInvoice]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblInvoice</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblInvoice_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		protected tblInvoiceRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		protected tblInvoiceRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblInvoiceRow"/> objects.</returns>
		protected virtual tblInvoiceRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int invoice_IdColumnIndex = reader.GetOrdinal("Invoice_Id");
			int invoice_NoColumnIndex = reader.GetOrdinal("Invoice_No");
			int invoice_DateColumnIndex = reader.GetOrdinal("Invoice_Date");
			int vendor_IdColumnIndex = reader.GetOrdinal("Vendor_Id");
			int referenceColumnIndex = reader.GetOrdinal("Reference");
			int purchase_NoColumnIndex = reader.GetOrdinal("Purchase_No");
			int gross_TotalColumnIndex = reader.GetOrdinal("Gross_Total");
			int discountColumnIndex = reader.GetOrdinal("Discount");
			int net_TotalColumnIndex = reader.GetOrdinal("Net_Total");
			int donor_IdColumnIndex = reader.GetOrdinal("Donor_Id");
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
					tblInvoiceRow record = new tblInvoiceRow();
					recordList.Add(record);

					record.Invoice_Id = Convert.ToInt32(reader.GetValue(invoice_IdColumnIndex));
					record.Invoice_No = Convert.ToString(reader.GetValue(invoice_NoColumnIndex));
					record.Invoice_Date = Convert.ToDateTime(reader.GetValue(invoice_DateColumnIndex));
					if(!reader.IsDBNull(vendor_IdColumnIndex))
						record.Vendor_Id = Convert.ToInt32(reader.GetValue(vendor_IdColumnIndex));
					if(!reader.IsDBNull(referenceColumnIndex))
						record.Reference = Convert.ToString(reader.GetValue(referenceColumnIndex));
					if(!reader.IsDBNull(purchase_NoColumnIndex))
						record.Purchase_No = Convert.ToString(reader.GetValue(purchase_NoColumnIndex));
					record.Gross_Total = Convert.ToInt32(reader.GetValue(gross_TotalColumnIndex));
					record.Discount = Convert.ToInt32(reader.GetValue(discountColumnIndex));
					record.Net_Total = Convert.ToInt32(reader.GetValue(net_TotalColumnIndex));
					record.Donor_Id = Convert.ToInt32(reader.GetValue(donor_IdColumnIndex));
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
			return (tblInvoiceRow[])(recordList.ToArray(typeof(tblInvoiceRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblInvoiceRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblInvoiceRow"/> object.</returns>
		protected virtual tblInvoiceRow MapRow(DataRow row)
		{
			tblInvoiceRow mappedObject = new tblInvoiceRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Invoice_Id"
			dataColumn = dataTable.Columns["Invoice_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_Id = (int)row[dataColumn];
			// Column "Invoice_No"
			dataColumn = dataTable.Columns["Invoice_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_No = (string)row[dataColumn];
			// Column "Invoice_Date"
			dataColumn = dataTable.Columns["Invoice_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Invoice_Date = (System.DateTime)row[dataColumn];
			// Column "Vendor_Id"
			dataColumn = dataTable.Columns["Vendor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Vendor_Id = (int)row[dataColumn];
			// Column "Reference"
			dataColumn = dataTable.Columns["Reference"];
			if(!row.IsNull(dataColumn))
				mappedObject.Reference = (string)row[dataColumn];
			// Column "Purchase_No"
			dataColumn = dataTable.Columns["Purchase_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Purchase_No = (string)row[dataColumn];
			// Column "Gross_Total"
			dataColumn = dataTable.Columns["Gross_Total"];
			if(!row.IsNull(dataColumn))
				mappedObject.Gross_Total = (int)row[dataColumn];
			// Column "Discount"
			dataColumn = dataTable.Columns["Discount"];
			if(!row.IsNull(dataColumn))
				mappedObject.Discount = (int)row[dataColumn];
			// Column "Net_Total"
			dataColumn = dataTable.Columns["Net_Total"];
			if(!row.IsNull(dataColumn))
				mappedObject.Net_Total = (int)row[dataColumn];
			// Column "Donor_Id"
			dataColumn = dataTable.Columns["Donor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Id = (int)row[dataColumn];
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
		/// the <c>tblInvoice</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblInvoice";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Invoice_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Invoice_No", typeof(string));
			dataColumn.MaxLength = 25;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Invoice_Date", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Vendor_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("Reference", typeof(string));
			dataColumn.MaxLength = 10;
			dataColumn = dataTable.Columns.Add("Purchase_No", typeof(string));
			dataColumn.MaxLength = 25;
			dataColumn = dataTable.Columns.Add("Gross_Total", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Discount", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Net_Total", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Donor_Id", typeof(int));
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
				case "Invoice_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Invoice_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Invoice_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Vendor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Reference":
					parameter = _db.AddParameter(cmd, paramName, DbType.StringFixedLength, value);
					break;

				case "Purchase_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Gross_Total":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Discount":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Net_Total":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Donor_Id":
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
	} // End of tblInvoiceCollection_Base class
}  // End of namespace
