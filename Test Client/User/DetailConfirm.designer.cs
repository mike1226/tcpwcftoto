namespace Test_Client
{
    partial class DetailConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetailConfirm = new System.Windows.Forms.Button();
            this.btnDetaiCancel = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 655);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "本画面用来罗列前画面选择的用户详细信息，并且是可以编辑的，如修改，删除等操作。";
            // 
            // btnDetailConfirm
            // 
            this.btnDetailConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetailConfirm.Location = new System.Drawing.Point(404, 712);
            this.btnDetailConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetailConfirm.Name = "btnDetailConfirm";
            this.btnDetailConfirm.Size = new System.Drawing.Size(93, 38);
            this.btnDetailConfirm.TabIndex = 1;
            this.btnDetailConfirm.Text = "确定";
            this.btnDetailConfirm.UseVisualStyleBackColor = true;
            this.btnDetailConfirm.Click += new System.EventHandler(this.btnDetailConfirm_Click);
            // 
            // btnDetaiCancel
            // 
            this.btnDetaiCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetaiCancel.Location = new System.Drawing.Point(681, 712);
            this.btnDetaiCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetaiCancel.Name = "btnDetaiCancel";
            this.btnDetaiCancel.Size = new System.Drawing.Size(93, 38);
            this.btnDetaiCancel.TabIndex = 1;
            this.btnDetaiCancel.Text = "取消";
            this.btnDetaiCancel.UseVisualStyleBackColor = true;
            this.btnDetaiCancel.Click += new System.EventHandler(this.btnDetaiCancel_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tab.Location = new System.Drawing.Point(24, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1219, 627);
            this.tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1211, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户详细信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1211, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "博彩详细信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1211, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DetailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 772);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btnDetaiCancel);
            this.Controls.Add(this.btnDetailConfirm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailConfirm";
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetailConfirm;
        private System.Windows.Forms.Button btnDetaiCancel;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}