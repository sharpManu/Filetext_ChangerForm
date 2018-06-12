namespace Filetext_ChangerForm
{
    partial class MassFileChanger
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_selectPath = new System.Windows.Forms.TextBox();
            this.tb_savePath = new System.Windows.Forms.TextBox();
            this.tb_enteredString = new System.Windows.Forms.TextBox();
            this.tb_changeToString = new System.Windows.Forms.TextBox();
            this.btn_ofd = new System.Windows.Forms.Button();
            this.btn_sfd = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_AmountFiles = new System.Windows.Forms.Label();
            this.lb_change = new System.Windows.Forms.Label();
            this.lb_ToThis = new System.Windows.Forms.Label();
            this.cb_Overwrite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_selectPath
            // 
            this.tb_selectPath.Location = new System.Drawing.Point(28, 53);
            this.tb_selectPath.Name = "tb_selectPath";
            this.tb_selectPath.ReadOnly = true;
            this.tb_selectPath.Size = new System.Drawing.Size(302, 20);
            this.tb_selectPath.TabIndex = 0;
            // 
            // tb_savePath
            // 
            this.tb_savePath.Location = new System.Drawing.Point(28, 144);
            this.tb_savePath.Name = "tb_savePath";
            this.tb_savePath.ReadOnly = true;
            this.tb_savePath.Size = new System.Drawing.Size(302, 20);
            this.tb_savePath.TabIndex = 1;
            // 
            // tb_enteredString
            // 
            this.tb_enteredString.Location = new System.Drawing.Point(28, 207);
            this.tb_enteredString.Name = "tb_enteredString";
            this.tb_enteredString.Size = new System.Drawing.Size(160, 20);
            this.tb_enteredString.TabIndex = 2;
            // 
            // tb_changeToString
            // 
            this.tb_changeToString.Location = new System.Drawing.Point(28, 260);
            this.tb_changeToString.Name = "tb_changeToString";
            this.tb_changeToString.Size = new System.Drawing.Size(160, 20);
            this.tb_changeToString.TabIndex = 3;
            // 
            // btn_ofd
            // 
            this.btn_ofd.Location = new System.Drawing.Point(28, 24);
            this.btn_ofd.Name = "btn_ofd";
            this.btn_ofd.Size = new System.Drawing.Size(86, 23);
            this.btn_ofd.TabIndex = 4;
            this.btn_ofd.Text = "Öffnen";
            this.btn_ofd.UseVisualStyleBackColor = true;
            this.btn_ofd.Click += new System.EventHandler(this.btn_ofd_Click);
            // 
            // btn_sfd
            // 
            this.btn_sfd.Location = new System.Drawing.Point(28, 115);
            this.btn_sfd.Name = "btn_sfd";
            this.btn_sfd.Size = new System.Drawing.Size(86, 23);
            this.btn_sfd.TabIndex = 5;
            this.btn_sfd.Text = "Ziel";
            this.btn_sfd.UseVisualStyleBackColor = true;
            this.btn_sfd.Click += new System.EventHandler(this.btn_sfd_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(230, 215);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 50);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Ändern";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_AmountFiles
            // 
            this.lb_AmountFiles.AutoSize = true;
            this.lb_AmountFiles.Location = new System.Drawing.Point(25, 76);
            this.lb_AmountFiles.Name = "lb_AmountFiles";
            this.lb_AmountFiles.Size = new System.Drawing.Size(0, 13);
            this.lb_AmountFiles.TabIndex = 7;
            // 
            // lb_change
            // 
            this.lb_change.AutoSize = true;
            this.lb_change.Location = new System.Drawing.Point(25, 191);
            this.lb_change.Name = "lb_change";
            this.lb_change.Size = new System.Drawing.Size(44, 13);
            this.lb_change.TabIndex = 8;
            this.lb_change.Text = "Ändere:";
            // 
            // lb_ToThis
            // 
            this.lb_ToThis.AutoSize = true;
            this.lb_ToThis.Location = new System.Drawing.Point(25, 244);
            this.lb_ToThis.Name = "lb_ToThis";
            this.lb_ToThis.Size = new System.Drawing.Size(21, 13);
            this.lb_ToThis.TabIndex = 9;
            this.lb_ToThis.Text = "zu:";
            // 
            // cb_Overwrite
            // 
            this.cb_Overwrite.AutoSize = true;
            this.cb_Overwrite.Location = new System.Drawing.Point(120, 29);
            this.cb_Overwrite.Name = "cb_Overwrite";
            this.cb_Overwrite.Size = new System.Drawing.Size(95, 17);
            this.cb_Overwrite.TabIndex = 10;
            this.cb_Overwrite.Text = "Überschreiben";
            this.cb_Overwrite.UseVisualStyleBackColor = true;
            this.cb_Overwrite.CheckedChanged += new System.EventHandler(this.cb_Overwrite_CheckedChanged);
            // 
            // MassFileChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 311);
            this.Controls.Add(this.cb_Overwrite);
            this.Controls.Add(this.lb_ToThis);
            this.Controls.Add(this.lb_change);
            this.Controls.Add(this.lb_AmountFiles);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_sfd);
            this.Controls.Add(this.btn_ofd);
            this.Controls.Add(this.tb_changeToString);
            this.Controls.Add(this.tb_enteredString);
            this.Controls.Add(this.tb_savePath);
            this.Controls.Add(this.tb_selectPath);
            this.Name = "MassFileChanger";
            this.Text = "Dateinamen Aendern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_selectPath;
        private System.Windows.Forms.TextBox tb_savePath;
        private System.Windows.Forms.TextBox tb_enteredString;
        private System.Windows.Forms.TextBox tb_changeToString;
        private System.Windows.Forms.Button btn_ofd;
        private System.Windows.Forms.Button btn_sfd;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_AmountFiles;
        private System.Windows.Forms.Label lb_change;
        private System.Windows.Forms.Label lb_ToThis;
        private System.Windows.Forms.CheckBox cb_Overwrite;
    }
}

