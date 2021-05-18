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
    public partial class EllipseForm : Form
    {
        private EllipseMidpoint ellipseMidpoint;
        private Graphics picBoxGraphics;
        private Bitmap picBitmap;
        private Bitmap pixelToDraw;
        private int pixelWidth, pixelHeight;
        private delegate void DrawEllipseAsyncDel();
        private int rx, ry, xc, yc;
        private DrawEllipseAsyncDel drawEllipseAsyncDel;
        private delegate void OnEllipseDrawn();
        private event OnEllipseDrawn EllipseDrawn;
        private int numOfEllipses;
        public EllipseForm()
        {
            numOfEllipses = 0;
            ellipseMidpoint = new EllipseMidpoint();
            InitializeComponent();
            picBitmap = new Bitmap(picToDrawEllipse.Width, picToDrawEllipse.Height);
            picToDrawEllipse.Image = picBitmap;
            picBoxGraphics = picToDrawEllipse.CreateGraphics();
            pixelWidth = 1;
            pixelHeight = 1;
            pixelToDraw = new Bitmap(pixelWidth, pixelHeight);
            drawEllipseAsyncDel= new DrawEllipseAsyncDel(DrawEllipseAsync);

            FormClosing += OnFormClosing;
            backBtn.Click += OnBackBtnClick;
            drawBtn.Click += OnDrawBtnClick;
            clearBtn.Click += OnClearBtnClick;

            xRangeLabel.Text = $"{-picToDrawEllipse.Width} < X < {picToDrawEllipse.Width}";
            yRangeLabel.Text = $"{-picToDrawEllipse.Height} < Y < {picToDrawEllipse.Height}";

            EllipseDrawn += OnEllipseDrawnCallback;
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

        private void DrawEllipseAsync()
        {
            ellipseMidpoint.Algorithm(rx, ry, xc, yc);
            for(int i = 0; i < ellipseMidpoint.RegionOneX.Count; i++)
            {
                int x = picToDrawEllipse.Width / 2 + Convert.ToInt32(ellipseMidpoint.RegionOneX[i]);
                int y = picToDrawEllipse.Height / 2 - Convert.ToInt32(ellipseMidpoint.RegionOneY[i]);
                SetPixel(x, y);
            }
            for(int i = 0; i < ellipseMidpoint.RegionTwoX.Count; i++)
            {
                int x = picToDrawEllipse.Width / 2 + Convert.ToInt32(ellipseMidpoint.RegionTwoX[i]);
                int y = picToDrawEllipse.Height / 2 - Convert.ToInt32(ellipseMidpoint.RegionTwoY[i]);
                SetPixel(x, y);
            }
            numOfEllipses++;
            EllipseDrawn();
        }

        private void StartDrawEllipse()
        {
            Thread drawingThread = new Thread(new ThreadStart(drawEllipseAsyncDel));
            drawingThread.Start();
        }

        private void OnEllipseDrawnCallback()
        {
            int decisionIndex = 0;
            for(int i = 0; i < ellipseMidpoint.RegionOneX.Count; i++)
            {
                if(i % 4 == 0 && i < ellipseMidpoint.DecisionRegionOne.Count)
                {
                    decisionIndex = i;
                }
                string ellipseNum = numOfEllipses.ToString();
                string region = "1";
                string decision = ellipseMidpoint.DecisionRegionOne[decisionIndex].ToString();
                string x = Convert.ToInt32(ellipseMidpoint.RegionOneX[i]).ToString();
                string y = Convert.ToInt32(ellipseMidpoint.RegionOneY[i]).ToString();
                string[] tableRow = { ellipseNum, region, decision, x, y, $"({x},{y})" };
                Invoke(new MethodInvoker(delegate ()
                {
                    ellipseResultTable.Rows.Add(tableRow);
                }));
            }
            decisionIndex = 0;
            for(int i = 0; i < ellipseMidpoint.RegionTwoX.Count; i++)
            {
                if (i % 4 == 0 && i < ellipseMidpoint.DecisionRegionTwo.Count)
                {
                    decisionIndex = i;
                }
                string ellipseNum = numOfEllipses.ToString();
                string region = "2";
                string decision = ellipseMidpoint.DecisionRegionTwo[decisionIndex].ToString();
                string x = Convert.ToInt32(ellipseMidpoint.RegionTwoX[i]).ToString();
                string y = Convert.ToInt32(ellipseMidpoint.RegionTwoY[i]).ToString();
                string[] tableRow = { ellipseNum, region, decision, x, y, $"({x},{y})" };
                Invoke(new MethodInvoker(delegate ()
                {
                    ellipseResultTable.Rows.Add(tableRow);
                }));
            }
        }

        public void OnDrawBtnClick(object source, EventArgs args)
        {
            try
            {
                if (!string.IsNullOrEmpty(rxTextBox.Text) && !string.IsNullOrEmpty(ryTextBox.Text)
                    && !string.IsNullOrEmpty(xcTextBox.Text) && !string.IsNullOrEmpty(ycTextBox.Text))
                {
                    rx = Convert.ToInt32(rxTextBox.Text);
                    ry = Convert.ToInt32(ryTextBox.Text);
                    xc = Convert.ToInt32(xcTextBox.Text);
                    yc = Convert.ToInt32(ycTextBox.Text);
                    if (Math.Abs(xc) > picToDrawEllipse.Width || Math.Abs(yc) > picToDrawEllipse.Height || Math.Abs(rx) > picToDrawEllipse.Width || Math.Abs(ry) > picToDrawEllipse.Height)
                    {
                        MessageBox.Show("Please enter values within valid range", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        StartDrawEllipse();
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
            numOfEllipses = 0;
            picBoxGraphics.Clear(Color.RoyalBlue);
            xcTextBox.Clear();
            ycTextBox.Clear();
            rxTextBox.Clear();
            ryTextBox.Clear();
            ellipseResultTable.Rows.Clear();
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
