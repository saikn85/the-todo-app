﻿using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace OneHasToDoThings.DB.Tests
{
    [TestClass()]
    public class InsertTodoTests : SqlDatabaseTestClass
    {

        public InsertTodoTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_InsertToDo_Success_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTodoTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            this.dbo_InsertToDo_SuccessData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_InsertToDo_Success_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // dbo_InsertToDo_Success_TestAction
            // 
            dbo_InsertToDo_Success_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(dbo_InsertToDo_Success_TestAction, "dbo_InsertToDo_Success_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // dbo_InsertToDo_SuccessData
            // 
            this.dbo_InsertToDo_SuccessData.PosttestAction = null;
            this.dbo_InsertToDo_SuccessData.PretestAction = null;
            this.dbo_InsertToDo_SuccessData.TestAction = dbo_InsertToDo_Success_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_InsertToDo_Success()
        {
            SqlDatabaseTestActions testActions = this.dbo_InsertToDo_SuccessData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_InsertToDo_SuccessData;
    }
}
