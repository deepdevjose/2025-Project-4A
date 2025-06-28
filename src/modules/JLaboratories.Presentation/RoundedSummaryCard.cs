using System.ComponentModel;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;

namespace JLaboratories.Presentation
{
    public partial class RoundedSummaryCard : RoundedCard
    {
        public RoundedSummaryCard()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            UpdateRegion();
        }

        private string _title = string.Empty;
        private int _value;
        private IconChar _icon;

        [Category("Summary Card"), Description("Texto del título.")]
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                lblTitle.Text = value;
            }
        }

        [Category("Summary Card"), Description("Valor numérico a mostrar.")]
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                lblValue.Text = value.ToString();
            }
        }

        [Category("Summary Card"), Description("Ícono que acompaña al título.")]
        public IconChar Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                iconPicture.IconChar = value;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            // Genera el path redondeado según CornerRadius heredado
            var path = new GraphicsPath();
            int d = CornerRadius * 2;
            var rect = ClientRectangle;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            Region = new Region(path);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
