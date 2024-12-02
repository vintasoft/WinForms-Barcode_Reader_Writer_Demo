namespace BarcodeDemo
{
    partial class GS1ValueEditorForm
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
            ApplicationIdentifierLabel = new System.Windows.Forms.Label();
            aiNumberComboBox = new System.Windows.Forms.ComboBox();
            dataContentLabel = new System.Windows.Forms.Label();
            aiValueTextBox = new System.Windows.Forms.TextBox();
            dataValueLabel = new System.Windows.Forms.Label();
            aiDataContentLabel = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            aiListDataGridView = new System.Windows.Forms.DataGridView();
            aiNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aiTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aiValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            okButton = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            dataFormatLabel = new System.Windows.Forms.Label();
            aiDataFormatLabel = new System.Windows.Forms.Label();
            formatStructureLabel = new System.Windows.Forms.Label();
            formatStructureValueLabel = new System.Windows.Forms.Label();
            barcodePrintableValueLabel = new System.Windows.Forms.Label();
            gs1BarcodePrintableValueTextBox = new System.Windows.Forms.TextBox();
            setDataValueButton = new System.Windows.Forms.Button();
            setPrintableValueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)aiListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ApplicationIdentifierLabel
            // 
            ApplicationIdentifierLabel.AutoSize = true;
            ApplicationIdentifierLabel.Location = new System.Drawing.Point(9, 40);
            ApplicationIdentifierLabel.Name = "ApplicationIdentifierLabel";
            ApplicationIdentifierLabel.Size = new System.Drawing.Size(118, 15);
            ApplicationIdentifierLabel.TabIndex = 0;
            ApplicationIdentifierLabel.Text = "Application Identifier";
            // 
            // aiNumberComboBox
            // 
            aiNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            aiNumberComboBox.FormattingEnabled = true;
            aiNumberComboBox.Location = new System.Drawing.Point(146, 37);
            aiNumberComboBox.Name = "aiNumberComboBox";
            aiNumberComboBox.Size = new System.Drawing.Size(412, 23);
            aiNumberComboBox.TabIndex = 1;
            aiNumberComboBox.SelectedIndexChanged += aiNumberComboBox_SelectedIndexChanged;
            // 
            // dataContentLabel
            // 
            dataContentLabel.AutoSize = true;
            dataContentLabel.Location = new System.Drawing.Point(9, 61);
            dataContentLabel.Name = "dataContentLabel";
            dataContentLabel.Size = new System.Drawing.Size(77, 15);
            dataContentLabel.TabIndex = 2;
            dataContentLabel.Text = "Data Content";
            // 
            // aiValueTextBox
            // 
            aiValueTextBox.Location = new System.Drawing.Point(146, 101);
            aiValueTextBox.Name = "aiValueTextBox";
            aiValueTextBox.Size = new System.Drawing.Size(304, 23);
            aiValueTextBox.TabIndex = 3;
            // 
            // dataValueLabel
            // 
            dataValueLabel.AutoSize = true;
            dataValueLabel.Location = new System.Drawing.Point(9, 101);
            dataValueLabel.Name = "dataValueLabel";
            dataValueLabel.Size = new System.Drawing.Size(62, 15);
            dataValueLabel.TabIndex = 4;
            dataValueLabel.Text = "Data Value";
            // 
            // aiDataContentLabel
            // 
            aiDataContentLabel.Location = new System.Drawing.Point(146, 61);
            aiDataContentLabel.Name = "aiDataContentLabel";
            aiDataContentLabel.Size = new System.Drawing.Size(412, 37);
            aiDataContentLabel.TabIndex = 5;
            aiDataContentLabel.Text = "[Data Content]";
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(456, 140);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(102, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(456, 170);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(102, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // aiListDataGridView
            // 
            aiListDataGridView.AllowUserToAddRows = false;
            aiListDataGridView.AllowUserToDeleteRows = false;
            aiListDataGridView.AllowUserToResizeColumns = false;
            aiListDataGridView.AllowUserToResizeRows = false;
            aiListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aiListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { aiNumberColumn, aiTitleColumn, aiValueColumn });
            aiListDataGridView.Location = new System.Drawing.Point(12, 207);
            aiListDataGridView.MultiSelect = false;
            aiListDataGridView.Name = "aiListDataGridView";
            aiListDataGridView.ReadOnly = true;
            aiListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            aiListDataGridView.Size = new System.Drawing.Size(546, 130);
            aiListDataGridView.TabIndex = 8;
            aiListDataGridView.RowEnter += aiListDataGridView_RowEnter;
            // 
            // aiNumberColumn
            // 
            aiNumberColumn.HeaderText = "AI";
            aiNumberColumn.Name = "aiNumberColumn";
            aiNumberColumn.ReadOnly = true;
            aiNumberColumn.Width = 70;
            // 
            // aiTitleColumn
            // 
            aiTitleColumn.HeaderText = "Data Title";
            aiTitleColumn.Name = "aiTitleColumn";
            aiTitleColumn.ReadOnly = true;
            aiTitleColumn.Width = 200;
            // 
            // aiValueColumn
            // 
            aiValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            aiValueColumn.HeaderText = "Value";
            aiValueColumn.Name = "aiValueColumn";
            aiValueColumn.ReadOnly = true;
            // 
            // okButton
            // 
            okButton.Location = new System.Drawing.Point(402, 343);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 9;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Location = new System.Drawing.Point(483, 343);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dataFormatLabel
            // 
            dataFormatLabel.AutoSize = true;
            dataFormatLabel.Location = new System.Drawing.Point(9, 126);
            dataFormatLabel.Name = "dataFormatLabel";
            dataFormatLabel.Size = new System.Drawing.Size(72, 15);
            dataFormatLabel.TabIndex = 11;
            dataFormatLabel.Text = "Data Format";
            // 
            // aiDataFormatLabel
            // 
            aiDataFormatLabel.AutoSize = true;
            aiDataFormatLabel.Location = new System.Drawing.Point(146, 126);
            aiDataFormatLabel.Name = "aiDataFormatLabel";
            aiDataFormatLabel.Size = new System.Drawing.Size(80, 15);
            aiDataFormatLabel.TabIndex = 12;
            aiDataFormatLabel.Text = "[Data Format]";
            // 
            // formatStructureLabel
            // 
            formatStructureLabel.AutoSize = true;
            formatStructureLabel.Location = new System.Drawing.Point(9, 143);
            formatStructureLabel.Name = "formatStructureLabel";
            formatStructureLabel.Size = new System.Drawing.Size(96, 15);
            formatStructureLabel.TabIndex = 13;
            formatStructureLabel.Text = "Format Structure";
            // 
            // formatStructureValueLabel
            // 
            formatStructureValueLabel.Location = new System.Drawing.Point(146, 143);
            formatStructureValueLabel.Name = "formatStructureValueLabel";
            formatStructureValueLabel.Size = new System.Drawing.Size(288, 61);
            formatStructureValueLabel.TabIndex = 14;
            formatStructureValueLabel.Text = "'Nk' - k numeric digits, fixed length\r\n'NkC' - k numeric digits + check digit, fixed length\r\n'N..k' - up to k numeric digits\r\n'X..k' - up to k characters ISO646";
            // 
            // barcodePrintableValueLabel
            // 
            barcodePrintableValueLabel.AutoSize = true;
            barcodePrintableValueLabel.Location = new System.Drawing.Point(9, 9);
            barcodePrintableValueLabel.Name = "barcodePrintableValueLabel";
            barcodePrintableValueLabel.Size = new System.Drawing.Size(131, 15);
            barcodePrintableValueLabel.TabIndex = 15;
            barcodePrintableValueLabel.Text = "Barcode printable value";
            // 
            // gs1BarcodePrintableValueTextBox
            // 
            gs1BarcodePrintableValueTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            gs1BarcodePrintableValueTextBox.Location = new System.Drawing.Point(146, 6);
            gs1BarcodePrintableValueTextBox.Name = "gs1BarcodePrintableValueTextBox";
            gs1BarcodePrintableValueTextBox.ReadOnly = true;
            gs1BarcodePrintableValueTextBox.Size = new System.Drawing.Size(304, 23);
            gs1BarcodePrintableValueTextBox.TabIndex = 16;
            // 
            // setDataValueButton
            // 
            setDataValueButton.Location = new System.Drawing.Point(456, 99);
            setDataValueButton.Name = "setDataValueButton";
            setDataValueButton.Size = new System.Drawing.Size(102, 23);
            setDataValueButton.TabIndex = 17;
            setDataValueButton.Text = "Set";
            setDataValueButton.UseVisualStyleBackColor = true;
            setDataValueButton.Click += setButton_Click;
            // 
            // setPrintableValueButton
            // 
            setPrintableValueButton.Location = new System.Drawing.Point(456, 4);
            setPrintableValueButton.Name = "setPrintableValueButton";
            setPrintableValueButton.Size = new System.Drawing.Size(102, 23);
            setPrintableValueButton.TabIndex = 18;
            setPrintableValueButton.Text = "Set";
            setPrintableValueButton.UseVisualStyleBackColor = true;
            setPrintableValueButton.Click += setPrintableValueButton_Click;
            // 
            // GS1ValueEditorForm
            // 
            AcceptButton = okButton;
            CancelButton = buttonCancel;
            ClientSize = new System.Drawing.Size(570, 373);
            Controls.Add(setPrintableValueButton);
            Controls.Add(setDataValueButton);
            Controls.Add(gs1BarcodePrintableValueTextBox);
            Controls.Add(barcodePrintableValueLabel);
            Controls.Add(formatStructureLabel);
            Controls.Add(aiDataFormatLabel);
            Controls.Add(dataFormatLabel);
            Controls.Add(buttonCancel);
            Controls.Add(okButton);
            Controls.Add(aiListDataGridView);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(aiDataContentLabel);
            Controls.Add(dataValueLabel);
            Controls.Add(aiValueTextBox);
            Controls.Add(dataContentLabel);
            Controls.Add(aiNumberComboBox);
            Controls.Add(ApplicationIdentifierLabel);
            Controls.Add(formatStructureValueLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GS1ValueEditorForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FormGS1ValueEditor";
            ((System.ComponentModel.ISupportInitialize)aiListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ApplicationIdentifierLabel;
        private System.Windows.Forms.ComboBox aiNumberComboBox;
        private System.Windows.Forms.Label dataContentLabel;
        private System.Windows.Forms.TextBox aiValueTextBox;
        private System.Windows.Forms.Label dataValueLabel;
        private System.Windows.Forms.Label aiDataContentLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView aiListDataGridView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label dataFormatLabel;
        private System.Windows.Forms.Label aiDataFormatLabel;
        private System.Windows.Forms.Label formatStructureLabel;
        private System.Windows.Forms.Label formatStructureValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aiValueColumn;
        private System.Windows.Forms.Label barcodePrintableValueLabel;
        private System.Windows.Forms.TextBox gs1BarcodePrintableValueTextBox;
        private System.Windows.Forms.Button setDataValueButton;
        private System.Windows.Forms.Button setPrintableValueButton;
    }
}