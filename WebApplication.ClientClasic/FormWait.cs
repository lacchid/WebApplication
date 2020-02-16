using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApplication.ClientClasic
{
    public partial class FormWait : Form
    {
        public Action Action { get; set; }
        public FormWait(Action action)
        {
            InitializeComponent();
            Action = action;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Action != null)
                Task.Factory.StartNew(Action)
                    .ContinueWith(t => this.Close(), TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
