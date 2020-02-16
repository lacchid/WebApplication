using System;
using System.Windows.Forms;

namespace WebApplication.Client
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
        }

        public void SetLoaderCompletionPercent(int p)
        {
            progressBar.Value = p;
        }
    }
}
