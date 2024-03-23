namespace WindowsFormsApp
{
    partial class PersonRecordEditDialog
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOt = new System.Windows.Forms.Label();
            this.labelOld = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOt = new System.Windows.Forms.TextBox();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(23, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(23, 88);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 151);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelOt
            // 
            this.labelOt.AutoSize = true;
            this.labelOt.Location = new System.Drawing.Point(26, 225);
            this.labelOt.Name = "labelOt";
            this.labelOt.Size = new System.Drawing.Size(54, 13);
            this.labelOt.TabIndex = 3;
            this.labelOt.Text = "Отчество";
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(26, 294);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(26, 13);
            this.labelOld.TabIndex = 4;
            this.labelOld.Text = "Лет";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(157, 424);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(26, 49);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(67, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(26, 114);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(162, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(26, 181);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxOt
            // 
            this.textBoxOt.Location = new System.Drawing.Point(26, 260);
            this.textBoxOt.Name = "textBoxOt";
            this.textBoxOt.Size = new System.Drawing.Size(162, 20);
            this.textBoxOt.TabIndex = 9;
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(26, 329);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(67, 20);
            this.textBoxOld.TabIndex = 10;
            // 
            // PersonRecordEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 487);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.textBoxOt);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelOld);
            this.Controls.Add(this.labelOt);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelID);
            this.Name = "PersonRecordEditDialog";
            this.Text = "PersonRecordEditDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOt;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxSurname;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxOt;
        public System.Windows.Forms.TextBox textBoxOld;
    }
}