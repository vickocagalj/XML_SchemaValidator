using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XML_SchemaValidator
{
    public partial class Form1 : Form
    {
        private bool _valid;

        public Form1()
        {
            InitializeComponent();
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
                richTextBoxLog.Text = exception.Message;
            }
        }

        private void buttonUčitajXSD_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog xsdDialog = new OpenFileDialog();
                xsdDialog.Filter = "Schema File (*.xsd)|*.xsd|All Files (*.*)|*.*";
                xsdDialog.FilterIndex = 1;
                xsdDialog.DefaultExt = "xsd";

                if (xsdDialog.ShowDialog() == DialogResult.OK)
                    textBoxXSD.Text = xsdDialog.FileName;
            }
            catch (FileNotFoundException exception)
            {
                richTextBoxLog.Text = exception.Message;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxXML.Clear();
            textBoxXSD.Clear();
            richTextBoxLog.Clear();
        }

        private void buttonProvjeri_Click(object sender, EventArgs e)
        {
            if (textBoxXML.Text.Length == 0 || textBoxXSD.Text.Length == 0)
                richTextBoxLog.Text = "Molim učitajte XML datoteku u .xml i XSD shemu u .xsd formatu.";
            else if (Path.GetExtension(textBoxXML.Text) != ".xml")
                richTextBoxLog.Text = "Učitana datoteka nije u .xml formatu. Molim učitajte .xml datoteku.";
            else if (Path.GetExtension(textBoxXSD.Text) != ".xsd")
                richTextBoxLog.Text = "Učitana XSD shema nije u .xsd formatu. Molim učitajte .xsd shemu.";
            else
            {
                try
                {
                    _valid = true;
                    string schemaFile = textBoxXSD.Text;
                    string filename = textBoxXML.Text;

                    XmlSchemaSet schema = new XmlSchemaSet();
                    schema.Add(null, schemaFile);

                    XmlDocument document = new XmlDocument();
                    document.Schemas.Add(schema);
                    document.Load(filename);
                    
                    ValidationEventHandler eventHandler = ValidationEventHandler;
                    // the following call to Validate succeeds.
                    document.Validate(eventHandler);

                    if (_valid)
                    {
                        richTextBoxLog.ForeColor = Color.Black;
                        richTextBoxLog.Text = "OK";
                    }
                }
                catch (XmlException exception)
                {
                    richTextBoxLog.ForeColor = Color.Red;
                    richTextBoxLog.Text = $"Incorrect XML file:\n\n";
                    richTextBoxLog.AppendText(exception.Message, Color.Black);
                }
                catch (XmlSchemaException exception)
                {
                    richTextBoxLog.ForeColor = Color.Red;
                    richTextBoxLog.Text = $"Incorrect XSD schema file:\n\n{exception.Message}";
                    richTextBoxLog.AppendText(exception.Message, Color.Black);
                }
            }
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            _valid = false;
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    richTextBoxLog.ForeColor = Color.Red;
                    richTextBoxLog.Text = $"Validation Error:\n\n";
                    richTextBoxLog.AppendText(e.Message, Color.Black);
                    break;

                case XmlSeverityType.Warning:
                    richTextBoxLog.Text = $"Validation Warning:\n\n {e.Message}";
                    richTextBoxLog.ForeColor = Color.Yellow;
                    break;
            }
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
