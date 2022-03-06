namespace Sozluk
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txteng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtturk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblklm = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            // 
            // txteng
            // 
            this.txteng.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteng.Location = new System.Drawing.Point(108, 9);
            this.txteng.Multiline = true;
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(494, 20);
            this.txteng.TabIndex = 1;
            this.txteng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe";
            // 
            // txtturk
            // 
            this.txtturk.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtturk.Location = new System.Drawing.Point(108, 101);
            this.txtturk.Multiline = true;
            this.txtturk.Name = "txtturk";
            this.txtturk.Size = new System.Drawing.Size(494, 20);
            this.txtturk.TabIndex = 3;
            this.txtturk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtturk.TextChanged += new System.EventHandler(this.txtturk_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre";
            this.label3.Visible = false;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(457, 162);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(19, 13);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "90";
            this.lblsure.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime";
            this.label5.Visible = false;
            // 
            // lblklm
            // 
            this.lblklm.AutoSize = true;
            this.lblklm.Location = new System.Drawing.Point(457, 198);
            this.lblklm.Name = "lblklm";
            this.lblklm.Size = new System.Drawing.Size(13, 13);
            this.lblklm.TabIndex = 7;
            this.lblklm.Text = "0";
            this.lblklm.Visible = false;
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcevap.ForeColor = System.Drawing.Color.Red;
            this.lblcevap.Location = new System.Drawing.Point(236, 191);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(62, 20);
            this.lblcevap.TabIndex = 8;
            this.lblcevap.Text = "Kelime";
            this.lblcevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "By Fatih Kılavuz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 220);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lblklm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtturk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SÖZLÜK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtturk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblklm;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

