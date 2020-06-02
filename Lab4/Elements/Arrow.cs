using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab4.Elements
{
    public partial class Arrow : Control
    {
        public Arrow()
        {
            InitializeComponent();

            //For tranparency
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        public enum ArrowDirection
        {
            Left,
            Right
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
        public ArrowDirection Direction
        {

            get => _direction;
            set
            {
                _direction = value;

                Invalidate();
            }
        }
        private ArrowDirection _direction = ArrowDirection.Right;


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


            pe.Graphics.DrawString(Text, font, brush, 0 * sizeUnit, 1.5f * sizeUnit);


            if (ArrowDirection.Left == _direction)
            {
                pe.Graphics.TranslateTransform(4 * sizeUnit, 0);
                pe.Graphics.ScaleTransform(-1, 1);
            }


            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 4 * sizeUnit, 4 * sizeUnit, 4 * sizeUnit);//Contact

            pe.Graphics.DrawLine(pen, 3 * sizeUnit, 3 * sizeUnit, 4 * sizeUnit, 4 * sizeUnit);//Arrow upper
            pe.Graphics.DrawLine(pen, 3 * sizeUnit, 5 * sizeUnit, 4 * sizeUnit, 4 * sizeUnit);//Arrow lower
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
