namespace Electrode_Search
{
    partial class Electrode_Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_electrode = new System.Windows.Forms.Label();
            this.txt_application = new System.Windows.Forms.TextBox();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.Label();
            this.txt_current = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELECTRODE NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APPLICATION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPTION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TYPE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CURRENT:";
            // 
            // txt_electrode
            // 
            this.txt_electrode.AutoSize = true;
            this.txt_electrode.Location = new System.Drawing.Point(183, 20);
            this.txt_electrode.Name = "txt_electrode";
            this.txt_electrode.Size = new System.Drawing.Size(109, 13);
            this.txt_electrode.TabIndex = 5;
            this.txt_electrode.Text = "ELECTRODE NAME:";
            // 
            // txt_application
            // 
            this.txt_application.Location = new System.Drawing.Point(98, 65);
            this.txt_application.Multiline = true;
            this.txt_application.Name = "txt_application";
            this.txt_application.ReadOnly = true;
            this.txt_application.Size = new System.Drawing.Size(447, 188);
            this.txt_application.TabIndex = 6;
            this.txt_application.TabStop = false;
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(98, 259);
            this.txt_descr.Multiline = true;
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.ReadOnly = true;
            this.txt_descr.Size = new System.Drawing.Size(447, 133);
            this.txt_descr.TabIndex = 7;
            this.txt_descr.TabStop = false;
            // 
            // txt_type
            // 
            this.txt_type.AutoSize = true;
            this.txt_type.Location = new System.Drawing.Point(95, 405);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(109, 13);
            this.txt_type.TabIndex = 8;
            this.txt_type.Text = "ELECTRODE NAME:";
            // 
            // txt_current
            // 
            this.txt_current.AutoSize = true;
            this.txt_current.Location = new System.Drawing.Point(95, 439);
            this.txt_current.Name = "txt_current";
            this.txt_current.Size = new System.Drawing.Size(109, 13);
            this.txt_current.TabIndex = 9;
            this.txt_current.Text = "ELECTRODE NAME:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(250, 503);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Electrode_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 570);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_current);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_descr);
            this.Controls.Add(this.txt_application);
            this.Controls.Add(this.txt_electrode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Electrode_Details";
            this.Text = "Electrode Details";
            this.Load += new System.EventHandler(this.Electrode_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_electrode;
        private System.Windows.Forms.TextBox txt_application;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Label txt_current;
        private System.Windows.Forms.Button btn_ok;
    }
}