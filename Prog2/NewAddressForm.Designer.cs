namespace UPVApp
{
    partial class NewAddressForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lineOneTextBox = new System.Windows.Forms.TextBox();
            this.lineTwoTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(62, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 77);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(80, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address Line 1:";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(20, 108);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(80, 13);
            this.addressLine2Label.TabIndex = 4;
            this.addressLine2Label.Text = "Address Line 2:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(73, 139);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(65, 170);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(75, 201);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 10;
            this.zipLabel.Text = "Zip:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(65, 232);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(146, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseCaptureChanged += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stringValidating);
            this.nameTextBox.Validated += new System.EventHandler(this.stringValidated);
            // 
            // lineOneTextBox
            // 
            this.lineOneTextBox.Location = new System.Drawing.Point(106, 74);
            this.lineOneTextBox.Name = "lineOneTextBox";
            this.lineOneTextBox.Size = new System.Drawing.Size(179, 20);
            this.lineOneTextBox.TabIndex = 3;
            this.lineOneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stringValidating);
            this.lineOneTextBox.Validated += new System.EventHandler(this.stringValidated);
            // 
            // lineTwoTextBox
            // 
            this.lineTwoTextBox.Location = new System.Drawing.Point(106, 105);
            this.lineTwoTextBox.Name = "lineTwoTextBox";
            this.lineTwoTextBox.Size = new System.Drawing.Size(179, 20);
            this.lineTwoTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(106, 136);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(179, 20);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stringValidating);
            this.cityTextBox.Validated += new System.EventHandler(this.stringValidated);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(106, 198);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(179, 20);
            this.zipTextBox.TabIndex = 11;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipValidating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipValidated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois",
            "Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana",
            "Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.stateComboBox.Location = new System.Drawing.Point(106, 167);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(179, 21);
            this.stateComboBox.TabIndex = 9;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.comboValidating);
            this.stateComboBox.Validated += new System.EventHandler(this.comboValidated);
            // 
            // NewAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 267);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.lineTwoTextBox);
            this.Controls.Add(this.lineOneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLine2Label);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "NewAddressForm";
            this.Text = "Enter New Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lineOneTextBox;
        private System.Windows.Forms.TextBox lineTwoTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox stateComboBox;
    }
}