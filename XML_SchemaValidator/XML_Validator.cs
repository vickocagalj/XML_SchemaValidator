using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_SchemaValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUčitajXML_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog xmlDialog = new OpenFileDialog();
                xmlDialog.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
                xmlDialog.FilterIndex = 1;
                xmlDialog.DefaultExt = "xml";

                if (xmlDialog.ShowDialog() == DialogResult.OK)
                    textBoxXML.Text = xmlDialog.FileName;
            }
            catch (FileLoadException exception)
            {
                richTextBoxLog.AppendText(exception.Message);
            }
        }

        private void buttonUčitajXSD_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog xsdDialog = new OpenFileDialog();
                xsdDialog.Filter = "Schema File (*.xsd)|*.xsd|All Files (*.*)|*.*";
                xsdDialog.FilterIndex = 1;
                xsdDialog.DefaultExt = "xml";

                if (xsdDialog.ShowDialog() == DialogResult.OK)
                    textBoxXML.Text = xsdDialog.FileName;
            }
            catch (FileLoadException exception)
            {
                richTextBoxLog.AppendText(exception.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxXML.Clear();
            textBoxXSD.Clear();
        }
    }
}
