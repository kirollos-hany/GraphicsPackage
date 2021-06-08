using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GraphicsPackage.Algorithms;
namespace GraphicsPackage
{
    public partial class BresenhamLineForm : Form
    {
        private BresenhamLine bresenhamLine;
        private Bitmap picBitmap;
        private Bitmap pixelToDraw;
        private Graphics picBoxGraphics;
        private bool isMouseClicked;
        private int xStart, yStart, xEnd, yEnd;
        private int pixelWidth, pixelHeight;
        private int linesDrawn;
        private bool fromDrawBtn;
        public BresenhamLineForm()
        {
            InitializeComponent();
            fromDrawBtn = false;
            linesDrawn = 0;
            isMouseClicked = false;
            pixelWidth = 1;
            pixelHeight = 1;
            bresenhamLine = new BresenhamLine();
            picToDrawLine.MouseClick += OnMouseClicked;
            picToDrawLine.MouseDoubleClick += OnMouseDoubleClick;
            picBitmap = new Bitmap(picToDrawLine.Width, picToDrawLine.Height);
            picToDrawLine.Image = picBitmap;
            picBoxGraphics = picToDrawLine.CreateGraphics();
            pixelToDraw = new Bitmap(pixelWidth, pixelHeight);
            clearBtn.Click += OnClearBtnClicked;
            drawBtn.Click += OnDrawBtnClicked;
            backBtn.Click += OnBackBtnClicked;
            FormClosing += OnFormClosing;
            xRangeLabel.Text = $"{-picToDrawLine.Width} < X < {picToDrawLine.Width}";
            yRangeLabel.Text = $"{-picToDrawLine.Height} < Y < {picToDrawLine.Height}";
        }
        private void SetPixel(int x, int y)
        {
            lock (picBoxGraphics)
            {
                if (x < 0)
                {
                    x *= -1;
                }
                if (y < 0)
                {
                    y *= -1;
                }
                x %= picToDrawLine.Width;
                y %= picToDrawLine.Height;
                pixelToDraw.SetPixel(0, 0, Color.Black);
                picBoxGraphics.DrawImage(pixelToDraw, x, y);
            }
        }

        public void OnMouseClicked(Object source, MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button == MouseButtons.Left && !isMouseClicked)
            {
                isMouseClicked = true;
                xStart = mouseEventArgs.X;
                yStart = mouseEventArgs.Y;
            }
        }
        public void OnMouseDoubleClick(Object source, MouseEventArgs mouseEventArgs)
        {
            if (isMouseClicked && mouseEventArgs.Button == MouseButtons.Left)
            {
                xEnd = mouseEventArgs.X;
                yEnd = mouseEventArgs.Y;
                DrawLine();
                isMouseClicked = false;
            }
        }
        private void DrawLine()
        {
            bresenhamLine.Algorithm(xStart, yStart, xEnd, yEnd);
            for (int i = 0; i < bresenhamLine.XPoints.Count; i++)
            {
                if (fromDrawBtn)
                {
                    int x = picToDrawLine.Width / 2 + Convert.ToInt32(bresenhamLine.XPoints[i]);
                    int y = picToDrawLine.Height / 2 - Convert.ToInt32(bresenhamLine.YPoints[i]);
                    SetPixel(x, y);
                }
                else
                {
                    SetPixel(Convert.ToInt32(bresenhamLine.XPoints[i]), Convert.ToInt32(bresenhamLine.YPoints[i]));
                }
                
            }
            fromDrawBtn = false;
            linesDrawn++;
            OnLineDrawn();
        }
        private void OnLineDrawn()
        {
            for (int i = 0; i < bresenhamLine.XPoints.Count; i++)
            {
                string iStr = i.ToString();
                string slope = bresenhamLine.Slope.ToString();
                string x = bresenhamLine.XPoints[i].ToString();
                string y = bresenhamLine.YPoints[i].ToString();
                string pk = bresenhamLine.PKPoints[i].ToString();
                string[] tableRow = { linesDrawn.ToString(), bresenhamLine.Octant, slope, iStr, pk,x, y, $"({x},{y})" };
                linesResultTable.Rows.Add(tableRow);
            }
        }
        private void OnClearBtnClicked(object source, EventArgs args)
        {
            picBoxGraphics.Clear(Color.RoyalBlue);
            xStartTextBox.Clear();
            yStartTextBox.Clear();
            xEndTextBox.Clear();
            yEndTextBox.Clear();
            linesResultTable.Rows.Clear();
            linesDrawn = 0;
        }
        private void OnDrawBtnClicked(object source, EventArgs args)
        {
            try
            {
                if (!string.IsNullOrEmpty(xStartTextBox.Text) && !string.IsNullOrEmpty(yStartTextBox.Text)
                    && !string.IsNullOrEmpty(xEndTextBox.Text) && !string.IsNullOrEmpty(yEndTextBox.Text))
                {
                    xStart = Convert.ToInt32(xStartTextBox.Text);
                    yStart = Convert.ToInt32(yStartTextBox.Text);
                    xEnd = Convert.ToInt32(xEndTextBox.Text);
                    yEnd = Convert.ToInt32(yEndTextBox.Text);
                    fromDrawBtn = true;
                    DrawLine();
            
                }
                else
                {
                    MessageBox.Show("Please enter all required points", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numbers please enter a valid integer", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow.. please enter a smaller value", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnBackBtnClicked(object source, EventArgs args)
        {
            Close();
        }
        public void OnFormClosing(object source, FormClosingEventArgs args)
        {
            Application.OpenForms.Cast<Form>().First(form => form.Name == "Home").Show();
            picBoxGraphics.Dispose();
            picBitmap.Dispose();
            pixelToDraw.Dispose();
        }
    }
}
