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
        private MatrixCreator matrixCreator;
        private List<TextBox> boxes;
        private List<RadioButton> radioButtons;
        
        public Form1()
        {
            InitializeComponent();
            matrixCreator = new MatrixCreator();
            boxes = new List<TextBox>();
            radioButtons = new List<RadioButton>(){radioButton1,radioButton2,radioButton3};
            
        }


       
        
        
        private void ClearMatrix(List<TextBox> boxs){
            foreach (var box in boxs){
                Controls.Remove(box);
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e){
            if (rows.Text.Length > 0 && columns.Text.Length > 0){
                row = Int32.Parse(rows.Text);
                col = Int32.Parse(columns.Text);
                ClearMatrix(boxes);
                boxes = matrixCreator.CreateMatrixForInput(row,col);
                foreach (var box in boxes){
                    Controls.Add(box);
                }
                LatexOutput();
            }
        }

        private void LatexOutput(){
            if (rows.Text.Length > 0 && columns.Text.Length > 0){
                string ret = "";
                if (radioButton2.Checked)
                {
                    ret += "\\(";
                }
                else if (radioButton3.Checked)
                {
                    ret += "\\[";
                }
                
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
                    case "|":
                        ret += "\\left|";
                        retEnd += "\\right|";
                        break;
                }
                
                string spacing = String.Concat(Enumerable.Repeat("c", col));
                ret += $"\\begin{{array}}{{{spacing}}}\r\n";
                retEnd += "\n\\end{array}";
                
                if (radioButton2.Checked)
                {
                    retEnd += "\\)";
                }
                else if (radioButton3.Checked)
                {
                    retEnd += "\\]";
                }
                
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