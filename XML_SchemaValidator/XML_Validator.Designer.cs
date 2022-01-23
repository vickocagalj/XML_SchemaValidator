
namespace XML_SchemaValidator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelXML = new System.Windows.Forms.Label();
            this.textBoxXML = new System.Windows.Forms.TextBox();
            this.buttonUčitajXML = new System.Windows.Forms.Button();
            this.buttonUčitajXSD = new System.Windows.Forms.Button();
            this.textBoxXSD = new System.Windows.Forms.TextBox();
            this.label_XSD = new System.Windows.Forms.Label();
            this.buttonProvjeri = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelXML
            // 
            this.labelXML.AutoSize = true;
            this.labelXML.Location = new System.Drawing.Point(87, 59);
            this.labelXML.Name = "labelXML";
            this.labelXML.Size = new System.Drawing.Size(150, 17);
            this.labelXML.TabIndex = 0;
            this.labelXML.Text = "Učitajte XML datoteku:";
            // 
            // textBoxXML
            // 
            this.textBoxXML.Location = new System.Drawing.Point(243, 56);
            this.textBoxXML.Name = "textBoxXML";
            this.textBoxXML.Size = new System.Drawing.Size(373, 22);
            this.textBoxXML.TabIndex = 1;
            // 
            // buttonUčitajXML
            // 
            this.buttonUčitajXML.Location = new System.Drawing.Point(622, 52);
            this.buttonUčitajXML.Name = "buttonUčitajXML";
            this.buttonUčitajXML.Size = new System.Drawing.Size(95, 31);
            this.buttonUčitajXML.TabIndex = 2;
            this.buttonUčitajXML.Text = "Učitaj...";
            this.buttonUčitajXML.UseVisualStyleBackColor = true;
            this.buttonUčitajXML.Click += new System.EventHandler(this.buttonUčitajXML_Click);
            // 
            // buttonUčitajXSD
            // 
            this.buttonUčitajXSD.Location = new System.Drawing.Point(622, 100);
            this.buttonUčitajXSD.Name = "buttonUčitajXSD";
            this.buttonUčitajXSD.Size = new System.Drawing.Size(95, 31);
            this.buttonUčitajXSD.TabIndex = 5;
            this.buttonUčitajXSD.Text = "Učitaj...";
            this.buttonUčitajXSD.UseVisualStyleBackColor = true;
            this.buttonUčitajXSD.Click += new System.EventHandler(this.buttonUčitajXSD_Click);
            // 
            // textBoxXSD
            // 
            this.textBoxXSD.Location = new System.Drawing.Point(243, 104);
            this.textBoxXSD.Name = "textBoxXSD";
            this.textBoxXSD.Size = new System.Drawing.Size(373, 22);
            this.textBoxXSD.TabIndex = 4;
            // 
            // label_XSD
            // 
            this.label_XSD.AutoSize = true;
            this.label_XSD.Location = new System.Drawing.Point(87, 107);
            this.label_XSD.Name = "label_XSD";
            this.label_XSD.Size = new System.Drawing.Size(137, 17);
            this.label_XSD.TabIndex = 3;
            this.label_XSD.Text = "Učitajte XSD shemu:";
            // 
            // buttonProvjeri
            // 
            this.buttonProvjeri.Location = new System.Drawing.Point(305, 144);
            this.buttonProvjeri.Name = "buttonProvjeri";
            this.buttonProvjeri.Size = new System.Drawing.Size(94, 28);
            this.buttonProvjeri.TabIndex = 6;
            this.buttonProvjeri.Text = "Provjeri";
            this.buttonProvjeri.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(405, 144);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 28);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(90, 189);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(627, 228);
            this.richTextBoxLog.TabIndex = 8;
            this.richTextBoxLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonProvjeri);
            this.Controls.Add(this.buttonUčitajXSD);
            this.Controls.Add(this.textBoxXSD);
            this.Controls.Add(this.label_XSD);
            this.Controls.Add(this.buttonUčitajXML);
            this.Controls.Add(this.textBoxXML);
            this.Controls.Add(this.labelXML);
            this.Name = "Form1";
            this.Text = "XML Schema Validation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelXML;
        private System.Windows.Forms.TextBox textBoxXML;
        private System.Windows.Forms.Button buttonUčitajXML;
        private System.Windows.Forms.Button buttonUčitajXSD;
        private System.Windows.Forms.TextBox textBoxXSD;
        private System.Windows.Forms.Label label_XSD;
        private System.Windows.Forms.Button buttonProvjeri;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
    }
}

