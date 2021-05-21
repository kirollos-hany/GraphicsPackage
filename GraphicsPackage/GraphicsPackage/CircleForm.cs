using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GraphicsPackage.Algorithms;
namespace GraphicsPackage
{
    public partial class CircleForm : Form
    {
        private Circle circleDrawer;
        private Graphics picBoxGraphics;
        private Bitmap picBitmap;
        private Bitmap pixelToDraw;
        private int pixelWidth, pixelHeight;
        private delegate void DrawCircleAsyncDel();
        private int r, xc, yc;
        private DrawCircleAsyncDel drawCircleAsyncDel;
        private delegate void OnCircleDrawn();
        private event OnCircleDrawn CircleDrawn;
        private int numOfCircles;
        public CircleForm()
        {
            numOfCircles = 0;
            circleDrawer = new Circle();
            InitializeComponent();
            picBitmap = new Bitmap(picToDrawCircle.Width, picToDrawCircle.Height);
            picToDrawCircle.Image = picBitmap;
            picBoxGraphics = picToDrawCircle.CreateGraphics();
            pixelWidth = 1;
            pixelHeight = 1;
            pixelToDraw = new Bitmap(pixelWidth, pixelHeight);
            drawCircleAsyncDel = new DrawCircleAsyncDel(DrawCircleAsync);

            FormClosing += OnFormClosing;
            backBtn.Click += OnBackBtnClick;
            drawBtn.Click += OnDrawBtnClick;
            clearBtn.Click += OnClearBtnClick;

            xRangeLabel.Text = $"{-picToDrawCircle.Width} < X < {picToDrawCircle.Width}";
            yRangeLabel.Text = $"{-picToDrawCircle.Height} < Y < {picToDrawCircle.Height}";

            CircleDrawn += OnCircleDrawnCallback;
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
                pixelToDraw.SetPixel(0, 0, Color.Black);
                picBoxGraphics.DrawImage(pixelToDraw, x, y);
            }
        }

        private void DrawCircleAsync()
        {
            circleDrawer.Algorithm(r, xc, yc);
            for (int i = 0; i < circleDrawer.XPoints.Count; i++)
            {
                int x = picToDrawCircle.Width / 2 + Convert.ToInt32(circleDrawer.XPoints[i]);
                int y = picToDrawCircle.Height / 2 - Convert.ToInt32(circleDrawer.YPoints[i]);
                SetPixel(x, y);
            }
            numOfCircles++;
            CircleDrawn();
        }

        private void StartDrawCircle()
        {
            Thread drawingThread = new Thread(new ThreadStart(drawCircleAsyncDel));
            drawingThread.Start();
        }

        private void OnCircleDrawnCallback()
        {
            for (int i = 0; i < circleDrawer.XPoints.Count / 8; i++)
            {
                string decision = circleDrawer.PKPoints[i].ToString(); ;
                string circleNum = numOfCircles.ToString();
                string x = Convert.ToInt32(circleDrawer.XPoints[i]).ToString();
                string y = Convert.ToInt32(circleDrawer.YPoints[i]).ToString();
                string[] tableRow = { circleNum, decision, x, y, $"({x},{y})" };
                Invoke(new MethodInvoker(delegate ()
                {
                    circleResultTable.Rows.Add(tableRow);
                }));
            }
        }

        public void OnDrawBtnClick(object source, EventArgs args)
        {
            try
            {
                if (!string.IsNullOrEmpty(rTextBox.Text) && !string.IsNullOrEmpty(xcTextBox.Text) && !string.IsNullOrEmpty(ycTextBox.Text))
                {
                    r = Convert.ToInt32(rTextBox.Text);
                    xc = Convert.ToInt32(xcTextBox.Text);
                    yc = Convert.ToInt32(ycTextBox.Text);
                    if (Math.Abs(xc) > picToDrawCircle.Width || Math.Abs(yc) > picToDrawCircle.Height || Math.Abs(r) > picToDrawCircle.Width || Math.Abs(r) > picToDrawCircle.Height)
                    {
                        MessageBox.Show("Please enter values within valid range", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        StartDrawCircle();
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
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow.. please enter a smaller value", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OnClearBtnClick(object source, EventArgs args)
        {
            numOfCircles = 0;
            picBoxGraphics.Clear(Color.RoyalBlue);
            xcTextBox.Clear();
            ycTextBox.Clear();
            rTextBox.Clear();
            circleResultTable.Rows.Clear();
        }
        public void OnBackBtnClick(object source, EventArgs args)
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
