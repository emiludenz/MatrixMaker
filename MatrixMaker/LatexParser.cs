using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MatrixMaker
{
    public class LatexParser : Form
    {
        public LatexParser()
        {
            
        }

        public string Math(List<RadioButton> rButtons)
        {
            string ans = "" ;
            foreach (var r in rButtons){
                if (r.Checked)
                {
                    ans = r.Text;    
                }
            }

            string ret = "";
            switch (ans){
                case "Inline Math":
                    ret="\\(";
                    break;
                case "Math Field":
                    ret="\\[";
                    break;
            }

            return ret;
        }
        
        public string LatexOutput(List<TextBox> boxes, string brackets){
            string ret = "";
            
            //if (radioButton2.Checked){ret += "\\(";}
            //else if (radioButton3.Checked){ret += "\\[";}
                
            string retEnd = ""; 
            switch (brackets){
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
            
            
            //if (radioButton2.Checked){retEnd += "\\)";}
            //else if (radioButton3.Checked){retEnd += "\\]";}
            foreach (var box in boxes){
                
            }
            
            for (int i = 0; i < row; i++){
                for (int j = 0; j < col; j++)
                {
                    string fieldText = Controls.Find($"m{i}{j}", false)[0].Text;
                    string[] units = Regex.Split(fieldText, @"\/\+\-\*\^");
                   ret += fieldText+"&";
                }
                ret += "\\\\\r\n";
            }
            ret += retEnd;
            return ret;
        }
    }
}