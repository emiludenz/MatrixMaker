using System.Collections.Generic;
using System.Windows.Forms;

namespace MatrixMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.TextBox();
            this.columns = new System.Windows.Forms.TextBox();
            this.brackets = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.Button();
            this.latex = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns";
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(81, 12);
            this.rows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(37, 23);
            this.rows.TabIndex = 1;
            // 
            // columns
            // 
            this.columns.Location = new System.Drawing.Point(81, 42);
            this.columns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(37, 23);
            this.columns.TabIndex = 2;
            // 
            // brackets
            // 
            this.brackets.FormattingEnabled = true;
            this.brackets.Items.AddRange(new object[] {"{", "[", "(", "|", " "});
            this.brackets.Location = new System.Drawing.Point(81, 71);
            this.brackets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.brackets.Name = "brackets";
            this.brackets.Size = new System.Drawing.Size(39, 23);
            this.brackets.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brackets";
            // 
            // matrix
            // 
            this.matrix.Location = new System.Drawing.Point(517, 12);
            this.matrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(55, 43);
            this.matrix.TabIndex = 4;
            this.matrix.Text = "Create Matrix";
            this.matrix.UseVisualStyleBackColor = true;
            this.matrix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // latex
            // 
            this.latex.Location = new System.Drawing.Point(474, 66);
            this.latex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.latex.Name = "latex";
            this.latex.Size = new System.Drawing.Size(132, 31);
            this.latex.TabIndex = 5;
            this.latex.Text = "Create LaTeX Output";
            this.latex.UseVisualStyleBackColor = true;
            this.latex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(150, 12);
            this.output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(298, 85);
            this.output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.output);
            this.Controls.Add(this.latex);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.brackets);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MatrixMaker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.TextBox columns;
        private System.Windows.Forms.Button matrix;
        private System.Windows.Forms.ComboBox brackets;
        private System.Windows.Forms.Button latex;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label3;
    }
}