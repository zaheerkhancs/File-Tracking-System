// <fileinfo name="FMSDB_Base.cs">
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
	/// The base class for the <see cref="FMSDB"/> class that 
	/// represents a connection to the <c>FMSDB</c> database. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Modify the FMSDB class
	/// if you need to add or change some functionality.
	/// </remarks>
	public abstract class FMSDB_Base : IDisposable
	{
		private IDbConnection _connection;
		private IDbTransaction _transaction;

		// Table and view fields
		private tblBudgetCollection _tblBudget;
		private tblcompanyCollection _tblcompany;
		private tblCurrencyCollection _tblCurrency;
		private tblDonorCollection _tblDonor;
		private tblDonor_ContactCollection _tblDonor_Contact;
		private tblDonor_TypeCollection _tblDonor_Type;
		private tblExchange_RateCollection _tblExchange_Rate;
		private tblFundCollection _tblFund;
		private tblGeneral_JournalCollection _tblGeneral_Journal;
		private tblGL_AccountCollection _tblGL_Account;
		private tblGL_Act_TypeCollection _tblGL_Act_Type;
		private tblInvoiceCollection _tblInvoice;
		private tblInvoice_DetailCollection _tblInvoice_Detail;
		private tblItemCollection _tblItem;
        private tblItem_TypeCollection _tblItem_Type;
        private tblPaymentCollection _tblPayment;
        private tblRecentLogCollection _tblRecentLog;
        private tblRoleCollection _tblRole;
        private tblUsersCollection _tblUsers;
        private tblVendorCollection _tblVendor;
        private tblVendor_TypeCollection _tblVendor_Type;

		/// <summary>
		/// Initializes a new instance of the <see cref="FMSDB_Base"/> 
		/// class and opens the database connection.
		/// </summary>
		protected FMSDB_Base() : this(true)
		{
			// EMPTY
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FMSDB_Base"/> class.
		/// </summary>
		/// <param name="init">Specifies whether the constructor calls the
		/// <see cref="InitConnection"/> method to initialize the database connection.</param>
		protected FMSDB_Base(bool init)
		{
			if(init)
				InitConnection();
		}

		/// <summary>
		/// Initializes the database connection.
		/// </summary>
		protected void InitConnection()
		{
			_connection = CreateConnection();
			_connection.Open();
		}

		/// <summary>
		/// Creates a new connection to the database.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbConnection"/> object.</returns>
		protected abstract IDbConnection CreateConnection();

		/// <summary>
		/// Returns a SQL statement parameter name that is specific for the data provider.
		/// For example it returns ? for OleDb provider, or @paramName for MS SQL provider.
		/// </summary>
		/// <param name="paramName">The data provider neutral SQL parameter name.</param>
		/// <returns>The SQL statement parameter name.</returns>
		protected internal abstract string CreateSqlParameterName(string paramName);

		/// <summary>
		/// Creates <see cref="System.Data.IDataReader"/> for the specified DB command.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.IDataReader"/> object.</returns>
		protected internal virtual IDataReader ExecuteReader(IDbCommand command)
		{
			return command.ExecuteReader();
		}

		/// <summary>
		/// Adds a new parameter to the specified command. It is not recommended that 
		/// you use this method directly from your custom code. Instead use the 
		/// <c>AddParameter</c> method of the &lt;TableCodeName&gt;Collection_Base classes.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="dbType">One of the <see cref="System.Data.DbType"/> values. </param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		internal IDbDataParameter AddParameter(IDbCommand cmd, string paramName,
												DbType dbType, object value)
		{
			IDbDataParameter parameter = cmd.CreateParameter();
			parameter.ParameterName = CreateCollectionParameterName(paramName);
			parameter.DbType = dbType;
			parameter.Value = null == value ? DBNull.Value : value;
			cmd.Parameters.Add(parameter);
			return parameter;
		}
		
		/// <summary>
		/// Creates a .Net data provider specific name that is used by the 
		/// <see cref="AddParameter"/> method.
		/// </summary>
		/// <param name="baseParamName">The base name of the parameter.</param>
		/// <returns>The full data provider specific parameter name.</returns>
		protected abstract string CreateCollectionParameterName(string baseParamName);

		/// <summary>
		/// Gets <see cref="System.Data.IDbConnection"/> associated with this object.
		/// </summary>
		/// <value>A reference to the <see cref="System.Data.IDbConnection"/> object.</value>
		public IDbConnection Connection
		{
			get { return _connection; }
		}

		/// <summary>
		/// Gets an object that represents the <c>tblBudget</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblBudgetCollection"/> object.</value>
		public tblBudgetCollection tblBudgetCollection
		{
			get
			{
				if(null == _tblBudget)
					_tblBudget = new tblBudgetCollection((FMSDB)this);
				return _tblBudget;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblcompany</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblcompanyCollection"/> object.</value>
		public tblcompanyCollection tblcompanyCollection
		{
			get
			{
				if(null == _tblcompany)
					_tblcompany = new tblcompanyCollection((FMSDB)this);
				return _tblcompany;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblCurrency</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblCurrencyCollection"/> object.</value>
		public tblCurrencyCollection tblCurrencyCollection
		{
			get
			{
				if(null == _tblCurrency)
					_tblCurrency = new tblCurrencyCollection((FMSDB)this);
				return _tblCurrency;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblDonor</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblDonorCollection"/> object.</value>
		public tblDonorCollection tblDonorCollection
		{
			get
			{
				if(null == _tblDonor)
					_tblDonor = new tblDonorCollection((FMSDB)this);
				return _tblDonor;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblDonor_Contact</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblDonor_ContactCollection"/> object.</value>
		public tblDonor_ContactCollection tblDonor_ContactCollection
		{
			get
			{
				if(null == _tblDonor_Contact)
					_tblDonor_Contact = new tblDonor_ContactCollection((FMSDB)this);
				return _tblDonor_Contact;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblDonor_Type</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblDonor_TypeCollection"/> object.</value>
		public tblDonor_TypeCollection tblDonor_TypeCollection
		{
			get
			{
				if(null == _tblDonor_Type)
					_tblDonor_Type = new tblDonor_TypeCollection((FMSDB)this);
				return _tblDonor_Type;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblExchange_RateCollection"/> object.</value>
		public tblExchange_RateCollection tblExchange_RateCollection
		{
			get
			{
				if(null == _tblExchange_Rate)
					_tblExchange_Rate = new tblExchange_RateCollection((FMSDB)this);
				return _tblExchange_Rate;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblFund</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblFundCollection"/> object.</value>
		public tblFundCollection tblFundCollection
		{
			get
			{
				if(null == _tblFund)
					_tblFund = new tblFundCollection((FMSDB)this);
				return _tblFund;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblGeneral_Journal</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblGeneral_JournalCollection"/> object.</value>
		public tblGeneral_JournalCollection tblGeneral_JournalCollection
		{
			get
			{
				if(null == _tblGeneral_Journal)
					_tblGeneral_Journal = new tblGeneral_JournalCollection((FMSDB)this);
				return _tblGeneral_Journal;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblGL_Account</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblGL_AccountCollection"/> object.</value>
		public tblGL_AccountCollection tblGL_AccountCollection
		{
			get
			{
				if(null == _tblGL_Account)
					_tblGL_Account = new tblGL_AccountCollection((FMSDB)this);
				return _tblGL_Account;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblGL_Act_Type</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblGL_Act_TypeCollection"/> object.</value>
		public tblGL_Act_TypeCollection tblGL_Act_TypeCollection
		{
			get
			{
				if(null == _tblGL_Act_Type)
					_tblGL_Act_Type = new tblGL_Act_TypeCollection((FMSDB)this);
				return _tblGL_Act_Type;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblInvoice</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblInvoiceCollection"/> object.</value>
		public tblInvoiceCollection tblInvoiceCollection
		{
			get
			{
				if(null == _tblInvoice)
					_tblInvoice = new tblInvoiceCollection((FMSDB)this);
				return _tblInvoice;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblInvoice_Detail</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblInvoice_DetailCollection"/> object.</value>
		public tblInvoice_DetailCollection tblInvoice_DetailCollection
		{
			get
			{
				if(null == _tblInvoice_Detail)
					_tblInvoice_Detail = new tblInvoice_DetailCollection((FMSDB)this);
				return _tblInvoice_Detail;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblItem</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblItemCollection"/> object.</value>
		public tblItemCollection tblItemCollection
		{
			get
			{
				if(null == _tblItem)
					_tblItem = new tblItemCollection((FMSDB)this);
				return _tblItem;
			}
		}

        /// <summary>
        /// Gets an object that represents the <c>tblItem_Type</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblItem_TypeCollection"/> object.</value>
        public tblItem_TypeCollection tblItem_TypeCollection
        {
            get
            {
                if (null == _tblItem_Type)
                    _tblItem_Type = new tblItem_TypeCollection((FMSDB)this);
                return _tblItem_Type;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblPayment</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblPaymentCollection"/> object.</value>
        public tblPaymentCollection tblPaymentCollection
        {
            get
            {
                if (null == _tblPayment)
                    _tblPayment = new tblPaymentCollection((FMSDB)this);
                return _tblPayment;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblRecentLog</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblRecentLogCollection"/> object.</value>
        public tblRecentLogCollection tblRecentLogCollection
        {
            get
            {
                if (null == _tblRecentLog)
                    _tblRecentLog = new tblRecentLogCollection((FMSDB)this);
                return _tblRecentLog;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblRole</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblRoleCollection"/> object.</value>
        public tblRoleCollection tblRoleCollection
        {
            get
            {
                if (null == _tblRole)
                    _tblRole = new tblRoleCollection((FMSDB)this);
                return _tblRole;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblUsers</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblUsersCollection"/> object.</value>
        public tblUsersCollection tblUsersCollection
        {
            get
            {
                if (null == _tblUsers)
                    _tblUsers = new tblUsersCollection((FMSDB)this);
                return _tblUsers;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblVendor</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblVendorCollection"/> object.</value>
        public tblVendorCollection tblVendorCollection
        {
            get
            {
                if (null == _tblVendor)
                    _tblVendor = new tblVendorCollection((FMSDB)this);
                return _tblVendor;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblVendor_Type</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblVendor_TypeCollection"/> object.</value>
        public tblVendor_TypeCollection tblVendor_TypeCollection
        {
            get
            {
                if (null == _tblVendor_Type)
                    _tblVendor_Type = new tblVendor_TypeCollection((FMSDB)this);
                return _tblVendor_Type;
            }
        }


		/// <summary>
		/// Begins a new database transaction.
		/// </summary>
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction()
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction();
			return _transaction;
		}

		/// <summary>
		/// Begins a new database transaction with the specified 
		/// transaction isolation level.
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		/// <param name="isolationLevel">The transaction isolation level.</param>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction(isolationLevel);
			return _transaction;
		}

		/// <summary>
		/// Commits the current database transaction.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		public void CommitTransaction()
		{
			CheckTransactionState(true);
			_transaction.Commit();
			_transaction = null;
		}

		/// <summary>
		/// Rolls back the current transaction from a pending state.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="CommitTransaction"/>
		/// </summary>
		public void RollbackTransaction()
		{
			CheckTransactionState(true);
			_transaction.Rollback();
			_transaction = null;
		}

		// Checks the state of the current transaction
		private void CheckTransactionState(bool mustBeOpen)
		{
			if(mustBeOpen)
			{
				if(null == _transaction)
					throw new InvalidOperationException("Transaction is not open.");
			}
			else
			{
				if(null != _transaction)
					throw new InvalidOperationException("Transaction is already open.");
			}
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText)
		{
			return CreateCommand(sqlText, false);
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <param name="procedure">Specifies whether the sqlText parameter is 
		/// the name of a stored procedure.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText, bool procedure)
		{
			IDbCommand cmd = _connection.CreateCommand();
			cmd.CommandText = sqlText;
			cmd.Transaction = _transaction;
			if(procedure)
				cmd.CommandType = CommandType.StoredProcedure;
			return cmd;
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// An application can call the <c>Close</c> method more than
		/// one time without generating an exception.
		/// </summary>
		public virtual void Close()
		{
			if(null != _connection)
				_connection.Close();
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// </summary>
		public virtual void Dispose()
		{
			Close();
			if(null != _connection)
				_connection.Dispose();
		}
	} // End of FMSDB_Base class
} // End of namespace
