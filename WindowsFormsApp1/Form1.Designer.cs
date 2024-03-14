namespace WindowsFormsApp1
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.chk_poset = new System.Windows.Forms.CheckBox();
            this.chk_yag = new System.Windows.Forms.CheckBox();
            this.chk_koli = new System.Windows.Forms.CheckBox();
            this.txt_Sicil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_src = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_kart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.Location = new System.Drawing.Point(190, 375);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(141, 37);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chk_poset
            // 
            this.chk_poset.AutoSize = true;
            this.chk_poset.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_poset.Location = new System.Drawing.Point(230, 300);
            this.chk_poset.Name = "chk_poset";
            this.chk_poset.Size = new System.Drawing.Size(15, 14);
            this.chk_poset.TabIndex = 5;
            this.chk_poset.UseVisualStyleBackColor = true;
            this.chk_poset.CheckedChanged += new System.EventHandler(this.chk_poset_CheckedChanged);
            // 
            // chk_yag
            // 
            this.chk_yag.AutoSize = true;
            this.chk_yag.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_yag.Location = new System.Drawing.Point(230, 240);
            this.chk_yag.Name = "chk_yag";
            this.chk_yag.Size = new System.Drawing.Size(15, 14);
            this.chk_yag.TabIndex = 4;
            this.chk_yag.UseVisualStyleBackColor = true;
            this.chk_yag.CheckedChanged += new System.EventHandler(this.chk_yag_CheckedChanged);
            // 
            // chk_koli
            // 
            this.chk_koli.AutoSize = true;
            this.chk_koli.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_koli.Location = new System.Drawing.Point(230, 180);
            this.chk_koli.Name = "chk_koli";
            this.chk_koli.Size = new System.Drawing.Size(15, 14);
            this.chk_koli.TabIndex = 3;
            this.chk_koli.UseVisualStyleBackColor = true;
            this.chk_koli.CheckedChanged += new System.EventHandler(this.chk_koli_CheckedChanged);
            // 
            // txt_Sicil
            // 
            this.txt_Sicil.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sicil.Location = new System.Drawing.Point(190, 60);
            this.txt_Sicil.Name = "txt_Sicil";
            this.txt_Sicil.Size = new System.Drawing.Size(98, 29);
            this.txt_Sicil.TabIndex = 1;
            this.txt_Sicil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Sicil_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sicil No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Koli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yağ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poşet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(126, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // btn_src
            // 
            this.btn_src.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.search;
            this.btn_src.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_src.Location = new System.Drawing.Point(294, 60);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(37, 29);
            this.btn_src.TabIndex = 2;
            this.btn_src.UseVisualStyleBackColor = true;
            this.btn_src.Click += new System.EventHandler(this.btn_src_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(61, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(290, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // chk_kart
            // 
            this.chk_kart.AutoSize = true;
            this.chk_kart.Location = new System.Drawing.Point(299, 95);
            this.chk_kart.Name = "chk_kart";
            this.chk_kart.Size = new System.Drawing.Size(85, 17);
            this.chk_kart.TabIndex = 17;
            this.chk_kart.Text = "Kart Okutma";
            this.chk_kart.UseVisualStyleBackColor = true;
            this.chk_kart.CheckedChanged += new System.EventHandler(this.chk_kart_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.chk_kart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_src);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sicil);
            this.Controls.Add(this.chk_koli);
            this.Controls.Add(this.chk_yag);
            this.Controls.Add(this.chk_poset);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "Form1";
            this.Text = "Sango Paket Değıtım";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox chk_poset;
        private System.Windows.Forms.CheckBox chk_yag;
        private System.Windows.Forms.CheckBox chk_koli;
        private System.Windows.Forms.TextBox txt_Sicil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chk_kart;
    }
}

