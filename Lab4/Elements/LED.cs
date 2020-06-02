using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Elements
{
    public partial class LED : Control
    {
        public LED()
        {
            InitializeComponent();

            //For tranparency
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }


        [Category("Custom settigns"), Description("Specifies line width")]
        public int LineWidth
        {

            get => _width;
            set
            {
                _width = value > 0 ? value : _width;

                Invalidate();
            }
        }
        private int _width = 3;


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var sizeUnit = 15;
            
            var pen = new Pen(Color.Black, _width)
            {
                Alignment = PenAlignment.Inset
            };

            var font = new Font("Arial", sizeUnit, FontStyle.Italic);
            var brush = new SolidBrush(Color.Black);


            pe.Graphics.DrawString(Text, font, brush, 3.5f * sizeUnit, 1.5f * sizeUnit);


            pe.Graphics.DrawEllipse(pen, 2.7f * sizeUnit, 3.4f * sizeUnit, 5.2f * sizeUnit, 5.2f * sizeUnit);//Circle

            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 6 * sizeUnit, 9 * sizeUnit, 6 * sizeUnit);//Contacts

            pe.Graphics.DrawLine(pen, 6.6f * sizeUnit, 4.5f * sizeUnit, 6.6f * sizeUnit, 7.5f * sizeUnit);//Base

            pe.Graphics.DrawLines(pen, new []
            {
                new PointF(6.6f * sizeUnit, 6 * sizeUnit),
                new PointF(4 * sizeUnit, 4.5f * sizeUnit), 
                new PointF(4 * sizeUnit, 7.5f * sizeUnit),
                new PointF(6.6f * sizeUnit, 6 * sizeUnit)
            });//Triangle

            //Arrows
            //Upper
            pe.Graphics.DrawLine(pen, 1 * sizeUnit, 1 * sizeUnit, 3 * sizeUnit, 3 * sizeUnit);
            pe.Graphics.DrawLine(pen, 1 * sizeUnit, 1 * sizeUnit, 2 * sizeUnit, 1.5f * sizeUnit);
            pe.Graphics.DrawLine(pen, 1 * sizeUnit, 1 * sizeUnit, 1.5f * sizeUnit, 2 * sizeUnit);

            //Lower
            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 2 * sizeUnit, 2 * sizeUnit, 4 * sizeUnit);
            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 2 * sizeUnit, 1 * sizeUnit, 2.5f * sizeUnit);
            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 2 * sizeUnit, 0.5f * sizeUnit, 3 * sizeUnit);
        }


        //Another low-level Windows magic for tranparency
        protected override void OnPaintBackground(PaintEventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }
    }
}
