using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMaker
{
    public partial class Form1 : Form
    {
        private int col = 0;
        private int row = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CreateMatrixForInput()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Controls.Remove(Controls.Find($"m{i}{j}", false)[0]);
                }
            }
            int tabIndex = 7;
            row =  Int32.Parse(rows.Text);
            col = Int32.Parse(columns.Text);
            if (rows.Text.Length > 0 && columns.Text.Length > 0){
                int c = 100;
                for (int i = 0; i < row; i++)
                {
                    int x = 30;
                    for (int j = 0; j < col; j++){
                        var field = new TextBox() ;
                        field.Location = new Point(10+x, c);
                        field.Margin = new Padding(4, 0, 4, 0);
                        field.Name =$"m{i}{j}";
                        field.Size = new Size(36, 20);
                        field.Text = "0";
                        field.TabIndex = tabIndex;
                        tabIndex++;
                        Controls.Add(field);
                        x += 38;
                    }
                    c += 25;
                }
            }
        }
        
        private void button1_MouseClick(object sender, MouseEventArgs e){
            if (rows.Text.Length > 0 && columns.Text.Length > 0){
                CreateMatrixForInput();
                LatexOutput();
            }
        }

        private void LatexOutput(){
            if (rows.Text.Length > 0 && columns.Text.Length > 0){
                string ret = "";
                string retEnd = "";
                switch (brackets.Text){
                    case "{":
                        ret += "\\left\\{";
                        retEnd += "\\right\\}";
                        break;
                    case "(":
                        ret += "\\left(";
                        retEnd += "\\right)";
                        break;
                    case "[":
                        ret += "\\left[";
                        retEnd += "\\right]";
                        break;
                }

                string spacing = String.Concat(Enumerable.Repeat("c", col));
                ret += $"\\begin{{array}}{{{spacing}}}\r\n";
                retEnd += "\n\\end{array}";
                output.Text = ret;
                for (int i = 0; i < row; i++){
                    for (int j = 0; j < col; j++)
                    {
                        string fieldText = Controls.Find($"m{i}{j}", false)[0].Text;
                        string[] units = Regex.Split(fieldText, @"\/\+\-\*\^");
                        output.Text += fieldText+"&";
                    }
                    output.Text += "\\\\\r\n";
                }
                output.Text += retEnd;
            }
        }
        
        private void button2_MouseClick(object sender, MouseEventArgs e){
            LatexOutput();
        }
    }
}