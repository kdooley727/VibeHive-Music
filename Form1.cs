using System.Diagnostics;

namespace Main_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MusicRental_Click(object sender, EventArgs e)
        {
            StartExecutable(@"C:\Users\kdool\source\repos\MusicRentalManagementGUI\MusicRentalManagementGUI\bin\Debug\MusicRentalManagementGUI.exe");
        }

        private void btn_EventTicket_Click(object sender, EventArgs e)
        {
            StartExecutable(@"C:\Users\kdool\source\repos\EventManagementGUI\bin\Debug\net8.0-windows\EventManagementGUI.exe");
        }

        private void btn_Albums_Click(object sender, EventArgs e)
        {
            StartExecutable(@"C:\Users\kdool\source\repos\AlbumAPI\AlbumForm\bin\Debug\net8.0-windows\AlbumForm.exe");
        }

        private void StartExecutable(string executablePath)
        {
            if (!System.IO.File.Exists(executablePath))
            {
                MessageBox.Show("Executable file not found. Please make sure the project is built and the path is correct.");
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = executablePath,
                UseShellExecute = true
            });
        }
    }
}
