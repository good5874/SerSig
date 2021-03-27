using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerSig.CustomNetCoreServer
{
    public class TBStreamWriterConnect : TextWriter
    {
        TextBox _output = null;
        public TBStreamWriterConnect(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);

            _output.BeginInvoke((MethodInvoker)(() =>
            {
                _output.AppendText(value.ToString()); // Когда символ записывается в поток, добавляем его в textbox.
            }));
        }
        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
