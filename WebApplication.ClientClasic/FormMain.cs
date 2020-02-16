using System;
using System.Threading;
using System.Windows.Forms;

namespace WebApplication.ClientClasic
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        void MakeTime()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

        }

        private void buttonFibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formWait = new FormWait(MakeTime))
                {
                    formWait.ShowDialog(this);
                }
            }
            catch 
            {
                MessageBox.Show("An error has ocurred", Text, MessageBoxButtons.OK);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFibonacciImput_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
