using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixMaker
{
    public class MatrixCreator : Form
    {
        
        public MatrixCreator()
        {
         
        }

        
        
        public List<TextBox> CreateMatrixForInput(int rows, int cols){
            var boxes = new List<TextBox>();   
            int tabIndex = 10;
            int c = 100;
            for (int i = 0; i < rows; i++){
                int x = 30;
                for (int j = 0; j < cols; j++){
                    var field = new TextBox() ;
                    field.Location = new Point(10+x, c);
                    field.Margin = new Padding(4, 0, 4, 0);
                    field.Name =$"m{i}{j}";
                    field.Size = new Size(36, 20);
                    field.Text = "0";
                    field.TabIndex = tabIndex;
                    tabIndex++;
                    boxes.Add(field);
                    x += 38;
                }
                c += 25;
            }

            return boxes;
        }
    } 
}
