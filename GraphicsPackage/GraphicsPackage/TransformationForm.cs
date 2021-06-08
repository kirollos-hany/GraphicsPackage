using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public TransformationForm()
        {
            InitializeComponent();
            picBitmap = new Bitmap(picToDraw.Width, picToDraw.Height);
            picToDraw.Image = picBitmap;
            picBoxGraphics = picToDraw.CreateGraphics();
            picToDraw.MouseClick += OnMouseClick;
            picToDraw.MouseDoubleClick += OnMouseDoubleClick;
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
                DrawLine();
            }
        }

        private double ConvertToRadian(double theta)
        {
            return theta * (180 / Math.PI);
        }

        private void DrawLine()
        {
            lineDrawer.Algorithm(xStart, yStart, xEnd, yEnd);
            for (int i = 0; i < lineDrawer.XPoints.Count; i++)
            {
                int x = Convert.ToInt32(lineDrawer.XPoints[i]);
                int y = Convert.ToInt32(lineDrawer.YPoints[i]);
                SetPixel(x, y);
            }
        }
        private void SetPixel(int x, int y)
        {
                if (x < 0)
                {
                    x *= -1;
                }
                if (y < 0)
                {
                    y *= -1;
                }
                x %= picToDraw.Width;
                y %= picToDraw.Height;
                pixelToDraw.SetPixel(0, 0, Color.Black);
                picBoxGraphics.DrawImage(pixelToDraw, x, y);
        }

        private void OnClearBtnClicked(object source, EventArgs args)
        {
            picBoxGraphics.Clear(Color.RoyalBlue);
            translationXTB.Text = "dx";
            translationYTB.Text = "dy";
            scaleXTB.Text = "sx";
            scaleYTB.Text = "sy";
            reflectCB.Text = "Select Axis";
            shearCB.Text = "Select Axis";
            shearTB.Text = "sh";
            startXPoints.Clear();
            startYPoints.Clear();
            endXPoints.Clear();
            endYPoints.Clear();
            transformResultTable.Rows.Clear();
        }
        private void TranslatePolygon(int dx, int dy)
        {
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
                DrawLine();
                string[] row = { "Translation", $"({startXPoints[i]}, {startYPoints[i]}), ({endXPoints[i]},{endYPoints[i]})", $"({xStart},{yStart}), ({xEnd},{yEnd})" };
                transformResultTable.Rows.Add(row);
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
            }
        }

        private void ReflectPolygon(int axisIndex)
        {
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
                startPoints = transformation.Reflect(axisIndex, startPoints);
                endPoints = transformation.Reflect(axisIndex, endPoints);
                xStart = startPoints[0];
                yStart = startPoints[1];
                xEnd = endPoints[0];
                yEnd = endPoints[1];
                DrawLine();
                string[] row = { "Reflect", $"({startXPoints[i]}, {startYPoints[i]}), ({endXPoints[i]},{endYPoints[i]})", $"({xStart},{yStart}), ({xEnd},{yEnd})" };
                transformResultTable.Rows.Add(row);
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
            }
        }
        private void ShearPolygon(int axisIndex, int sh)
        {
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
                startPoints = transformation.Shear(startPoints, axisIndex, sh);
                endPoints = transformation.Shear(endPoints, axisIndex, sh);
                xStart = startPoints[0];
                yStart = startPoints[1];
                xEnd = endPoints[0];
                yEnd = endPoints[1];
                DrawLine();
                string[] row = { "Shear", $"({startXPoints[i]}, {startYPoints[i]}), ({endXPoints[i]},{endYPoints[i]})", $"({xStart},{yStart}), ({xEnd},{yEnd})" };
                transformResultTable.Rows.Add(row);
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
            }
        }

        private void ScalePolygon(int scaleX, int scaleY)
        {
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
                startPoints = transformation.Scaling(scaleX, scaleY, startPoints);
                endPoints = transformation.Scaling(scaleX, scaleY, endPoints);
                xStart = startPoints[0];
                yStart = startPoints[1];
                xEnd = endPoints[0];
                yEnd = endPoints[1];
                DrawLine();
                string[] row = { "Scale", $"({startXPoints[i]}, {startYPoints[i]}), ({endXPoints[i]},{endYPoints[i]})", $"({xStart},{yStart}), ({xEnd},{yEnd})" };
                transformResultTable.Rows.Add(row);
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
            }
        }

        private void TransformationForm_Load(object sender, EventArgs e)
        {
            transformResultTable.Columns[0].Width = 220;
            transformResultTable.Columns[1].Width = 205;
            transformResultTable.Columns[2].Width = 205;
        }

        private void RotatePolygon(double theta)
        {
            picBoxGraphics.Clear(Color.RoyalBlue);
            for (int i = 0; i < startXPoints.Count; i++)
            {
                xStart = startXPoints[i];
                yStart = startYPoints[i];
                xEnd = endXPoints[i];
                yEnd = endYPoints[i];
                double[] startPoints = new double[3];
                startPoints[0] = xStart;
                startPoints[1] = yStart;
                startPoints[2] = 1;
                double[] endPoints = new double[3];
                endPoints[0] = xEnd;
                endPoints[1] = yEnd;
                endPoints[2] = 1;
                startPoints = transformation.Rotation(theta, startPoints);
                endPoints = transformation.Rotation(theta, endPoints);
                xStart = Convert.ToInt32(startPoints[0]);
                yStart = Convert.ToInt32(startPoints[1]);
                xEnd = Convert.ToInt32(endPoints[0]);
                yEnd = Convert.ToInt32(endPoints[1]);
                DrawLine();
                string[] row = { "Rotate", $"({startXPoints[i]}, {startYPoints[i]}), ({endXPoints[i]},{endYPoints[i]})", $"({xStart},{yStart}), ({xEnd},{yEnd})" };
                transformResultTable.Rows.Add(row);
                startXPoints[i] = xStart;
                startYPoints[i] = yStart;
                endXPoints[i] = xEnd;
                endYPoints[i] = yEnd;
            }
        }
        

        public void OnTransformBtnClick(object source, EventArgs args)
        {
            if (reflectCB.SelectedIndex != -1)
            {
                    ReflectPolygon(reflectCB.SelectedIndex);
            }
            if (shearCB.SelectedIndex != -1 && !string.IsNullOrEmpty(shearCB.Text) && !shearTB.Text.Equals("sh"))
            {
                try
                {
                    ShearPolygon(shearCB.SelectedIndex, Convert.ToInt32(shearTB.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid numbers please enter a valid integer", "Shear Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            if (!string.IsNullOrEmpty(translationXTB.Text) && !string.IsNullOrEmpty(translationYTB.Text) && (!translationXTB.Text.Equals("dx") && !translationYTB.Text.Equals("dy")))
            {
                try
                {
                    int dx = Convert.ToInt32(translationXTB.Text);
                    int dy = Convert.ToInt32(translationYTB.Text);
                    TranslatePolygon(dx, dy);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid numbers please enter a valid integer", "Translation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrEmpty(scaleXTB.Text) && !string.IsNullOrEmpty(scaleYTB.Text) && (!scaleXTB.Text.Equals("sx") && !scaleYTB.Text.Equals("sy")))
            {
                try
                {
                    int scaleX = Convert.ToInt32(scaleXTB.Text);
                    int scaleY = Convert.ToInt32(scaleYTB.Text);
                    ScalePolygon(scaleX, scaleY);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid numbers please enter a valid integer", "Scale Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrEmpty(thetaTB.Text) && !thetaTB.Text.Equals("theta"))
            {
                try
                {
                    double theta = Convert.ToDouble(thetaTB.Text);
                    RotatePolygon(ConvertToRadian(theta));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid numbers please enter a valid theta in degrees", "Rotate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
