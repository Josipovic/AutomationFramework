using NUnit.Framework;
using OpenQA.Selenium;
using Shared.TestCaseLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Elements
{
    public class Table : MainElement
    {
        public IWebElement Header { get; set; }
        public IWebElement HeaderRow { get; set; }

        public IWebElement Body { get; set; }
        public List<IWebElement> BodyRows { get; set; }

        public Table(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }


        /// <summary>
        /// Gets header of a table.
        /// </summary>
        /// <returns>IWebElement.</returns>
        public IWebElement GetHeader()
        {
            Element = GetElement();

            return Element.FindElement(By.TagName("thead"));
        }

        /// <summary>
        /// Gets header row of a table.
        /// </summary>
        /// <returns>IWebElement.</returns>
        public IWebElement GetHeaderRow()
        {
            return GetHeader().FindElement(By.TagName("tr"));
        }

        /// <summary>
        /// Gets body of a table.
        /// </summary>
        /// <returns>IWebElement.</returns>
        public IWebElement GetBody()
        {
            Element = GetElement();

            return Element.FindElement(By.TagName("tbody"));
        }

        /// <summary>
        /// Gets body rows of a table.
        /// </summary>
        /// <returns>List of IWebElements.</returns>
        public List<IWebElement> GetBodyRows()
        {
            return GetBody().FindElements(By.TagName("tr")).ToList();
        }


        /// <summary>
        /// Verifies if a column in table exists.
        /// </summary>
        /// <param name="ColumnName">Name of the column.</param>
        /// <param name="Exists">If set to false, verifies that the column in table does not exist. It is true by default</param>
        public void VerifyColumn(string ColumnName, bool Exists = true)
        {
            HeaderRow = GetHeaderRow();

            List<IWebElement> Rows = HeaderRow.FindElements(By.TagName("th")).ToList();

            if (Exists)
            {
                TCLogger.Log($"Verifying that the column '{ColumnName}' exists.", GetElementName());
                Assert.IsTrue(Rows.Any(x => x.Text.Contains(ColumnName)));
            }

            else
            {
                TCLogger.Log($"Verifying that the column '{ColumnName}' does not exist.", GetElementName());
                Assert.IsFalse(Rows.Any(x => x.Text.Contains(ColumnName)));
            }

        }

        /// <summary>
        /// Verifies if the table is empty.
        /// </summary>
        /// <param name="Empty">If set to false verifies that the table is not empty. It is true by default</param>
        public void VerifyEmpty(bool Empty = true)
        {
            BodyRows = GetBodyRows();

            if (Empty)
            {
                TCLogger.Log("Verifying that the table is empty.", GetElementName());
                Assert.IsTrue(BodyRows.Count == 0);
            }

            else
            {
                TCLogger.Log("Verifying that the table is not empty.", GetElementName());
                Assert.IsFalse(BodyRows.Count == 0);
            }

        }

        /// <summary>
        /// Finds cell by text.
        /// </summary>
        /// <param name="ColumnName">Name of the column.</param>
        /// <param name="CellText">Text of a cell.</param>
        /// <exception cref="Exception"></exception>
        public void FindCellByText(string ColumnName, string CellText)
        {
            HeaderRow = GetHeaderRow();
            BodyRows = GetBodyRows();

            int Cell = 1;
            bool bFoundCell = false;
            bool bCellTextEquals = false;
            List<IWebElement> HeaderRows = HeaderRow.FindElements(By.TagName("th")).ToList();


            for (int i = 0; i < HeaderRows.Count; i++)
            {
                if (HeaderRows[i].Text.Equals(ColumnName))
                {
                    Cell = i;
                    bFoundCell = true;
                    break;
                }
            }

            if (!bFoundCell)
                throw new Exception(String.Format("Cannot find column named {0}", ColumnName));

            foreach (IWebElement row in BodyRows)
            {
                List<IWebElement> DataCells = row.FindElements(By.TagName("td")).ToList();
                if (DataCells[Cell].Text.Equals(CellText))
                {
                    bCellTextEquals = true;
                    break;
                }
            }

            TCLogger.Log($"Verifying that the column '{ColumnName}' contains '{CellText}' cell.", GetElementName());
            Assert.IsTrue(bCellTextEquals);

        }

    }
}
