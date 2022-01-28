namespace ToDoApp.WinForms.Views
{
    partial class MainWindow
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
            this.nowaLista = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listContainer = new System.Windows.Forms.ListBox();
            this.removeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nowaLista
            // 
            this.nowaLista.Location = new System.Drawing.Point(453, 94);
            this.nowaLista.Name = "nowaLista";
            this.nowaLista.Size = new System.Drawing.Size(231, 111);
            this.nowaLista.TabIndex = 1;
            this.nowaLista.Text = "nowaLista";
            this.nowaLista.UseVisualStyleBackColor = true;
            this.nowaLista.Click += new System.EventHandler(this.newList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 4;
            // 
            // listContainer
            // 
            this.listContainer.FormattingEnabled = true;
            this.listContainer.ItemHeight = 20;
            this.listContainer.Location = new System.Drawing.Point(453, 213);
            this.listContainer.Name = "listContainer";
            this.listContainer.Size = new System.Drawing.Size(231, 324);
            this.listContainer.TabIndex = 6;
            // 
            // button1
            // 
            this.removeList.Location = new System.Drawing.Point(194, 213);
            this.removeList.Name = "button1";
            this.removeList.Size = new System.Drawing.Size(197, 72);
            this.removeList.TabIndex = 7;
            this.removeList.Text = "Usuń Listę";
            this.removeList.UseVisualStyleBackColor = true;
            this.removeList.Click += RemoveList_Click;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.removeList);
            this.Controls.Add(this.listContainer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nowaLista);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nowaLista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listContainer;
        private System.Windows.Forms.Button removeList;
    }
}
