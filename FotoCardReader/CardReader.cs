using System;
using System.IO;
using System.Linq;

namespace FotoCardReader
{
    class CardReader
    {
        protected string destinationDir {get;set;}

        public CardReader()
        {

        }

        public string getDestinationDir()
        {
            return this.destinationDir;
        }

        public void setDestinationDir(string destinationDir)
        {
            this.destinationDir = destinationDir;
        }


        public string[] ListDrive()
        {
            var allDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            string[] result = new string[allDrives.Count()];
            int i = 0;
            foreach (DriveInfo d in allDrives)
            {
                result[i] = d.Name;
                i++;
            }
            return result;
        }

        public string GetDestFilePath(string fileName)
        {
            string destDirPath = this.destinationDir + "\\";
            string destFilePath = destDirPath + fileName;

            FileInfo destFileInfo = new FileInfo(destFilePath);

            if (destFileInfo.Exists)
            {
                destFilePath = destDirPath + Path.GetFileNameWithoutExtension(destFilePath) + "_1" + Path.GetExtension(destFilePath);
                destFilePath = GetDestFilePath(Path.GetFileName(destFilePath));
            }

            return destFilePath;
        }

        public void CopyFiles(string[] drives)
        {
            string[] allfiles;
            string msg = string.Empty;

            foreach (var drive in drives)
            {
                allfiles = Directory.GetFiles(drive, "*.cr2", SearchOption.AllDirectories);
                string destFilePath = string.Empty;


                foreach (var file in allfiles)
                {
                    FileInfo srcFileInfo = new FileInfo(file);
                    destFilePath = this.GetDestFilePath(srcFileInfo.Name);

                    try
                    {
                        srcFileInfo.CopyTo(destFilePath);
                    }
                    catch (Exception ex)
                    {

                        msg = ex.Message + "  Błąd podczas kopiowania pliku " + srcFileInfo.FullName;
                       // MainForm.txtResultInfo.AppendText(msg + Environment.NewLine);
                    }

                }
            }
        }


    }//end class
}
