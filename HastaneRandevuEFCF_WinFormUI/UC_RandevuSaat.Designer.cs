
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRandevuButtonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelRandevuButtonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(13, 39);
            this.comboBoxSaatler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(277, 24);
            this.comboBoxSaatler.TabIndex = 0;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAAT SEÇ:";
            // 
            // tableLayoutPanelRandevuButtonlar
            // 
            this.tableLayoutPanelRandevuButtonlar.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanelRandevuButtonlar.ColumnCount = 2;
            this.tableLayoutPanelRandevuButtonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn15, 1, 0);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn45, 1, 1);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanelRandevuButtonlar.Controls.Add(this.btn30, 0, 1);
            this.tableLayoutPanelRandevuButtonlar.Location = new System.Drawing.Point(13, 83);
            this.tableLayoutPanelRandevuButtonlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelRandevuButtonlar.Name = "tableLayoutPanelRandevuButtonlar";
            this.tableLayoutPanelRandevuButtonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButtonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButtonlar.Size = new System.Drawing.Size(277, 133);
            this.tableLayoutPanelRandevuButtonlar.TabIndex = 1;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn15.Location = new System.Drawing.Point(141, 2);
            this.btn15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(133, 60);
            this.btn15.TabIndex = 1;
            this.btn15.Text = "button2";
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // btn45
            // 
            this.btn45.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn45.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn45.Location = new System.Drawing.Point(141, 68);
            this.btn45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(133, 62);
            this.btn45.TabIndex = 3;
            this.btn45.Text = "button4";
            this.btn45.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn00.Location = new System.Drawing.Point(3, 2);
            this.btn00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(132, 60);
            this.btn00.TabIndex = 0;
            this.btn00.Text = "button1";
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // btn30
            // 
            this.btn30.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn30.Location = new System.Drawing.Point(3, 68);
            this.btn30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(132, 62);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "button3";
            this.btn30.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_RandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSaatler);
            this.Controls.Add(this.tableLayoutPanelRandevuButtonlar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_RandevuSaat";
            this.Size = new System.Drawing.Size(302, 230);
            this.Load += new System.EventHandler(this.UC_RandevuSaat_Load);
            this.tableLayoutPanelRandevuButtonlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRandevuButtonlar;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Timer timer1;
    }
}
