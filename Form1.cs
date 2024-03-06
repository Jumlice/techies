using Miner.Controllers;
using System.Windows.Forms;

namespace Techies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MapController.Init(this);
        }
        
        
    }
}
