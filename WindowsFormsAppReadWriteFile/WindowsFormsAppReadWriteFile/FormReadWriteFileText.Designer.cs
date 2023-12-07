namespace WindowsFormsAppReadWriteFile
{
    partial class FormReadWriteFileText
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
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWriteJson = new System.Windows.Forms.Button();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnWriteXml = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.grdFileCsvXlsXlxs = new System.Windows.Forms.DataGridView();
            this.btnWriteCsv = new System.Windows.Forms.Button();
            this.btnReadCsv = new System.Windows.Forms.Button();
            this.BtnWriteXls = new System.Windows.Forms.Button();
            this.btnReadExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFileCsvXlsXlxs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(12, 12);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(268, 106);
            this.txtDetail.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(286, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(99, 40);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(286, 58);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(99, 40);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWriteJson
            // 
            this.btnWriteJson.Location = new System.Drawing.Point(12, 231);
            this.btnWriteJson.Name = "btnWriteJson";
            this.btnWriteJson.Size = new System.Drawing.Size(99, 40);
            this.btnWriteJson.TabIndex = 3;
            this.btnWriteJson.Text = "WriteJson";
            this.btnWriteJson.UseVisualStyleBackColor = true;
            this.btnWriteJson.Click += new System.EventHandler(this.btnWriteJson_Click);
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(117, 231);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(99, 40);
            this.btnReadJson.TabIndex = 4;
            this.btnReadJson.Text = "ReadJson";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 137);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(147, 26);
            this.txtId.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 140);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 26);
            this.txtName.TabIndex = 8;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 196);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(69, 199);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(147, 26);
            this.txtAge.TabIndex = 10;
            // 
            // btnWriteXml
            // 
            this.btnWriteXml.Location = new System.Drawing.Point(222, 137);
            this.btnWriteXml.Name = "btnWriteXml";
            this.btnWriteXml.Size = new System.Drawing.Size(99, 40);
            this.btnWriteXml.TabIndex = 11;
            this.btnWriteXml.Text = "WriteXml";
            this.btnWriteXml.UseVisualStyleBackColor = true;
            this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(222, 183);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(99, 40);
            this.btnReadXml.TabIndex = 12;
            this.btnReadXml.Text = "ReadXml";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // grdFileCsvXlsXlxs
            // 
            this.grdFileCsvXlsXlxs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFileCsvXlsXlxs.Location = new System.Drawing.Point(404, 10);
            this.grdFileCsvXlsXlxs.Name = "grdFileCsvXlsXlxs";
            this.grdFileCsvXlsXlxs.RowHeadersWidth = 62;
            this.grdFileCsvXlsXlxs.RowTemplate.Height = 28;
            this.grdFileCsvXlsXlxs.Size = new System.Drawing.Size(532, 309);
            this.grdFileCsvXlsXlxs.TabIndex = 13;
            // 
            // btnWriteCsv
            // 
            this.btnWriteCsv.Location = new System.Drawing.Point(404, 325);
            this.btnWriteCsv.Name = "btnWriteCsv";
            this.btnWriteCsv.Size = new System.Drawing.Size(99, 40);
            this.btnWriteCsv.TabIndex = 14;
            this.btnWriteCsv.Text = "WriteCsv";
            this.btnWriteCsv.UseVisualStyleBackColor = true;
            this.btnWriteCsv.Click += new System.EventHandler(this.btnWriteCsv_Click);
            // 
            // btnReadCsv
            // 
            this.btnReadCsv.Location = new System.Drawing.Point(509, 325);
            this.btnReadCsv.Name = "btnReadCsv";
            this.btnReadCsv.Size = new System.Drawing.Size(99, 40);
            this.btnReadCsv.TabIndex = 15;
            this.btnReadCsv.Text = "ReadCsv";
            this.btnReadCsv.UseVisualStyleBackColor = true;
            this.btnReadCsv.Click += new System.EventHandler(this.btnReadCsv_Click);
            // 
            // BtnWriteXls
            // 
            this.BtnWriteXls.Location = new System.Drawing.Point(614, 325);
            this.BtnWriteXls.Name = "BtnWriteXls";
            this.BtnWriteXls.Size = new System.Drawing.Size(99, 40);
            this.BtnWriteXls.TabIndex = 16;
            this.BtnWriteXls.Text = "WriteXls";
            this.BtnWriteXls.UseVisualStyleBackColor = true;
            this.BtnWriteXls.Click += new System.EventHandler(this.BtnWriteXls_Click);
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Location = new System.Drawing.Point(719, 325);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(99, 40);
            this.btnReadExcel.TabIndex = 17;
            this.btnReadExcel.Text = "ReadExcel";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // FormReadWriteFileText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 468);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.BtnWriteXls);
            this.Controls.Add(this.btnReadCsv);
            this.Controls.Add(this.btnWriteCsv);
            this.Controls.Add(this.grdFileCsvXlsXlxs);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnWriteXml);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnReadJson);
            this.Controls.Add(this.btnWriteJson);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReadWriteFileText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReadWriteFileText";
            ((System.ComponentModel.ISupportInitialize)(this.grdFileCsvXlsXlxs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWriteJson;
        private System.Windows.Forms.Button btnReadJson;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnWriteXml;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.DataGridView grdFileCsvXlsXlxs;
        private System.Windows.Forms.Button btnWriteCsv;
        private System.Windows.Forms.Button btnReadCsv;
        private System.Windows.Forms.Button BtnWriteXls;
        private System.Windows.Forms.Button btnReadExcel;
    }
}