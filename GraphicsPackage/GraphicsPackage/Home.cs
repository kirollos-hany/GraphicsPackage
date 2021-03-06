using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPackage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ddaBtn.Click += OnDDABtnClick;
            bresenhamLineBtn.Click += OnBresenhamLineBtnClick;
            ellipseBtn.Click += OnEllipseBtnClick;
            circleBtn.Click += OnCircleBtnClick;
            transformationBtn.Click += OnTransformationBtnClick;
        }

        public void OnDDABtnClick(object source, EventArgs args)
        {
            var ddaForm = new DDAForm();
            ddaForm.Show();
            Hide();
        }

        public void OnBresenhamLineBtnClick(object source, EventArgs args)
        {
            var bresenhamForm = new BresenhamLineForm();
            bresenhamForm.Show();
            Hide();
        }

        public void OnEllipseBtnClick(object source, EventArgs args)
        {
            var ellipseForm = new EllipseForm();
            ellipseForm.Show();
            Hide();
        }

        public void OnCircleBtnClick(object source, EventArgs args)
        {
            var circleForm = new CircleForm();
            circleForm.Show();
            Hide();
        }

        public void OnTransformationBtnClick(object source, EventArgs args)
        {
            var transformationForm = new TransformationForm();
            transformationForm.Show();
            Hide();
        }

    }
}
