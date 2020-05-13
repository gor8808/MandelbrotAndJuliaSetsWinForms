using System;

namespace MandelbrotSetWinForms
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.MandelbrotPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MandelbrotTimerLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MandelbrotIterationsCount = new System.Windows.Forms.TextBox();
            this.MandelbrotYMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MandelbrotYMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MandelbrotXMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MandelbrotXMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MandelbrotPictureBox = new System.Windows.Forms.PictureBox();
            this.JuliaPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.JuliaTimer = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.JuliaCY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.JuliaCX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.JuliaIterationsCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.JuliaYMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.JuliaYMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.JuliaXMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JuliaXMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.JuliaPictureBox = new System.Windows.Forms.PictureBox();
            this.MandelbrotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPictureBox)).BeginInit();
            this.JuliaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JuliaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Home";
            this.menuItem3.Click += new System.EventHandler(this.Home_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Save image";
            this.menuItem5.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Exit";
            this.menuItem6.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "x1";
            this.menuItem9.Click += new System.EventHandler(this.Scale_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "x2";
            this.menuItem7.Click += new System.EventHandler(this.Scale_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "x4";
            this.menuItem8.Click += new System.EventHandler(this.Scale_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem7,
            this.menuItem8,
            this.menuItem11});
            this.menuItem2.Text = "Scale";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.Text = "Normal";
            this.menuItem11.Click += new System.EventHandler(this.Scale_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Select color";
            this.menuItem4.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem1,
            this.menuItem2,
            this.menuItem4,
            this.menuItem12});
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem14});
            this.menuItem12.Text = "Set types";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "Mandelbrot";
            this.menuItem13.Click += new System.EventHandler(this.SetTypeChange_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Text = "Julia";
            this.menuItem14.Click += new System.EventHandler(this.SetTypeChange_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = -1;
            this.menuItem10.Text = "";
            // 
            // MandelbrotPanel
            // 
            this.MandelbrotPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MandelbrotPanel.Controls.Add(this.splitContainer1);
            this.MandelbrotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MandelbrotPanel.Location = new System.Drawing.Point(0, 0);
            this.MandelbrotPanel.Name = "MandelbrotPanel";
            this.MandelbrotPanel.Size = new System.Drawing.Size(951, 606);
            this.MandelbrotPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotTimerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotIterationsCount);
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotYMax);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotYMin);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotXMax);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.MandelbrotXMin);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MandelbrotPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(951, 606);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // MandelbrotTimerLabel
            // 
            this.MandelbrotTimerLabel.AutoSize = true;
            this.MandelbrotTimerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MandelbrotTimerLabel.Location = new System.Drawing.Point(700, 27);
            this.MandelbrotTimerLabel.Name = "MandelbrotTimerLabel";
            this.MandelbrotTimerLabel.Size = new System.Drawing.Size(44, 17);
            this.MandelbrotTimerLabel.TabIndex = 12;
            this.MandelbrotTimerLabel.Text = "Timer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetMandelbrot_Click);
            // 
            // MandelbrotIterationsCount
            // 
            this.MandelbrotIterationsCount.Location = new System.Drawing.Point(540, 25);
            this.MandelbrotIterationsCount.Name = "MandelbrotIterationsCount";
            this.MandelbrotIterationsCount.Size = new System.Drawing.Size(123, 22);
            this.MandelbrotIterationsCount.TabIndex = 10;
            // 
            // MandelbrotYMax
            // 
            this.MandelbrotYMax.Location = new System.Drawing.Point(341, 42);
            this.MandelbrotYMax.Name = "MandelbrotYMax";
            this.MandelbrotYMax.Size = new System.Drawing.Size(123, 22);
            this.MandelbrotYMax.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(289, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Y";
            // 
            // MandelbrotYMin
            // 
            this.MandelbrotYMin.Location = new System.Drawing.Point(341, 12);
            this.MandelbrotYMin.Name = "MandelbrotYMin";
            this.MandelbrotYMin.Size = new System.Drawing.Size(123, 22);
            this.MandelbrotYMin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(289, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min Y";
            // 
            // MandelbrotXMax
            // 
            this.MandelbrotXMax.Location = new System.Drawing.Point(154, 44);
            this.MandelbrotXMax.Name = "MandelbrotXMax";
            this.MandelbrotXMax.Size = new System.Drawing.Size(123, 22);
            this.MandelbrotXMax.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(102, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max X";
            // 
            // MandelbrotXMin
            // 
            this.MandelbrotXMin.Location = new System.Drawing.Point(154, 14);
            this.MandelbrotXMin.Name = "MandelbrotXMin";
            this.MandelbrotXMin.Size = new System.Drawing.Size(123, 22);
            this.MandelbrotXMin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowMadelbrotImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(488, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deep";
            // 
            // MandelbrotPictureBox
            // 
            this.MandelbrotPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MandelbrotPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MandelbrotPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MandelbrotPictureBox.Name = "MandelbrotPictureBox";
            this.MandelbrotPictureBox.Size = new System.Drawing.Size(949, 531);
            this.MandelbrotPictureBox.TabIndex = 0;
            this.MandelbrotPictureBox.TabStop = false;
            // 
            // JuliaPanel
            // 
            this.JuliaPanel.BackColor = System.Drawing.Color.White;
            this.JuliaPanel.Controls.Add(this.splitContainer2);
            this.JuliaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JuliaPanel.Location = new System.Drawing.Point(0, 0);
            this.JuliaPanel.Name = "JuliaPanel";
            this.JuliaPanel.Size = new System.Drawing.Size(951, 606);
            this.JuliaPanel.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.JuliaTimer);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaCY);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaCX);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaIterationsCount);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaYMax);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaYMin);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaXMax);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.JuliaXMin);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.JuliaPictureBox);
            this.splitContainer2.Size = new System.Drawing.Size(951, 606);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.TabIndex = 0;
            // 
            // JuliaTimer
            // 
            this.JuliaTimer.AutoSize = true;
            this.JuliaTimer.Location = new System.Drawing.Point(699, 66);
            this.JuliaTimer.Name = "JuliaTimer";
            this.JuliaTimer.Size = new System.Drawing.Size(44, 17);
            this.JuliaTimer.TabIndex = 18;
            this.JuliaTimer.Text = "Timer";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(855, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ResetJulia_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "X = -1.09, Y = 0.252",
            "X = -0.8, Y = 0.156",
            "X = 0.285, Y = 0.01",
            "X = -0.0058, Y = 0.71"});
            this.comboBox1.Location = new System.Drawing.Point(699, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(663, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "OR";
            // 
            // JuliaCY
            // 
            this.JuliaCY.Location = new System.Drawing.Point(589, 53);
            this.JuliaCY.Name = "JuliaCY";
            this.JuliaCY.Size = new System.Drawing.Size(70, 22);
            this.JuliaCY.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cᵧ";
            // 
            // JuliaCX
            // 
            this.JuliaCX.Location = new System.Drawing.Point(589, 12);
            this.JuliaCX.Name = "JuliaCX";
            this.JuliaCX.Size = new System.Drawing.Size(70, 22);
            this.JuliaCX.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cₓ";
            // 
            // JuliaIterationsCount
            // 
            this.JuliaIterationsCount.Location = new System.Drawing.Point(465, 30);
            this.JuliaIterationsCount.Name = "JuliaIterationsCount";
            this.JuliaIterationsCount.Size = new System.Drawing.Size(90, 22);
            this.JuliaIterationsCount.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Deep";
            // 
            // JuliaYMax
            // 
            this.JuliaYMax.Location = new System.Drawing.Point(311, 53);
            this.JuliaYMax.Name = "JuliaYMax";
            this.JuliaYMax.Size = new System.Drawing.Size(94, 22);
            this.JuliaYMax.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Max Y";
            // 
            // JuliaYMin
            // 
            this.JuliaYMin.Location = new System.Drawing.Point(311, 12);
            this.JuliaYMin.Name = "JuliaYMin";
            this.JuliaYMin.Size = new System.Drawing.Size(94, 22);
            this.JuliaYMin.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Min Y";
            // 
            // JuliaXMax
            // 
            this.JuliaXMax.Location = new System.Drawing.Point(157, 53);
            this.JuliaXMax.Name = "JuliaXMax";
            this.JuliaXMax.Size = new System.Drawing.Size(87, 22);
            this.JuliaXMax.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max X";
            // 
            // JuliaXMin
            // 
            this.JuliaXMin.Location = new System.Drawing.Point(157, 12);
            this.JuliaXMin.Name = "JuliaXMin";
            this.JuliaXMin.Size = new System.Drawing.Size(90, 22);
            this.JuliaXMin.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Min X";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 117);
            this.button3.TabIndex = 0;
            this.button3.Text = "Show image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowJuliaImage_Click);
            // 
            // JuliaPictureBox
            // 
            this.JuliaPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.JuliaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JuliaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.JuliaPictureBox.Name = "JuliaPictureBox";
            this.JuliaPictureBox.Size = new System.Drawing.Size(951, 516);
            this.JuliaPictureBox.TabIndex = 0;
            this.JuliaPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 606);
            this.Controls.Add(this.MandelbrotPanel);
            this.Controls.Add(this.JuliaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MandelbrotPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPictureBox)).EndInit();
            this.JuliaPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JuliaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.Panel MandelbrotPanel;
        private System.Windows.Forms.Panel JuliaPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox MandelbrotPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MandelbrotXMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MandelbrotXMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MandelbrotYMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MandelbrotYMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MandelbrotIterationsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MandelbrotTimerLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox JuliaPictureBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox JuliaXMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JuliaXMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox JuliaYMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox JuliaYMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox JuliaIterationsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox JuliaCY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox JuliaCX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label JuliaTimer;
    }
}

