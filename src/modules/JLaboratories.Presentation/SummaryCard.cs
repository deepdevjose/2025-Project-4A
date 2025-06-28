namespace JLaboratories.Presentation
{
    public partial class SummaryCard : UserControl
    {
        public SummaryCard()
        {
            InitializeComponent();
        }
        public string Title
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }

        public int Value
        {
            get => int.Parse(labelValue.Text);
            set => labelValue.Text = value.ToString();
        }

        public FontAwesome.Sharp.IconChar Icon
        {
            get => iconPicture.IconChar;
            set => iconPicture.IconChar = value;
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
