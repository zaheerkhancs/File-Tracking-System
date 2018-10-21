// <fileinfo name="tblGeneral_JournalCollection_Base.cs">
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
	/// The base class for <see cref="tblGeneral_JournalCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblGeneral_JournalCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblGeneral_JournalCollection_Base
	{
		// Constants
		public const string GL_IdColumnName = "GL_Id";
		public const string GL_DateColumnName = "GL_Date";
		public const string ReferenceColumnName = "Reference";
		public const string GL_Act_IdColumnName = "GL_Act_Id";
		public const string DebitColumnName = "Debit";
		public const string CreditColumnName = "Credit";
		public const string Donor_IdColumnName = "Donor_Id";
		public const string Company_IdColumnName = "Company_Id";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblGeneral_JournalCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblGeneral_JournalCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		public virtual tblGeneral_JournalRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblGeneral_Journal_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblGeneral_JournalRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblGeneral_JournalRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblGeneral_JournalRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblGeneral_JournalRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblGeneral_JournalRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		public tblGeneral_JournalRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblGeneral_JournalRow"/> objects that 
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
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		public virtual tblGeneral_JournalRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblGeneral_Journal]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblGeneral_JournalRow"/> by the primary key.
		/// </summary>
		/// <param name="gL_Id">The <c>GL_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblGeneral_JournalRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblGeneral_JournalRow GetByPrimaryKey(int gL_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_GetByPrimaryKey", true);
			AddParameter(cmd, "GL_Id", gL_Id);
			tblGeneral_JournalRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblGeneral_JournalRow"/> objects 
		/// by the <c>FK_tblGeneral_Journal_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		public virtual tblGeneral_JournalRow[] GetByCompany_Id(int company_Id)
		{
			return MapRecords(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblGeneral_Journal_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByCompany_IdAsDataTable(int company_Id)
		{
			return MapRecordsToDataTable(CreateGetByCompany_IdCommand(company_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblGeneral_Journal_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_GetBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblGeneral_JournalRow"/> objects 
		/// by the <c>FK_tblGeneral_Journal_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		public virtual tblGeneral_JournalRow[] GetByGL_Act_Id(int gL_Act_Id)
		{
			return MapRecords(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblGeneral_Journal_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByGL_Act_IdAsDataTable(int gL_Act_Id)
		{
			return MapRecordsToDataTable(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblGeneral_Journal_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_GetBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblGeneral_JournalRow"/> object to be inserted.</param>
		public virtual void Insert(tblGeneral_JournalRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_Insert", true);
			AddParameter(cmd, "GL_Date", value.GL_Date);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Debit", value.Debit);
			AddParameter(cmd, "Credit", value.Credit);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			value.GL_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblGeneral_JournalRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblGeneral_JournalRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_Update", true);
			AddParameter(cmd, "GL_Date", value.GL_Date);
			AddParameter(cmd, "Reference", value.Reference);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Debit", value.Debit);
			AddParameter(cmd, "Credit", value.Credit);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			AddParameter(cmd, "Company_Id", value.Company_Id);
			AddParameter(cmd, "GL_Id", value.GL_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblGeneral_Journal</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblGeneral_Journal</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["GL_Id"]);
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
		/// Deletes the specified object from the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblGeneral_JournalRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblGeneral_JournalRow value)
		{
			return DeleteByPrimaryKey(value.GL_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblGeneral_Journal</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="gL_Id">The <c>GL_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int gL_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_DeleteByPrimaryKey", true);
			AddParameter(cmd, "GL_Id", gL_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblGeneral_Journal</c> table using the 
		/// <c>FK_tblGeneral_Journal_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByCompany_Id(int company_Id)
		{
			return CreateDeleteByCompany_IdCommand(company_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblGeneral_Journal_tblcompany</c> foreign key.
		/// </summary>
		/// <param name="company_Id">The <c>Company_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByCompany_IdCommand(int company_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_DeleteBy_Company_Id", true);
			AddParameter(cmd, "Company_Id", company_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblGeneral_Journal</c> table using the 
		/// <c>FK_tblGeneral_Journal_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByGL_Act_Id(int gL_Act_Id)
		{
			return CreateDeleteByGL_Act_IdCommand(gL_Act_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblGeneral_Journal_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblGeneral_Journal_DeleteBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblGeneral_Journal</c> records that match the specified criteria.
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
		/// to delete <c>tblGeneral_Journal</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblGeneral_Journal]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblGeneral_Journal_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		protected tblGeneral_JournalRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		protected tblGeneral_JournalRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblGeneral_JournalRow"/> objects.</returns>
		protected virtual tblGeneral_JournalRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int gL_IdColumnIndex = reader.GetOrdinal("GL_Id");
			int gL_DateColumnIndex = reader.GetOrdinal("GL_Date");
			int referenceColumnIndex = reader.GetOrdinal("Reference");
			int gL_Act_IdColumnIndex = reader.GetOrdinal("GL_Act_Id");
			int debitColumnIndex = reader.GetOrdinal("Debit");
			int creditColumnIndex = reader.GetOrdinal("Credit");
			int donor_IdColumnIndex = reader.GetOrdinal("Donor_Id");
			int company_IdColumnIndex = reader.GetOrdinal("Company_Id");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblGeneral_JournalRow record = new tblGeneral_JournalRow();
					recordList.Add(record);

					record.GL_Id = Convert.ToInt32(reader.GetValue(gL_IdColumnIndex));
					record.GL_Date = Convert.ToDateTime(reader.GetValue(gL_DateColumnIndex));
					if(!reader.IsDBNull(referenceColumnIndex))
						record.Reference = Convert.ToString(reader.GetValue(referenceColumnIndex));
					record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));
					record.Debit = Convert.ToInt32(reader.GetValue(debitColumnIndex));
					record.Credit = Convert.ToInt32(reader.GetValue(creditColumnIndex));
					record.Donor_Id = Convert.ToInt32(reader.GetValue(donor_IdColumnIndex));
					record.Company_Id = Convert.ToInt32(reader.GetValue(company_IdColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblGeneral_JournalRow[])(recordList.ToArray(typeof(tblGeneral_JournalRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblGeneral_JournalRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblGeneral_JournalRow"/> object.</returns>
		protected virtual tblGeneral_JournalRow MapRow(DataRow row)
		{
			tblGeneral_JournalRow mappedObject = new tblGeneral_JournalRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "GL_Id"
			dataColumn = dataTable.Columns["GL_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Id = (int)row[dataColumn];
			// Column "GL_Date"
			dataColumn = dataTable.Columns["GL_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Date = (System.DateTime)row[dataColumn];
			// Column "Reference"
			dataColumn = dataTable.Columns["Reference"];
			if(!row.IsNull(dataColumn))
				mappedObject.Reference = (string)row[dataColumn];
			// Column "GL_Act_Id"
			dataColumn = dataTable.Columns["GL_Act_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Act_Id = (int)row[dataColumn];
			// Column "Debit"
			dataColumn = dataTable.Columns["Debit"];
			if(!row.IsNull(dataColumn))
				mappedObject.Debit = (int)row[dataColumn];
			// Column "Credit"
			dataColumn = dataTable.Columns["Credit"];
			if(!row.IsNull(dataColumn))
				mappedObject.Credit = (int)row[dataColumn];
			// Column "Donor_Id"
			dataColumn = dataTable.Columns["Donor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Id = (int)row[dataColumn];
			// Column "Company_Id"
			dataColumn = dataTable.Columns["Company_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Company_Id = (int)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblGeneral_Journal";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("GL_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("GL_Date", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Reference", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Debit", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Credit", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Donor_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Company_Id", typeof(int));
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
				case "GL_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "GL_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Reference":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "GL_Act_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Debit":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Credit":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Donor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Company_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblGeneral_JournalCollection_Base class
}  // End of namespace
