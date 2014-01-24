using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompoundAssignments
{
    public partial class CompoundAssignments : Form
    {
        public CompoundAssignments()
        {
            InitializeComponent();
            MessageBox.Show("Enter a letter into the textbox");

            // Select the first item in the combo box.
            gridSizeComboBox.SelectedIndex = 0;

            // Prefix
            string prefixValues = "0 ";
            int result = 0;
            int value = 1;
            for (int i = 1; i <= 4; i++)
            {
                result += ++value;
                prefixValues += result + " ";
            }

            // Postfix
            string postfixValues = "0 ";
            result = 0;
            value = 1;
            for (int i = 1; i <= 4; i++)
            {
                result += value++;
                postfixValues += result + " ";
            }

            Console.WriteLine("Prefix: " + prefixValues);
            Console.WriteLine("Postfix: " + postfixValues);

        }

        private void DrawGrid(Graphics drawingArea)
        {
             float gridMargin = 10.0F;       // Margin to keep grid away from group box edge.
            int gridSize = 0;               // Grid size, i.e. 4x4, 10x10, etc.
            
            // Try to convert the grid size in the combo box to an integer.
            if (Int32.TryParse(gridSizeComboBox.Text, out gridSize))
            {
                // Make sure we have a grid size > 0 before we attempt to draw grid.
                if (gridSize > 0)
                {
                    // Create a pen object for drawing.
                    Pen redPen = new Pen(Color.Red, 2);
                    Pen bluePen = new Pen(Color.Blue, 2);
                    
                    // Use the smaller of the drawing area width or height to ensure a uniform grid spacing.
                    float gridWidth = drawingArea.VisibleClipBounds.Width;
                    if (drawingArea.VisibleClipBounds.Height < gridWidth)
                        gridWidth = drawingArea.VisibleClipBounds.Height;
                    
                    // Subtract the margin value.
                    gridWidth -= gridMargin * 2;
                    
                    // Determine grid cell width.
                    float cellWidth = gridWidth / gridSize;
                    
                    // Set up starting x and y coordinates for both horizontal and vertical lines.
                    float horizontalX = gridMargin;
                    float horizontalY = 0;
                    float verticalX = 0;
                    float verticalY = gridMargin;
                    
                    // The number of lines in grid is equal to the size of the grid plus 1, so loop over size of grid + 1,
                    // drawing horizontal and vertical lines.
                    for (int i = 0; i < gridSize + 1; i++)
                    {
                        // Select pen, red for even, blue for odd.
                        Pen pen = bluePen;
                        if (i % 2 == 0)
                            pen = redPen;

                        // Draw horizontal lines.
                        Console.WriteLine("Horizontal: ({0},{1}) to ({2},{3})", horizontalX, horizontalY + gridMargin, horizontalX + gridWidth, horizontalY + gridMargin);
                        drawingArea.DrawLine(pen, horizontalX, horizontalY + gridMargin, horizontalX + gridWidth, horizontalY + gridMargin);
                        horizontalY += cellWidth;
                        
                        // Draw vertical lines.
                        Console.WriteLine("Vertical: ({0},{1}) to ({2},{3})", verticalX + gridMargin, verticalY, verticalX + gridMargin, verticalY + gridWidth);
                        drawingArea.DrawLine(pen, verticalX + gridMargin, verticalY, verticalX + gridMargin, verticalY + gridWidth);
                        verticalX += cellWidth;

                        if (i < gridSize)
                        {
                            float x1 = horizontalX;
                            for (int b = 0; b < gridSize; b++)
                            {
                                drawLetter(drawingArea, x1, horizontalY - gridMargin, gridSize);
                                x1 += cellWidth;
                            }
                        }


                    }
                }
            }
        }

        private void drawLetter(System.Drawing.Graphics drawingArea, float x, float y, int gridSize)
        {

            //int gridSize = 0;               // Grid size, i.e. 4x4, 10x10, etc.
            Brush blackBrush = Brushes.Black;
            Font timesFont = new Font("Times New Roman", 12.0f);
            string letter = "A";

            if (letterTextBox.Text != "")
            {
                letter = letterTextBox.Text;
                if (gridSizeComboBox.SelectedIndex == gridSizeComboBox.FindStringExact("4"))
                {
                    timesFont = new Font("Times New Roman", 12.0f);
                }

                if (gridSizeComboBox.SelectedIndex == gridSizeComboBox.FindStringExact("10"))
                {
                    timesFont = new Font("Times New Roman", 12.0f -4.0f);
                    
                }
                if (gridSizeComboBox.SelectedIndex == gridSizeComboBox.FindStringExact("20"))
                {
                    timesFont = new Font("Times New Roman", 12.0f -9.0f);
                    
                }
                drawingArea.DrawString(letter, timesFont, blackBrush, new PointF(x, y));


            }
        }

        private void gridSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Notify the group box control that it should redraw itself, which will call the Paint event below.
            drawGroupBox.Refresh();
        }

        private void drawGroupBox_Paint(object sender, PaintEventArgs e)
        {
            // Call the base class OnPaint event to ensure any other controls that need to be redrawn are also redrawn.
            base.OnPaint(e);
            // Call our draw grid method.
            DrawGrid(e.Graphics);
           
        }

        private void letterTextBox_TextChanged(object sender, EventArgs e)
        {
            // Notify the group box control that it should redraw itself, which will call the Paint event below.
            drawGroupBox.Refresh();
        }

        
            
        }
}
      



