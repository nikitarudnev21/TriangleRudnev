namespace TriangleRudnev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.listTriangle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureTriangle = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 24.75F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(659, 98);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(248, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Вычислить";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.UseWaitCursor = true;
            // 
            // listTriangle
            // 
            this.listTriangle.BackColor = System.Drawing.Color.Tan;
            this.listTriangle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Value});
            this.listTriangle.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.listTriangle.HideSelection = false;
            this.listTriangle.Location = new System.Drawing.Point(8, 181);
            this.listTriangle.Name = "listTriangle";
            this.listTriangle.Size = new System.Drawing.Size(902, 568);
            this.listTriangle.TabIndex = 1;
            this.listTriangle.UseCompatibleStateImageBehavior = false;
            this.listTriangle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поле";
            this.columnHeader1.Width = 500;
            // 
            // Value
            // 
            this.Value.Text = "Значения";
            this.Value.Width = 414;
            // 
            // pictureTriangle
            // 
            this.pictureTriangle.Location = new System.Drawing.Point(12, 12);
            this.pictureTriangle.Name = "pictureTriangle";
            this.pictureTriangle.Size = new System.Drawing.Size(188, 163);
            this.pictureTriangle.TabIndex = 2;
            this.pictureTriangle.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.lblA.Location = new System.Drawing.Point(376, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(139, 35);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Сторона A:";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.Menu;
            this.txtA.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.txtA.Location = new System.Drawing.Point(521, 38);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(115, 35);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.Menu;
            this.txtB.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.txtB.Location = new System.Drawing.Point(521, 84);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(115, 35);
            this.txtB.TabIndex = 6;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.lblB.Location = new System.Drawing.Point(376, 84);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(138, 35);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Сторона B:";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.Menu;
            this.txtC.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.txtC.Location = new System.Drawing.Point(521, 124);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(115, 35);
            this.txtC.TabIndex = 8;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.lblC.Location = new System.Drawing.Point(376, 124);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(137, 35);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "Сторона C:";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Checked = true;
            this.radio3.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.radio3.Location = new System.Drawing.Point(206, 80);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(149, 39);
            this.radio3.TabIndex = 9;
            this.radio3.TabStop = true;
            this.radio3.Text = "3 стороны";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Segoe Print", 14.75F);
            this.radio1.Location = new System.Drawing.Point(206, 124);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(146, 39);
            this.radio1.TabIndex = 10;
            this.radio1.Text = "1 сторона";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            this.btnForm2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnForm2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnForm2.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnForm2.FlatAppearance.BorderSize = 3;
            this.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm2.Font = new System.Drawing.Font("Segoe Print", 24.75F);
            this.btnForm2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnForm2.Location = new System.Drawing.Point(659, 19);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(0);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(248, 68);
            this.btnForm2.TabIndex = 11;
            this.btnForm2.Text = "2 форма";
            this.btnForm2.UseVisualStyleBackColor = false;
            this.btnForm2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 751);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pictureTriangle);
            this.Controls.Add(this.listTriangle);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Работа с треугольником";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView listTriangle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.PictureBox pictureTriangle;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.Button btnForm2;
    }
}

