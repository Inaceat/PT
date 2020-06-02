using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab4.Elements
{
    public sealed partial class Line : Control
    {
        public enum LineType
        {
            Horizontal,
            Vertical
        }


        public Line()
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


        [Category("Custom settigns"), Description("Specifies line color")]
        public Color Color
        {

            get => _color;
            set
            {
                _color = value;

                Invalidate();
            }
        }
        private Color _color = Color.Black;


        [Category("Custom settigns"), Description("Specifies line type")]
        public LineType Type
        {

            get => _type;
            set
            {
                _type = value;

                Invalidate();
            }
        }
        private LineType _type = LineType.Horizontal;


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var pen = new Pen(_color, _width)
            {
                Alignment = PenAlignment.Inset
            };

            if (LineType.Horizontal == _type)
                pe.Graphics.DrawLine(pen, 0, 10, pe.Graphics.VisibleClipBounds.Width, 10);
            else
                pe.Graphics.DrawLine(pen, 10, 0, 10, pe.Graphics.VisibleClipBounds.Height);
            
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
