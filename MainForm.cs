namespace WFA230117
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            kilepesButton.Click += OnKilepesButtonClick;
        }

        private void OnKilepesButtonClick(object? sender, EventArgs e)
        {
            var res = MessageBox.Show(
                caption: "MEGERÕSÍTÉS",
                text: "Biztosan szeretnél kilépni az alkalmazásból?",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) Application.Exit();
        }
    }
}