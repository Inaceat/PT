using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab4.Elements
{
    public sealed partial class Resistor : Control
    {
        public enum ResistorLayout
        {
            Horizontal,
            Vertical
        }

        public Resistor()
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

        [Category("Custom settigns"), Description("Specifies resistor layout")]
        public ResistorLayout LayoutType
        {

            get => _layout;
            set
            {
                _layout = value;

                Invalidate();
            }
        }
        private ResistorLayout _layout = ResistorLayout.Horizontal;



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

            
            switch (_layout)
            {
                case ResistorLayout.Horizontal:
                {
                    pe.Graphics.DrawString(Text, font, brush, 2 * sizeUnit, 0.5f * sizeUnit);  

                    break;
                }

                case ResistorLayout.Vertical:
                {
                    pe.Graphics.DrawString(Text, font, brush, 2.5f * sizeUnit, 1 * sizeUnit);

                    pe.Graphics.TranslateTransform(4 * sizeUnit, 0);
                    pe.Graphics.RotateTransform(90f);

                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }


            pe.Graphics.DrawRectangle(pen, sizeUnit, 2 * sizeUnit, width:5 * sizeUnit, height:2 * sizeUnit);
                    
            pe.Graphics.DrawLine(pen, 0, 3 * sizeUnit, sizeUnit, 3 * sizeUnit);
            pe.Graphics.DrawLine(pen, 6 * sizeUnit, 3 * sizeUnit, 7 * sizeUnit, 3 * sizeUnit);
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
