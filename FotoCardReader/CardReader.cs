using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FotoCardReader
{
    class CardReader
    {
        protected string destinationDir {get;set;}
        protected string[] fileList { get; set; }

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



        public void setFileList(string srcDrive)
        {
            this.fileList = Directory.GetFiles(srcDrive, "*.cr2", SearchOption.AllDirectories);
        }

        public string[] getFileList()
        {
            return this.fileList;
        }


        public string[] CopyFiles()
        {
            string[] allfiles;
            List<string> msg = new List<string>();

            allfiles = getFileList();
            string destFilePath = string.Empty;

            foreach (var file in allfiles)
            {
                FileInfo srcFileInfo = new FileInfo(file);
                destFilePath = this.GetDestFilePath(srcFileInfo.Name);

                

                try
                {
                    File.Copy(srcFileInfo.FullName, destFilePath);
                    if(Path.GetFileName(destFilePath) != srcFileInfo.Name)
                    msg.Add("Zmiana nazwy " + srcFileInfo.FullName + " na " + destFilePath);

                    msg.Add("kopia " + srcFileInfo.FullName + " na " + destFilePath);
                }
                catch (Exception ex)
                {
                    msg.Add(ex.Message + "  Błąd podczas kopiowania pliku " + srcFileInfo.FullName);
                }
            }
            return msg.ToArray();
        }


    }//end class
}
