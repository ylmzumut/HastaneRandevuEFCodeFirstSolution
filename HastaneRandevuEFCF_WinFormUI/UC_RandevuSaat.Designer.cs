﻿
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class UC_RandevuSaat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn0015 = new System.Windows.Forms.Button();
            this.btn1530 = new System.Windows.Forms.Button();
            this.btn3045 = new System.Windows.Forms.Button();
            this.btn4500 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(3, 34);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(277, 24);
            this.comboBoxSaatler.TabIndex = 0;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAAT SEÇ:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn1530, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn4500, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn0015, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn3045, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(277, 133);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn0015
            // 
            this.btn0015.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn0015.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0015.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0015.Location = new System.Drawing.Point(3, 3);
            this.btn0015.Name = "btn0015";
            this.btn0015.Size = new System.Drawing.Size(132, 60);
            this.btn0015.TabIndex = 0;
            this.btn0015.Text = "button1";
            this.btn0015.UseVisualStyleBackColor = false;
            // 
            // btn1530
            // 
            this.btn1530.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn1530.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1530.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1530.Location = new System.Drawing.Point(141, 3);
            this.btn1530.Name = "btn1530";
            this.btn1530.Size = new System.Drawing.Size(133, 60);
            this.btn1530.TabIndex = 1;
            this.btn1530.Text = "button2";
            this.btn1530.UseVisualStyleBackColor = false;
            // 
            // btn3045
            // 
            this.btn3045.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn3045.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3045.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3045.Location = new System.Drawing.Point(3, 69);
            this.btn3045.Name = "btn3045";
            this.btn3045.Size = new System.Drawing.Size(132, 61);
            this.btn3045.TabIndex = 2;
            this.btn3045.Text = "button3";
            this.btn3045.UseVisualStyleBackColor = false;
            // 
            // btn4500
            // 
            this.btn4500.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn4500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4500.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4500.Location = new System.Drawing.Point(141, 69);
            this.btn4500.Name = "btn4500";
            this.btn4500.Size = new System.Drawing.Size(133, 61);
            this.btn4500.TabIndex = 3;
            this.btn4500.Text = "button4";
            this.btn4500.UseVisualStyleBackColor = false;
            // 
            // UC_RandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSaatler);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UC_RandevuSaat";
            this.Size = new System.Drawing.Size(285, 232);
            this.Load += new System.EventHandler(this.UC_RandevuSaat_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn1530;
        private System.Windows.Forms.Button btn4500;
        private System.Windows.Forms.Button btn0015;
        private System.Windows.Forms.Button btn3045;
    }
}
