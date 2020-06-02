using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4.Elements
{
    public sealed partial class Dot : Control
    {
        public Dot()
        {
            InitializeComponent();

            //For tranparency
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        
        [Category("Custom settigns"), Description("Specifies dot diameter")]
        public int Diameter
        {

            get => _diameter;
            set
            {
                _diameter = value > 0 ? value : _diameter;

                Invalidate();
            }
        }
        private int _diameter = 15;


        [Category("Custom settigns"), Description("Specifies dot color")
        ]
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


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.FillEllipse(new SolidBrush(_color), 0, 0, _diameter, _diameter);
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
