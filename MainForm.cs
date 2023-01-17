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
                caption: "MEGER�S�T�S",
                text: "Biztosan szeretn�l kil�pni az alkalmaz�sb�l?",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) Application.Exit();
        }
    }
}