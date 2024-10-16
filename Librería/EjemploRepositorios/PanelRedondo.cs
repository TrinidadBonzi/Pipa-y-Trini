using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CPresentacion
{
    public class PanelRedondeado : Panel
    {
        private int borderRadius = 30;

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();  // Redibuja el panel cuando se cambie el radio
            }
        }

        public PanelRedondeado()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.LightPink;
            this.BorderStyle = BorderStyle.None; // Desactivar bordes por defecto
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Dibujar el fondo redondeado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, borderRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
                this.Region = new Region(path); // Establece la región para el área recortada

                // Dibujar un borde redondeado opcional
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            base.OnPaint(e); // Llamar al final para evitar sobrescritura
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            // Añadir arcos para las esquinas
            path.AddArc(arc, 180, 90); // Esquina superior izquierda
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90); // Esquina superior derecha
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90); // Esquina inferior derecha
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90); // Esquina inferior izquierda

            path.CloseFigure();
            return path;
        }
    }
}


