using MyKoloDAL.Core.Constant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyKoloDAL.Core.FileProcessing
{
    
    public class FileProcessorBase
    {
        //helps to check for all kinds of file we wanted to create, so its reusable for all forms of File(like json, msword, etc)
        //craetes a folder for us
        protected string folderName = FileConstants.DBFOLDER;
        public FileProcessorBase()
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
    }

}
