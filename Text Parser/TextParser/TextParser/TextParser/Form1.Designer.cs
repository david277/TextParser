namespace TextParser
{
    partial class form
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
            this.processButton = new System.Windows.Forms.Button();
            this.openTextFile = new System.Windows.Forms.OpenFileDialog();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.directTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(473, 166);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(138, 31);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Process Text File";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // openTextFile
            // 
            this.openTextFile.FileName = "openTextFile";
            // 
            // openTextBox
            // 
            this.openTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openTextBox.Location = new System.Drawing.Point(285, 94);
            this.openTextBox.Multiline = true;
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.Size = new System.Drawing.Size(282, 20);
            this.openTextBox.TabIndex = 5;
            this.openTextBox.TextChanged += new System.EventHandler(this.openTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name Text File (e.g. foo):";
            // 
            // createTextBox
            // 
            this.createTextBox.Location = new System.Drawing.Point(285, 172);
            this.createTextBox.Name = "createTextBox";
            this.createTextBox.Size = new System.Drawing.Size(182, 20);
            this.createTextBox.TabIndex = 9;
            this.createTextBox.TextChanged += new System.EventHandler(this.createTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(66, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Read From Text File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Write To Directory:";
            // 
            // directTextBox
            // 
            this.directTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.directTextBox.Location = new System.Drawing.Point(285, 132);
            this.directTextBox.Multiline = true;
            this.directTextBox.Name = "directTextBox";
            this.directTextBox.Size = new System.Drawing.Size(324, 20);
            this.directTextBox.TabIndex = 12;
            this.directTextBox.TextChanged += new System.EventHandler(this.directortTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Text Parser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "By: David I. Widjaja and Joe Bae";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(517, 209);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 31);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(26, 257);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(123, 13);
            this.noticeLabel.TabIndex = 18;
            this.noticeLabel.Text = "Please fill in the blanks...";
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 302);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openTextBox);
            this.Controls.Add(this.processButton);
            this.Name = "form";
            this.Text = "TextParserCount Beta v1.0";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.OpenFileDialog openTextFile;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox directTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

