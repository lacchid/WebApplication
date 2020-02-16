using System;
using System.ComponentModel;
using System.ServiceModel;
using System.Windows.Forms;
using WebApplication.Contract.NeutralVersion;

namespace WebApplication.Client
{
    public partial class FormMain : Form
    {
        private IWebServiceContract _webService;
        private FormWait _formWait;
        public FormMain()
        {
            InitializeComponent();
            InitWebService();
        }

        private void InitWebService()
        {
            try
            {
                _webService = new ServicesClient();
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Error", Text, MessageBoxButtons.OK);
            }
            _webService = null;
        }

        private void buttonFibonacci_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy) return;
            try
            {
                buttonFibonacci.Enabled = false;
                buttonCancel.Enabled = true;
                var fibonacciInput = GetComboBoxFibonacciValue();
                if (!fibonacciInput.HasValue) return;
                _formWait = new FormWait();
                backgroundWorker.RunWorkerAsync(fibonacciInput);
                _formWait.Show(this);

            }
            catch (Exception exception)
            {
                MessageBox.Show("An error has ocurred", "Oups", MessageBoxButtons.OK);
                FormWaitClose();
                buttonFibonacci.Enabled = true;
                buttonCancel.Enabled = false;
            }
        }

        private void FormWaitClose()
        {
            if(_formWait == null) return;
            _formWait.Close();
            _formWait.Dispose();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            FormWaitClose();
            buttonFibonacci.Enabled = true;
            buttonCancel.Enabled = false;
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled by User");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("error", e.Error.Message, MessageBoxButtons.OK);
            }
            else
            {
                if(e.Result != null)
                    MessageBox.Show(e.Result.ToString(), "Result", MessageBoxButtons.OK);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _formWait?.SetLoaderCompletionPercent(e.ProgressPercentage);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if(!(sender is BackgroundWorker worker)) return;
            var n = (int) e.Argument;
            try
            {
                e.Result = _webService.Fibonacci(n);
            }
            catch (System.ServiceModel.CommunicationException exception)
            {
                MessageBox.Show("Connection Error", "Oups", MessageBoxButtons.OK);
                throw new Exception("Connection Error", exception);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error has ocurred", "Oups", MessageBoxButtons.OK);
                throw new Exception("Connection Error", exception);
            }
            for (int i = 1; i <= n; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                System.Threading.Thread.Sleep(250);
                worker.ReportProgress(i * 100 / n);
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            buttonCancel.Enabled = false;
        }
        private void comboBoxFibonacciImput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buttonFibonacci.Enabled = GetComboBoxFibonacciValue() != null;
        }

        private int? GetComboBoxFibonacciValue()
        {

            if (comboBoxFibonacciImput.SelectedItem is ComboboxItem comboBoxItemSelected &&
                comboBoxItemSelected.Value.HasValue)
            {
                return ((ComboboxItem)comboBoxItemSelected).Value;
            }
            return null;
        }
    }
}
