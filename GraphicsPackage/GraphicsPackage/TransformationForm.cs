using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using GraphicsPackage.Algorithms;
namespace GraphicsPackage
{
    public partial class TransformationForm : Form
    {
        private Transformation2D transformation;
        private BresenhamLine lineDrawer;
        private Graphics picBoxGraphics;
        private Bitmap picBitmap;
        private Bitmap pixelToDraw;
        private int pixelHeight, pixelWidth;
        private int xStart, yStart, xEnd, yEnd;
        private List<int> startXPoints;
        private List<int> startYPoints;
        private List<int> endXPoints;
        private List<int> endYPoints;
        private bool isMouseClicked;
        private delegate void DrawLineAsyncDel();
        private DrawLineAsyncDel drawLineAsyncDel;
        private volatile bool isFinishDraw;
        public TransformationForm()
        {
            isFinishDraw = false;
            InitializeComponent();
            picBitmap = new Bitmap(picToDraw.Width, picToDraw.Height);
            picToDraw.Image = picBitmap;
            picBoxGraphics = picToDraw.CreateGraphics();
            picToDraw.MouseClick += OnMouseClick;
            picToDraw.MouseDoubleClick += OnMouseDoubleClick;
            drawLineAsyncDel = new DrawLineAsyncDel(DrawLineAsync);
            isMouseClicked = false;
            startXPoints = new List<int>();
            startYPoints = new List<int>();
            endXPoints = new List<int>();
            endYPoints = new List<int>();
            xStart = 0;
            yStart = 0;
            xEnd = 0;
            yEnd = 0;
            lineDrawer = new BresenhamLine();
            transformation = new Transformation2D();
            FormClosing += OnFormClosing;
            backBtn.Click += OnBackBtnClick;
            clearBtn.Click += OnClearBtnClicked;
            pixelHeight = 1;
            pixelWidth = 1;
            pixelToDraw = new Bitmap(pixelWidth, pixelHeight);
            transformBtn.Click += OnTransformBtnClick;
        }

        public void OnMouseClick(object source, MouseEventArgs args)
        {
            if (args.Button.Equals(MouseButtons.Left) && !isMouseClicked)
            {
                isMouseClicked = true;
                xStart = args.X;
                yStart = args.Y;
                startXPoints.Add(xStart);
                startYPoints.Add(yStart);
            }
        }

        public void OnMouseDoubleClick(object source, MouseEventArgs args)
        {
            if (args.Button.Equals(MouseButtons.Left))
            {
                xEnd = args.X;
                yEnd = args.Y;
                endXPoints.Add(xEnd);
                endYPoints.Add(yEnd);
                isMouseClicked = false;
                StartDrawLine();
                while (!isFinishDraw);
            }
        }

        private void StartDrawLine()
        {
            Thread drawingThread = new Thread(new ThreadStart(drawLineAsyncDel));
            drawingThread.Start();
        }

        private void DrawLineAsync()
        {
            isFinishDraw = false;
            lineDrawer.Algorithm(xStart, yStart, xEnd, yEnd);
            for (int i = 0; i < lineDrawer.XPoints.Count; i++)
            {
                int x = Convert.ToInt32(lineDrawer.XPoints[i]);
                int y = Convert.ToInt32(lineDrawer.YPoints[i]);
                SetPixel(x, y);
            }
            isFinishDraw = true;
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

        private void OnClearBtnClicked(object source, EventArgs args)
        {
            picBoxGraphics.Clear(Color.RoyalBlue);
            translationXTB.Text = "dx";
            translationYTB.Text = "dy";
            scaleXTB.Text = "sx";
            scaleYTB.Text = "sy";
            reflectTB.Text = "quadrant";
            startXPoints.Clear();
            startYPoints.Clear();
            endXPoints.Clear();
            endYPoints.Clear();
        }
        private void TranslatePolygon(int dx, int dy)
        {
            transformationLabel.Text = startXPoints.Count.ToString();
            picBoxGraphics.Clear(Color.RoyalBlue);
            for (int i = 0; i < startXPoints.Count; i++)
            {
                xStart = startXPoints[i];
                yStart = startYPoints[i];
                xEnd = endXPoints[i];
                yEnd = endYPoints[i];
                int[] startPoints = new int[3];
                startPoints[0] = xStart;
                startPoints[1] = yStart;
                startPoints[2] = 1;
                int[] endPoints = new int[3];
                endPoints[0] = xEnd;
                endPoints[1] = yEnd;
                endPoints[2] = 1;
                startPoints = transformation.Translation(dx, dy, startPoints);
                endPoints = transformation.Translation(dx, dy, endPoints);
                xStart = startPoints[0];
                yStart = startPoints[1];
                xEnd = endPoints[0];
                yEnd = endPoints[1];
                StartDrawLine();
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
                while (!isFinishDraw);
            }
        }
        public void OnTransformBtnClick(object source, EventArgs args)
        {
            if(!string.IsNullOrEmpty(translationXTB.Text) && !string.IsNullOrEmpty(translationYTB.Text))
            {
                try
                {
                    int dx = Convert.ToInt32(translationXTB.Text);
                    int dy = Convert.ToInt32(translationYTB.Text);
                    TranslatePolygon(dx, dy);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid numbers please enter a valid integer", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
