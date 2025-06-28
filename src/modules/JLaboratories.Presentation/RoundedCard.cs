using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace JLaboratories.Presentation
{
    [DefaultEvent("Click")]
    public partial class RoundedCard : UserControl
    {

        public RoundedCard()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
            true);
            UpdateStyles();
        }

        [Category("Apariencia")]
        [Description("Radio de las esquinas del rectángulo.")]
        public int CornerRadius { get; set; } = 20;

        [Category("Apariencia")]
        [Description("Color de relleno del control.")]
        public Color DividerColor { get; set; } = ColorTranslator.FromHtml("#282828");
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new SolidBrush(DividerColor))
            using (var path = GetRoundedRectanglePath(ClientRectangle, CornerRadius))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void RoundedPicture_Load(object sender, EventArgs e)
        {

        }
    }
}
