using System.Collections.Generic;

namespace WebApplication.Client
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFibonacci = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxFibonacciImput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonFibonacci
            // 
            this.buttonFibonacci.Location = new System.Drawing.Point(104, 294);
            this.buttonFibonacci.Name = "buttonFibonacci";
            this.buttonFibonacci.Size = new System.Drawing.Size(215, 43);
            this.buttonFibonacci.TabIndex = 0;
            this.buttonFibonacci.Text = "Compute Fibonacci";
            this.buttonFibonacci.UseVisualStyleBackColor = true;
            this.buttonFibonacci.Click += new System.EventHandler(this.buttonFibonacci_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(467, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(215, 42);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxFibonacciImput
            // 
            this.comboBoxFibonacciImput.FormattingEnabled = true;
            this.comboBoxFibonacciImput.Location = new System.Drawing.Point(104, 160);
            this.comboBoxFibonacciImput.Name = "comboBoxFibonacciImput";
            this.comboBoxFibonacciImput.Size = new System.Drawing.Size(215, 24);
            this.comboBoxFibonacciImput.TabIndex = 2;
            this.comboBoxFibonacciImput.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFibonacciImput_SelectionChangeCommitted);
            for (int i = 0; i < 101; i++)
            {
                this.comboBoxFibonacciImput.Items.Add(new ComboboxItem
                {
                    Text = i.ToString(),
                    Value = i
                });
            }

            this.comboBoxFibonacciImput.SelectedIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFibonacciImput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFibonacci);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFibonacci;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxFibonacciImput;
    }
}

