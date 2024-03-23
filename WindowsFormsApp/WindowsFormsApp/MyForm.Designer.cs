namespace WindowsFormsApp
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.myUserControl1 = new WindowsFormsApp.MyUserControl();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myUserControl1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.myUserControl1.LabelText = "Пароль:";
            this.myUserControl1.Location = new System.Drawing.Point(44, 51);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Password = "";
            this.myUserControl1.Size = new System.Drawing.Size(368, 50);
            this.myUserControl1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(90, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDialog.Location = new System.Drawing.Point(302, 183);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 2;
            this.btnShowDialog.Text = "Show Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.ShowDialogButton_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 250);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.myUserControl1);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl myUserControl1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShowDialog;
    }
}

