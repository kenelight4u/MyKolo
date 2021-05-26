using MyKoloDAL.Core.FileProcessing.Interfaces;
using MyKoloDAL.Core;
using System;
using System.Collections.Generic;
using System.Text;
using IronXL;
using System.IO;
using MyKoloDAL.Core.Constant;

namespace MyKoloDAL.Core.FileProcessing.ExcelFileProcessing
{
    public class ExcelFileProcessor : FileProcessorBase, IFileProcessor
    {
        private WorkBook dbFile;

        private string dBFileName = "MyKoloDb.xls";

        public ExcelFileProcessor():base()
        {
            if (!File.Exists(Path.Combine(folderName, dBFileName)))
            {
                //Create new Excel WorkBook document. 
                //The default file format is XLSX, but we can override that for legacy support

                this.dbFile = WorkBook.Create(ExcelFileFormat.XLS);
                dbFile.Metadata.Author = "SBSC Ekene";

                //Add a blank WorkSheet
                WorkSheet SavingsTable = dbFile.CreateWorkSheet("Saving");
                WorkSheet ExpenseTable = dbFile.CreateWorkSheet("Expense");
                //Add data and styles to the new worksheet
                SavingsTable["A1"].Value = "Id";
                SavingsTable["B1"].Value = "CreatedDateTime";
                SavingsTable["C1"].Value = "Amount";
                SavingsTable["D1"].Value = "Description";

                ExpenseTable["A1"].Value = "Id";
                ExpenseTable["B1"].Value = "CreatedDateTime";
                ExpenseTable["C1"].Value = "Amount";
                ExpenseTable["D1"].Value = "Description";

                dbFile.Save();

            }
            

        }
        public bool ReadFromFile()
        {
            return false;
        }

        public bool WriteToFile()
        {
            return false;
        }
    }
}
