using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApplication.Client
{
    public partial class FormWait : Form
    {
        public FormWait(Action action = null)
        {
            InitializeComponent();
        }

        public void SetLoaderCompletionPercent(int p)
        {
            progressBar.Value = p;
        }
    }
}
