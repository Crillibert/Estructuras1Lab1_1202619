namespace Estructuras1Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_leer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_test = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_leer
            // 
            this.button_leer.Location = new System.Drawing.Point(12, 279);
            this.button_leer.Name = "button_leer";
            this.button_leer.Size = new System.Drawing.Size(115, 36);
            this.button_leer.TabIndex = 0;
            this.button_leer.Text = "Cargar Datos";
            this.button_leer.UseVisualStyleBackColor = true;
            this.button_leer.Click += new System.EventHandler(this.button_leer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(133, 28);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(31, 13);
            this.label_test.TabIndex = 1;
            this.label_test.Text = "____";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Bar",
            "Cafeteria",
            "Hospital",
            "Kindergarten",
            "Vet",
            "Panaderia",
            "Mall",
            "Salon",
            "Farmacia",
            "Gimnacio ",
            "Tienda",
            "Restaurante",
            "Barberia",
            "Clinica",
            "Miselanea",
            "Gasolinera"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(115, 244);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servicios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.button_leer);
            this.Name = "Form1";
            this.Text = "Buscar Apartamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_leer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}

