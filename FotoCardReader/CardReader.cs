using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FotoCardReader
{
    public class CardReader
    {
        private string fileType = "*.cr2";
        private string[] srcFileList, srcDirList;


        public string SrcDir { get;}
        public string DestDir { get;}
        public int CopyProgress { get; private set; }
        public int CurrFileNo { get; private set; }
        public int ObjNo { get; set; }


        public CardReader()
        {
        }

        public CardReader(string srcDir, string destDir)
        {
            this.SrcDir = srcDir;
            this.DestDir = destDir;
            this.CopyProgress = 0;
            this.CurrFileNo = 1;
            SetSrcFileList();
        }

        private void SetSrcFileList()
        {
            this.srcFileList = Directory.GetFiles(this.SrcDir, this.fileType, SearchOption.AllDirectories);
        }

        public string[] GetSrcFileList()
        {
            return this.srcFileList;
        }

        protected string GetDestFilePath(string fileName)
        {
            string destDirPath = this.DestDir + "\\";
            string destFilePath = destDirPath + Path.GetFileName(fileName);

            FileInfo destFileInfo = new FileInfo(destFilePath);

            if (destFileInfo.Exists)
            {
                destFilePath = destDirPath + Path.GetFileNameWithoutExtension(destFilePath) + "_1" + Path.GetExtension(destFilePath);
                destFilePath = GetDestFilePath(Path.GetFileName(destFilePath));
            }

            return destFilePath;
        }

        public void SetAllSrcDirList()
        {
            var allDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            string[] result = new string[allDrives.Count()];
            int i = 0;
            foreach (DriveInfo d in allDrives)
            {
                result[i] = d.Name;
                i++;
            }
            this.srcDirList = result;
        }

        public string[] GetSrcDirList()
        {
            return this.srcDirList;
        }

        public string CopyFile(string srcFile)
        {
            string info = string.Empty;
            string destFilePath = string.Empty;

            destFilePath = this.GetDestFilePath(srcFile);

            
            this.CopyProgress = (this.CurrFileNo * 100) / srcFileList.Length;


            try
            {
                File.Copy(srcFile, destFilePath);
                if (Path.GetFileName(destFilePath) != srcFile)
                    info = "Zmiana nazwy " + srcFile + " na " + destFilePath;

                info = this.CurrFileNo + " z " + srcFileList.Length + " ("+ this.CopyProgress+"%) Skopiowano " + srcFile + " do " + destFilePath;
            }
            catch (Exception ex)
            {
                info = ex.Message + "  Błąd podczas kopiowania pliku " + srcFile;
            }

            this.CurrFileNo++;

            return info;
        }







    }//end class
}
