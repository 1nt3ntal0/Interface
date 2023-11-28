using System.Drawing.Drawing2D;

namespace Interface.controles
{
    public class Renderisado : ToolStripProfessionalRenderer
    {
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;

        public Renderisado(bool EsMenuP, Color primaryColor, Color textColor)
            : base(new Habitacion1(EsMenuP, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if (EsMenuP)
            {
                arrowThickness = 3;
            }
            else
            {
                arrowThickness = 2;
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            base.OnRenderArrow(e);
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2, arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}
