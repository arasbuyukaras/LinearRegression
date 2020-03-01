namespace LineerRegresyonUPK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btn_calcul = new System.Windows.Forms.Button();
            this.xvalname = new System.Windows.Forms.TextBox();
            this.yvalname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_xval = new System.Windows.Forms.TextBox();
            this.txt_yval = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_stdx = new System.Windows.Forms.TextBox();
            this.txt_stdy = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.xsvariance = new System.Windows.Forms.TextBox();
            this.ysvariance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_avgx = new System.Windows.Forms.TextBox();
            this.txt_avgy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.yvallabel = new System.Windows.Forms.Label();
            this.lbl_panel = new System.Windows.Forms.Label();
            this.slope1 = new System.Windows.Forms.TextBox();
            this.intercept = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.txt_sumx = new System.Windows.Forms.TextBox();
            this.txt_sumy = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcul
            // 
            this.btn_calcul.Location = new System.Drawing.Point(447, 26);
            this.btn_calcul.Name = "btn_calcul";
            this.btn_calcul.Size = new System.Drawing.Size(133, 39);
            this.btn_calcul.TabIndex = 0;
            this.btn_calcul.Text = "Hesapla";
            this.btn_calcul.UseVisualStyleBackColor = true;
            this.btn_calcul.Click += new System.EventHandler(this.btn_lrhesapla_Click);
            // 
            // xvalname
            // 
            this.xvalname.Location = new System.Drawing.Point(45, 26);
            this.xvalname.Margin = new System.Windows.Forms.Padding(4);
            this.xvalname.Name = "xvalname";
            this.xvalname.Size = new System.Drawing.Size(105, 22);
            this.xvalname.TabIndex = 70;
            this.xvalname.Text = "X Değerleri";
            this.xvalname.WordWrap = false;
            // 
            // yvalname
            // 
            this.yvalname.Location = new System.Drawing.Point(179, 26);
            this.yvalname.Margin = new System.Windows.Forms.Padding(4);
            this.yvalname.Name = "yvalname";
            this.yvalname.Size = new System.Drawing.Size(107, 22);
            this.yvalname.TabIndex = 72;
            this.yvalname.Text = "Y Değerleri";
            this.yvalname.WordWrap = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-170, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 28);
            this.label9.TabIndex = 86;
            this.label9.Text = "Sum:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-117, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 79;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_xval
            // 
            this.txt_xval.AcceptsReturn = true;
            this.txt_xval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_xval.Location = new System.Drawing.Point(22, 51);
            this.txt_xval.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xval.Multiline = true;
            this.txt_xval.Name = "txt_xval";
            this.txt_xval.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_xval.Size = new System.Drawing.Size(128, 194);
            this.txt_xval.TabIndex = 71;
            // 
            // txt_yval
            // 
            this.txt_yval.AcceptsReturn = true;
            this.txt_yval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_yval.Location = new System.Drawing.Point(158, 51);
            this.txt_yval.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yval.Multiline = true;
            this.txt_yval.Name = "txt_yval";
            this.txt_yval.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_yval.Size = new System.Drawing.Size(128, 194);
            this.txt_yval.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(447, 102);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 25);
            this.label19.TabIndex = 106;
            this.label19.Text = "X Değerleri";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(588, 102);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 25);
            this.label20.TabIndex = 105;
            this.label20.Text = "Y Değerleri";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_stdx
            // 
            this.txt_stdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stdx.Location = new System.Drawing.Point(447, 185);
            this.txt_stdx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stdx.Name = "txt_stdx";
            this.txt_stdx.ReadOnly = true;
            this.txt_stdx.Size = new System.Drawing.Size(133, 23);
            this.txt_stdx.TabIndex = 104;
            this.txt_stdx.TabStop = false;
            // 
            // txt_stdy
            // 
            this.txt_stdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stdy.Location = new System.Drawing.Point(588, 185);
            this.txt_stdy.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stdy.Name = "txt_stdy";
            this.txt_stdy.ReadOnly = true;
            this.txt_stdy.Size = new System.Drawing.Size(133, 23);
            this.txt_stdy.TabIndex = 103;
            this.txt_stdy.TabStop = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(319, 187);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 28);
            this.label18.TabIndex = 102;
            this.label18.Text = "Std Sapma:";
            // 
            // xsvariance
            // 
            this.xsvariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xsvariance.Location = new System.Drawing.Point(447, 157);
            this.xsvariance.Margin = new System.Windows.Forms.Padding(4);
            this.xsvariance.Name = "xsvariance";
            this.xsvariance.ReadOnly = true;
            this.xsvariance.Size = new System.Drawing.Size(133, 23);
            this.xsvariance.TabIndex = 101;
            this.xsvariance.TabStop = false;
            // 
            // ysvariance
            // 
            this.ysvariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysvariance.Location = new System.Drawing.Point(588, 157);
            this.ysvariance.Margin = new System.Windows.Forms.Padding(4);
            this.ysvariance.Name = "ysvariance";
            this.ysvariance.ReadOnly = true;
            this.ysvariance.Size = new System.Drawing.Size(133, 23);
            this.ysvariance.TabIndex = 100;
            this.ysvariance.TabStop = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(319, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 28);
            this.label17.TabIndex = 99;
            this.label17.Text = "Varyans:";
            // 
            // txt_avgx
            // 
            this.txt_avgx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avgx.Location = new System.Drawing.Point(447, 129);
            this.txt_avgx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_avgx.Name = "txt_avgx";
            this.txt_avgx.ReadOnly = true;
            this.txt_avgx.Size = new System.Drawing.Size(133, 23);
            this.txt_avgx.TabIndex = 98;
            this.txt_avgx.TabStop = false;
            // 
            // txt_avgy
            // 
            this.txt_avgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avgy.Location = new System.Drawing.Point(588, 129);
            this.txt_avgy.Margin = new System.Windows.Forms.Padding(4);
            this.txt_avgy.Name = "txt_avgy";
            this.txt_avgy.ReadOnly = true;
            this.txt_avgy.Size = new System.Drawing.Size(133, 23);
            this.txt_avgy.TabIndex = 97;
            this.txt_avgy.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 28);
            this.label10.TabIndex = 96;
            this.label10.Text = "Ortalama:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label98);
            this.panel8.Controls.Add(this.label96);
            this.panel8.Controls.Add(this.yvallabel);
            this.panel8.Controls.Add(this.lbl_panel);
            this.panel8.Controls.Add(this.slope1);
            this.panel8.Controls.Add(this.intercept);
            this.panel8.Location = new System.Drawing.Point(22, 284);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(705, 68);
            this.panel8.TabIndex = 111;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(626, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 22);
            this.label16.TabIndex = 32;
            this.label16.Text = "x";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label98
            // 
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(497, 25);
            this.label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(21, 20);
            this.label98.TabIndex = 4;
            this.label98.Text = "+";
            // 
            // label96
            // 
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.Black;
            this.label96.Location = new System.Drawing.Point(366, 25);
            this.label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(23, 20);
            this.label96.TabIndex = 2;
            this.label96.Text = "=";
            // 
            // yvallabel
            // 
            this.yvallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yvallabel.ForeColor = System.Drawing.Color.Black;
            this.yvallabel.Location = new System.Drawing.Point(339, 23);
            this.yvallabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yvallabel.Name = "yvallabel";
            this.yvallabel.Size = new System.Drawing.Size(19, 22);
            this.yvallabel.TabIndex = 1;
            this.yvallabel.Text = "y";
            this.yvallabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_panel
            // 
            this.lbl_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panel.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_panel.Location = new System.Drawing.Point(4, 21);
            this.lbl_panel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_panel.Name = "lbl_panel";
            this.lbl_panel.Size = new System.Drawing.Size(238, 20);
            this.lbl_panel.TabIndex = 0;
            this.lbl_panel.Text = "Lineer Regresyon Plotu";
            // 
            // slope1
            // 
            this.slope1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slope1.Location = new System.Drawing.Point(526, 25);
            this.slope1.Margin = new System.Windows.Forms.Padding(4);
            this.slope1.Name = "slope1";
            this.slope1.ReadOnly = true;
            this.slope1.Size = new System.Drawing.Size(92, 23);
            this.slope1.TabIndex = 28;
            this.slope1.TabStop = false;
            this.slope1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // intercept
            // 
            this.intercept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intercept.Location = new System.Drawing.Point(397, 25);
            this.intercept.Margin = new System.Windows.Forms.Padding(4);
            this.intercept.Name = "intercept";
            this.intercept.ReadOnly = true;
            this.intercept.Size = new System.Drawing.Size(92, 23);
            this.intercept.TabIndex = 30;
            this.intercept.TabStop = false;
            this.intercept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(22, 375);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(705, 350);
            this.chart1.TabIndex = 108;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 112;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(22, 733);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 68);
            this.panel2.TabIndex = 112;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(19, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(672, 55);
            this.label22.TabIndex = 0;
            this.label22.Text = "created by Aras Büyükaras  \r\nÜretim Planlama ve Kontrol dersi kapsamındaki projed" +
    "e\r\nkullanılmak üzere yazılmıştır.\r\nTüm hakları saklıdır";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(588, 26);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(133, 39);
            this.btn_clean.TabIndex = 115;
            this.btn_clean.Text = "Temizle";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btnl_lrtemizle_Click);
            // 
            // txt_sumx
            // 
            this.txt_sumx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sumx.Location = new System.Drawing.Point(22, 249);
            this.txt_sumx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sumx.Name = "txt_sumx";
            this.txt_sumx.ReadOnly = true;
            this.txt_sumx.Size = new System.Drawing.Size(107, 23);
            this.txt_sumx.TabIndex = 88;
            this.txt_sumx.TabStop = false;
            this.txt_sumx.Visible = false;
            // 
            // txt_sumy
            // 
            this.txt_sumy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sumy.Location = new System.Drawing.Point(158, 249);
            this.txt_sumy.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sumy.Name = "txt_sumy";
            this.txt_sumy.ReadOnly = true;
            this.txt_sumy.Size = new System.Drawing.Size(107, 23);
            this.txt_sumy.TabIndex = 87;
            this.txt_sumy.TabStop = false;
            this.txt_sumy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 811);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_stdx);
            this.Controls.Add(this.txt_stdy);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.xsvariance);
            this.Controls.Add(this.ysvariance);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_avgx);
            this.Controls.Add(this.txt_avgy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xvalname);
            this.Controls.Add(this.yvalname);
            this.Controls.Add(this.txt_sumx);
            this.Controls.Add(this.txt_sumy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_xval);
            this.Controls.Add(this.txt_yval);
            this.Controls.Add(this.btn_calcul);
            this.MaximumSize = new System.Drawing.Size(754, 858);
            this.MinimumSize = new System.Drawing.Size(754, 858);
            this.Name = "Form1";
            this.Text = "Lineer Regresyon Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcul;
        private System.Windows.Forms.TextBox xvalname;
        private System.Windows.Forms.TextBox yvalname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_xval;
        private System.Windows.Forms.TextBox txt_yval;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_stdx;
        private System.Windows.Forms.TextBox txt_stdy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox xsvariance;
        private System.Windows.Forms.TextBox ysvariance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_avgx;
        private System.Windows.Forms.TextBox txt_avgy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label lbl_panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox intercept;
        private System.Windows.Forms.TextBox slope1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yvallabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.TextBox txt_sumx;
        private System.Windows.Forms.TextBox txt_sumy;
        private System.Windows.Forms.Label label16;
    }
}

