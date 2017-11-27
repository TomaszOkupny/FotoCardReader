using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FotoCardReader
{
    public  class LogInfo
    {

        public LogInfo()
        {

        }

        public void AddResultInfo(TextBox textBox, string info)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(delegate ()
                {
                    textBox.AppendText(info + Environment.NewLine);
                }));
            }
            else
            {
                textBox.AppendText(info + Environment.NewLine);
            } 
        }

        public void SetProgressBarValue(ProgressBar ctrlName, int value)
        {
                ctrlName.Invoke(new Action(delegate ()
                {
                    ctrlName.Value = value;
                }));
        }

    }
}
