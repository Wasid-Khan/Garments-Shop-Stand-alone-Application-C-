
namespace KatunSHOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ImgCash = new System.Windows.Forms.PictureBox();
            this.ImgCashBack = new System.Windows.Forms.PictureBox();
            this.txtBoxCashBack = new System.Windows.Forms.TextBox();
            this.txtBoxCash = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProductWindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCashBack)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 704);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(21, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 349);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.ImgCash);
            this.panel5.Controls.Add(this.ImgCashBack);
            this.panel5.Controls.Add(this.txtBoxCashBack);
            this.panel5.Controls.Add(this.txtBoxCash);
            this.panel5.Location = new System.Drawing.Point(18, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 317);
            this.panel5.TabIndex = 2;
            // 
            // ImgCash
            // 
            this.ImgCash.Image = ((System.Drawing.Image)(resources.GetObject("ImgCash.Image")));
            this.ImgCash.Location = new System.Drawing.Point(322, 3);
            this.ImgCash.Name = "ImgCash";
            this.ImgCash.Size = new System.Drawing.Size(103, 60);
            this.ImgCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCash.TabIndex = 3;
            this.ImgCash.TabStop = false;
            // 
            // ImgCashBack
            // 
            this.ImgCashBack.Image = ((System.Drawing.Image)(resources.GetObject("ImgCashBack.Image")));
            this.ImgCashBack.Location = new System.Drawing.Point(11, 192);
            this.ImgCashBack.Name = "ImgCashBack";
            this.ImgCashBack.Size = new System.Drawing.Size(186, 118);
            this.ImgCashBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCashBack.TabIndex = 2;
            this.ImgCashBack.TabStop = false;
            // 
            // txtBoxCashBack
            // 
            this.txtBoxCashBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCashBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCashBack.Location = new System.Drawing.Point(203, 192);
            this.txtBoxCashBack.Multiline = true;
            this.txtBoxCashBack.Name = "txtBoxCashBack";
            this.txtBoxCashBack.ReadOnly = true;
            this.txtBoxCashBack.Size = new System.Drawing.Size(222, 118);
            this.txtBoxCashBack.TabIndex = 1;
            this.txtBoxCashBack.Text = "€";
            this.txtBoxCashBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxCash
            // 
            this.txtBoxCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCash.Location = new System.Drawing.Point(3, 3);
            this.txtBoxCash.Multiline = true;
            this.txtBoxCash.Name = "txtBoxCash";
            this.txtBoxCash.Size = new System.Drawing.Size(194, 60);
            this.txtBoxCash.TabIndex = 0;
            this.txtBoxCash.Text = "00.00";
            this.txtBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCash_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtBoxTotalPrice);
            this.panel4.Location = new System.Drawing.Point(456, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 317);
            this.panel4.TabIndex = 1;
            // 
            // txtBoxTotalPrice
            // 
            this.txtBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(3, 3);
            this.txtBoxTotalPrice.Multiline = true;
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.ReadOnly = true;
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(423, 118);
            this.txtBoxTotalPrice.TabIndex = 0;
            this.txtBoxTotalPrice.Text = "00.00 €";
            this.txtBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxInput);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(21, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 282);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode INPUT:";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxInput.Location = new System.Drawing.Point(119, 246);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(187, 20);
            this.txtBoxInput.TabIndex = 1;
            this.txtBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxInput_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnProductWindow
            // 
            this.btnProductWindow.Location = new System.Drawing.Point(12, 4);
            this.btnProductWindow.Name = "btnProductWindow";
            this.btnProductWindow.Size = new System.Drawing.Size(54, 23);
            this.btnProductWindow.TabIndex = 2;
            this.btnProductWindow.Text = "Add";
            this.btnProductWindow.UseVisualStyleBackColor = true;
            this.btnProductWindow.Click += new System.EventHandler(this.btnProductWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(964, 749);
            this.Controls.Add(this.btnProductWindow);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 726);
            this.Name = "MainForm";
            this.Text = "Pemtaria n\'Katun";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCashBack)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxTotalPrice;
        private System.Windows.Forms.TextBox txtBoxCashBack;
        private System.Windows.Forms.TextBox txtBoxCash;
        private System.Windows.Forms.PictureBox ImgCashBack;
        private System.Windows.Forms.PictureBox ImgCash;
        private System.Windows.Forms.Button btnProductWindow;
    }
}