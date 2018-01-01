﻿namespace Pk3DSRNGTool.Subforms
{
    partial class MiscTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_Delay = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.L_NPC = new System.Windows.Forms.Label();
            this.NPC = new System.Windows.Forms.NumericUpDown();
            this.MaxResults = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.StartingFrame = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Seed = new Pk3DSRNGTool.Controls.HexMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RNG = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_hit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_blink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_pokerus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_capture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_randn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rand32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rand64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_realtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.RB_Capture = new System.Windows.Forms.RadioButton();
            this.B_ResetFrame = new System.Windows.Forms.Button();
            this.Range = new System.Windows.Forms.NumericUpDown();
            this.Value = new System.Windows.Forms.NumericUpDown();
            this.Compare = new System.Windows.Forms.ComboBox();
            this.RB_Random = new System.Windows.Forms.RadioButton();
            this.RB_Pokerus = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentText = new System.Windows.Forms.TextBox();
            this.B_Calc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_Delay);
            this.groupBox1.Controls.Add(this.Delay);
            this.groupBox1.Controls.Add(this.L_NPC);
            this.groupBox1.Controls.Add(this.NPC);
            this.groupBox1.Controls.Add(this.MaxResults);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StartingFrame);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Seed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RNG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RNGInfo";
            // 
            // L_Delay
            // 
            this.L_Delay.AutoSize = true;
            this.L_Delay.Location = new System.Drawing.Point(6, 188);
            this.L_Delay.Name = "L_Delay";
            this.L_Delay.Size = new System.Drawing.Size(34, 13);
            this.L_Delay.TabIndex = 51;
            this.L_Delay.Text = "Delay";
            // 
            // Delay
            // 
            this.Delay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delay.Location = new System.Drawing.Point(46, 183);
            this.Delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(49, 22);
            this.Delay.TabIndex = 50;
            // 
            // L_NPC
            // 
            this.L_NPC.AutoSize = true;
            this.L_NPC.Location = new System.Drawing.Point(101, 188);
            this.L_NPC.Name = "L_NPC";
            this.L_NPC.Size = new System.Drawing.Size(29, 13);
            this.L_NPC.TabIndex = 49;
            this.L_NPC.Text = "NPC";
            // 
            // NPC
            // 
            this.NPC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPC.Location = new System.Drawing.Point(136, 183);
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(42, 22);
            this.NPC.TabIndex = 48;
            // 
            // MaxResults
            // 
            this.MaxResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxResults.Location = new System.Drawing.Point(98, 142);
            this.MaxResults.Name = "MaxResults";
            this.MaxResults.Size = new System.Drawing.Size(80, 22);
            this.MaxResults.TabIndex = 5;
            this.MaxResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Results";
            // 
            // StartingFrame
            // 
            this.StartingFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingFrame.Location = new System.Drawing.Point(98, 104);
            this.StartingFrame.Name = "StartingFrame";
            this.StartingFrame.Size = new System.Drawing.Size(80, 22);
            this.StartingFrame.TabIndex = 1;
            this.StartingFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Starting Frame";
            // 
            // Seed
            // 
            this.Seed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seed.Location = new System.Drawing.Point(111, 66);
            this.Seed.Mask = "AAAAAAAA";
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(67, 23);
            this.Seed.TabIndex = 1;
            this.Seed.Text = "00000000";
            this.Seed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Seed.Value = ((uint)(0u));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RNG";
            // 
            // RNG
            // 
            this.RNG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RNG.FormattingEnabled = true;
            this.RNG.Items.AddRange(new object[] {
            "G7 SFMT (64bit)",
            "G7 SFMT (64bit) - T",
            "G7 SFMT (32bit)",
            "G6 MT"});
            this.RNG.Location = new System.Drawing.Point(74, 29);
            this.RNG.Name = "RNG";
            this.RNG.Size = new System.Drawing.Size(104, 21);
            this.RNG.TabIndex = 1;
            this.RNG.SelectedIndexChanged += new System.EventHandler(this.RNG_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_frame,
            this.dgv_hit,
            this.dgv_blink,
            this.dgv_clock,
            this.dgv_pokerus,
            this.dgv_capture,
            this.dgv_randn,
            this.dgv_rand32,
            this.dgv_rand64,
            this.dgv_realtime,
            this.dgv_status});
            this.dataGridView1.Location = new System.Drawing.Point(216, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 18;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(456, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgv_frame
            // 
            this.dgv_frame.DataPropertyName = "Frame";
            this.dgv_frame.HeaderText = "Frame";
            this.dgv_frame.Name = "dgv_frame";
            this.dgv_frame.ReadOnly = true;
            this.dgv_frame.Width = 55;
            // 
            // dgv_hit
            // 
            this.dgv_hit.DataPropertyName = "ActualFrame";
            this.dgv_hit.HeaderText = "Actual Hit";
            this.dgv_hit.Name = "dgv_hit";
            this.dgv_hit.ReadOnly = true;
            this.dgv_hit.Visible = false;
            this.dgv_hit.Width = 55;
            // 
            // dgv_blink
            // 
            this.dgv_blink.DataPropertyName = "Blinkflag";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_blink.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_blink.HeaderText = "Blink";
            this.dgv_blink.Name = "dgv_blink";
            this.dgv_blink.ReadOnly = true;
            this.dgv_blink.Width = 35;
            // 
            // dgv_clock
            // 
            this.dgv_clock.DataPropertyName = "Clock";
            this.dgv_clock.HeaderText = "Clk";
            this.dgv_clock.Name = "dgv_clock";
            this.dgv_clock.ReadOnly = true;
            this.dgv_clock.Width = 35;
            // 
            // dgv_pokerus
            // 
            this.dgv_pokerus.DataPropertyName = "Pokerus";
            this.dgv_pokerus.HeaderText = "Pokerus";
            this.dgv_pokerus.Name = "dgv_pokerus";
            this.dgv_pokerus.ReadOnly = true;
            this.dgv_pokerus.Width = 55;
            // 
            // dgv_capture
            // 
            this.dgv_capture.DataPropertyName = "Capture";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_capture.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_capture.HeaderText = "Capture";
            this.dgv_capture.Name = "dgv_capture";
            this.dgv_capture.ReadOnly = true;
            this.dgv_capture.Visible = false;
            this.dgv_capture.Width = 70;
            // 
            // dgv_randn
            // 
            this.dgv_randn.DataPropertyName = "RandN";
            this.dgv_randn.HeaderText = "RN";
            this.dgv_randn.Name = "dgv_randn";
            this.dgv_randn.ReadOnly = true;
            this.dgv_randn.Width = 40;
            // 
            // dgv_rand32
            // 
            this.dgv_rand32.DataPropertyName = "Rand32";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "X8";
            this.dgv_rand32.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rand32.HeaderText = "Random#";
            this.dgv_rand32.Name = "dgv_rand32";
            this.dgv_rand32.ReadOnly = true;
            this.dgv_rand32.Visible = false;
            this.dgv_rand32.Width = 70;
            // 
            // dgv_rand64
            // 
            this.dgv_rand64.DataPropertyName = "Rand64";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "X16";
            this.dgv_rand64.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_rand64.HeaderText = "Random Number";
            this.dgv_rand64.Name = "dgv_rand64";
            this.dgv_rand64.ReadOnly = true;
            this.dgv_rand64.Width = 123;
            // 
            // dgv_realtime
            // 
            this.dgv_realtime.DataPropertyName = "Realtime";
            this.dgv_realtime.HeaderText = "Real Time";
            this.dgv_realtime.Name = "dgv_realtime";
            this.dgv_realtime.ReadOnly = true;
            this.dgv_realtime.Width = 80;
            // 
            // dgv_status
            // 
            this.dgv_status.DataPropertyName = "NPCStatus";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_status.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_status.HeaderText = "NPC";
            this.dgv_status.Name = "dgv_status";
            this.dgv_status.ReadOnly = true;
            this.dgv_status.Visible = false;
            this.dgv_status.Width = 40;
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.RB_Capture);
            this.Filters.Controls.Add(this.B_ResetFrame);
            this.Filters.Controls.Add(this.Range);
            this.Filters.Controls.Add(this.Value);
            this.Filters.Controls.Add(this.Compare);
            this.Filters.Controls.Add(this.RB_Random);
            this.Filters.Controls.Add(this.RB_Pokerus);
            this.Filters.Controls.Add(this.label5);
            this.Filters.Controls.Add(this.CurrentText);
            this.Filters.Location = new System.Drawing.Point(12, 243);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(198, 196);
            this.Filters.TabIndex = 52;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filters";
            // 
            // RB_Capture
            // 
            this.RB_Capture.AutoSize = true;
            this.RB_Capture.Location = new System.Drawing.Point(104, 134);
            this.RB_Capture.Name = "RB_Capture";
            this.RB_Capture.Size = new System.Drawing.Size(62, 17);
            this.RB_Capture.TabIndex = 102;
            this.RB_Capture.Text = "Capture";
            this.RB_Capture.UseVisualStyleBackColor = true;
            this.RB_Capture.CheckedChanged += new System.EventHandler(this.Method_CheckedChanged);
            // 
            // B_ResetFrame
            // 
            this.B_ResetFrame.Image = global::Pk3DSRNGTool.Properties.Resources.Reset;
            this.B_ResetFrame.Location = new System.Drawing.Point(165, 24);
            this.B_ResetFrame.Name = "B_ResetFrame";
            this.B_ResetFrame.Size = new System.Drawing.Size(27, 25);
            this.B_ResetFrame.TabIndex = 101;
            this.B_ResetFrame.UseVisualStyleBackColor = true;
            this.B_ResetFrame.Click += new System.EventHandler(this.B_ResetFrame_Click);
            // 
            // Range
            // 
            this.Range.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Range.Location = new System.Drawing.Point(98, 65);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(71, 22);
            this.Range.TabIndex = 57;
            this.Range.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(98, 97);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(71, 22);
            this.Value.TabIndex = 52;
            this.Value.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Compare
            // 
            this.Compare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compare.FormattingEnabled = true;
            this.Compare.Items.AddRange(new object[] {
            "<",
            ">=",
            "="});
            this.Compare.Location = new System.Drawing.Point(17, 96);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(54, 21);
            this.Compare.TabIndex = 54;
            // 
            // RB_Random
            // 
            this.RB_Random.AutoSize = true;
            this.RB_Random.Checked = true;
            this.RB_Random.Location = new System.Drawing.Point(16, 65);
            this.RB_Random.Name = "RB_Random";
            this.RB_Random.Size = new System.Drawing.Size(76, 17);
            this.RB_Random.TabIndex = 56;
            this.RB_Random.TabStop = true;
            this.RB_Random.Text = "Random N";
            this.RB_Random.UseVisualStyleBackColor = true;
            this.RB_Random.CheckedChanged += new System.EventHandler(this.Method_CheckedChanged);
            // 
            // RB_Pokerus
            // 
            this.RB_Pokerus.AutoSize = true;
            this.RB_Pokerus.Location = new System.Drawing.Point(17, 134);
            this.RB_Pokerus.Name = "RB_Pokerus";
            this.RB_Pokerus.Size = new System.Drawing.Size(64, 17);
            this.RB_Pokerus.TabIndex = 55;
            this.RB_Pokerus.Text = "Pokerus";
            this.RB_Pokerus.UseVisualStyleBackColor = true;
            this.RB_Pokerus.CheckedChanged += new System.EventHandler(this.Method_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Current";
            // 
            // CurrentText
            // 
            this.CurrentText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentText.Location = new System.Drawing.Point(69, 27);
            this.CurrentText.Name = "CurrentText";
            this.CurrentText.Size = new System.Drawing.Size(90, 22);
            this.CurrentText.TabIndex = 54;
            // 
            // B_Calc
            // 
            this.B_Calc.Location = new System.Drawing.Point(135, 445);
            this.B_Calc.Name = "B_Calc";
            this.B_Calc.Size = new System.Drawing.Size(75, 23);
            this.B_Calc.TabIndex = 53;
            this.B_Calc.Text = "Search";
            this.B_Calc.UseVisualStyleBackColor = true;
            this.B_Calc.Click += new System.EventHandler(this.B_Calc_Click);
            // 
            // MiscTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 482);
            this.Controls.Add(this.B_Calc);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(700, 520);
            this.Name = "MiscTool";
            this.Text = "MiscTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RNG;
        private Controls.HexMaskedTextBox Seed;
        private System.Windows.Forms.NumericUpDown MaxResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StartingFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label L_Delay;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.Label L_NPC;
        private System.Windows.Forms.NumericUpDown NPC;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.Button B_Calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CurrentText;
        private System.Windows.Forms.RadioButton RB_Pokerus;
        private System.Windows.Forms.RadioButton RB_Random;
        private System.Windows.Forms.ComboBox Compare;
        private System.Windows.Forms.NumericUpDown Value;
        private System.Windows.Forms.NumericUpDown Range;
        private System.Windows.Forms.Button B_ResetFrame;
        private System.Windows.Forms.RadioButton RB_Capture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_hit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_blink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_pokerus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_capture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_randn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_rand32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_rand64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_realtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_status;
    }
}