using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using GraphicsPackage.Algorithms;
namespace GraphicsPackage
{
    public partial class DDAForm : Form
    {
        private DDALine ddaLine;
        private Bitmap picBitmap;
        private Bitmap pixelToDraw;
        private Graphics picBoxGraphics;
        private bool isMouseClicked;
        private int xStart, yStart, xEnd, yEnd;
        private int pixelWidth, pixelHeight;
        private delegate void DrawLineAsyncDel();
        private DrawLineAsyncDel drawLineAsyncDel;
        private delegate void OnLineDrawn();
        private event  OnLineDrawn LineDrawn;
        private int linesDrawn;
        public DDAForm()
        {
            InitializeComponent();
            linesDrawn = 0;
            isMouseClicked = false;
            pixelWidth = 1;
            pixelHeight = 1;
            ddaLine = new DDALine();
            picToDrawLine.MouseClick += OnMouseClicked;
            picToDrawLine.MouseDoubleClick += OnMouseDoubleClick;
            picBitmap = new Bitmap(picToDrawLine.Width, picToDrawLine.Height);
            picToDrawLine.Image = picBitmap;
            picBoxGraphics = picToDrawLine.CreateGraphics();
            pixelToDraw = new Bitmap(pixelWidth, pixelHeight);
            drawLineAsyncDel = new DrawLineAsyncDel(DrawLineAsync);
            clearBtn.Click += OnClearBtnClicked;
            drawBtn.Click += OnDrawBtnClicked;
            LineDrawn += OnLineDrawnCallback;
            backBtn.Click += OnBackBtnClicked;
            FormClosing += OnFormClosing;
            xRangeLabel.Text = $"X < {picToDrawLine.Width}";
            yRangeLabel.Text = $"Y < {picToDrawLine.Height}";
        }
        private void SetPixel(int x, int y)
        {
            lock (picBoxGraphics)
            {
                if(x < 0)
                {
                    x *= -1;
                }if(y < 0)
                {
                    y *= -1;
                }
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
            if(isMouseClicked && mouseEventArgs.Button == MouseButtons.Left)
            {
                xEnd = mouseEventArgs.X;
                yEnd = mouseEventArgs.Y;
                StartDrawLine();
                isMouseClicked = false;
            }
        }
        private void StartDrawLine()
        {
            Thread drawThread = new Thread(new ThreadStart(drawLineAsyncDel));
            drawThread.Start();
        }
        private void DrawLineAsync()
        {
            ddaLine.Algorithm(xStart, yStart, xEnd, yEnd);
            for (int i = 0; i < ddaLine.XPoints.Count; i++)
            {
                SetPixel(Convert.ToInt32(ddaLine.XPoints[i]), Convert.ToInt32(ddaLine.YPoints[i]));
            }
            linesDrawn++;
            LineDrawn();
        }
        private void OnLineDrawnCallback()
        {
            for (int i = 0; i < ddaLine.XPoints.Count; i++)
            {
                string iStr = i.ToString();
                string slope = ddaLine.Slope.ToString();
                string x = ddaLine.XPoints[i].ToString();
                string y = ddaLine.YPoints[i].ToString();
                string[] tableRow = { linesDrawn.ToString(),slope, iStr, x, y, $"({x},{y})" };
                this.Invoke(new MethodInvoker(delegate ()
                {
                    linesResultTable.Rows.Add(tableRow);
                }));
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
                    if (xStart > picToDrawLine.Width || xEnd > picToDrawLine.Width || yStart > picToDrawLine.Height || yEnd > picToDrawLine.Height)
                    {
                        MessageBox.Show("Please enter values within valid range", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        StartDrawLine();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all required points", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numbers please enter a valid integer", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(OverflowException)
            {
                MessageBox.Show("Overflow.. please enter a smaller value", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnBackBtnClicked(object source, EventArgs args)
        {
            Application.OpenForms.Cast<Form>().First(form => form.Name == "Home").Show();
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
