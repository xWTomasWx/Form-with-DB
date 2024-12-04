namespace PubgDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtConsulta = new TextBox();
            dataGridView1 = new DataGridView();
            btnEjecutar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(45, 21);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(223, 29);
            txtConsulta.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 308);
            dataGridView1.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(308, 21);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(94, 29);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Consultar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEjecutar);
            Controls.Add(dataGridView1);
            Controls.Add(txtConsulta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConsulta;
        private DataGridView dataGridView1;
        private Button btnEjecutar;
    }
}
