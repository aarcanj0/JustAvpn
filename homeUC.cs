using System.Windows.Forms;

namespace JustAvpn
{
    public partial class homeUC : UserControl
    {
        public int allhours = 0;
        public homeUC()
        {
            InitializeComponent();
            mainWindow main = new mainWindow();
            allhours = main.exportAllHours();
            this.label1.Text = "Seu recorde é de " + allhours + " horas conectadas";

        }
    }
}
