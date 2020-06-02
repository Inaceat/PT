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
    public partial class Transistor : Control
    {
        public enum TransistorLayout
        {
            Up,
            Right,
            Down,
            Left
        }

        public enum EmitterSide
        {
            Right,
            Left
        }
        
        public enum TransistorType
        {
            NPN,
            PNP
        }


        public Transistor()
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

        [Category("Custom settigns"), Description("Specifies transistor layout, base as \"down\" side")]
        public TransistorLayout LayoutType
        {

            get => _layout;
            set
            {
                _layout = value;

                Invalidate();
            }
        }
        private TransistorLayout _layout = TransistorLayout.Up;

        [Category("Custom settigns"), Description("Specifies emitter side, base as \"down\" side")]
        public EmitterSide Emitter
        {

            get => _emitterSide;
            set
            {
                _emitterSide = value;

                Invalidate();
            }
        }
        private EmitterSide _emitterSide = EmitterSide.Right;

        [Category("Custom settigns"), Description("Specifies emitter type")]
        public TransistorType Type
        {

            get => _type;
            set
            {
                _type = value;

                Invalidate();
            }
        }
        private TransistorType _type = TransistorType.PNP;




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


            pe.Graphics.DrawString(Text, font, brush, 6.5f * sizeUnit, 0.5f * sizeUnit);


            switch (_layout)
            {
                case TransistorLayout.Up:
                {
                    break;
                }
                case TransistorLayout.Right:
                {
                    pe.Graphics.TranslateTransform(8 * sizeUnit, 0);
                    pe.Graphics.RotateTransform(90f);

                    break;
                }

                case TransistorLayout.Down:
                {
                    pe.Graphics.TranslateTransform(8 * sizeUnit, 8 * sizeUnit);
                    pe.Graphics.RotateTransform(180f);

                    break;
                }
                case TransistorLayout.Left:
                {
                    pe.Graphics.TranslateTransform(0, 8 * sizeUnit);
                    pe.Graphics.RotateTransform(270f);

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }


            switch (_emitterSide)
            {
                case EmitterSide.Right:
                {
                    break;
                }
                case EmitterSide.Left:
                {
                    pe.Graphics.TranslateTransform(8 * sizeUnit, 0);
                    pe.Graphics.ScaleTransform(-1, 1);
                    
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }


            pe.Graphics.DrawEllipse(pen, sizeUnit, 0.5f * sizeUnit, 6 * sizeUnit, 6 * sizeUnit);//Circle

            pe.Graphics.DrawLine(pen, 0 * sizeUnit, 2 * sizeUnit, 1.5f * sizeUnit, 2 * sizeUnit);//Left outer contact
            pe.Graphics.DrawLine(pen, 6.5f * sizeUnit, 2 * sizeUnit, 8 * sizeUnit, 2 * sizeUnit);//Right outer contact
            
            pe.Graphics.DrawLine(pen, 4 * sizeUnit, 4.3f * sizeUnit, 4 * sizeUnit, 8 * sizeUnit);//Bottom inner & outer contact
            
            pe.Graphics.DrawLine(pen, 1.7f * sizeUnit, 4.3f * sizeUnit, 6.3f * sizeUnit, 4.3f * sizeUnit);//Base

            pe.Graphics.DrawLine(pen, 1.5f * sizeUnit, 2 * sizeUnit, 2.9f * sizeUnit, 4.3f * sizeUnit);//Left inner contact
            pe.Graphics.DrawLine(pen, 6.5f * sizeUnit, 2 * sizeUnit, 5.1f * sizeUnit, 4.3f * sizeUnit);//Right inner contact


            switch (_type)
            {
                case TransistorType.NPN:
                {
                    //"Upper" arrow
                    pe.Graphics.DrawLine(pen, 6.5f * sizeUnit, 2 * sizeUnit, 5.5f * sizeUnit, 3 * sizeUnit);//Left arrow part
                    pe.Graphics.DrawLine(pen, 6.5f * sizeUnit, 2 * sizeUnit, 6.1f * sizeUnit, 3.35f * sizeUnit);//Right arrow part
                    
                    break;
                }
                case TransistorType.PNP:
                {
                    //"Lower" arrow
                    pe.Graphics.DrawLine(pen, 5.1f * sizeUnit, 4.3f * sizeUnit, 6.1f * sizeUnit, 3.3f * sizeUnit);//Right arrow part
                    pe.Graphics.DrawLine(pen, 5.1f * sizeUnit, 4.3f * sizeUnit, 5.5f * sizeUnit, 2.95f * sizeUnit);//Left arrow part
                    
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
