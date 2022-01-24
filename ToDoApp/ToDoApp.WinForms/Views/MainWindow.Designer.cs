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
            this.listContainer = new System.Windows.Forms.ListBox();
            this.nowyItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // listContainer
            // 
            this.listContainer.FormattingEnabled = true;
            this.listContainer.ItemHeight = 20;
            this.listContainer.Location = new System.Drawing.Point(457, 222);
            this.listContainer.Name = "listContainer";
            this.listContainer.Size = new System.Drawing.Size(227, 324);
            this.listContainer.TabIndex = 2;
            // 
            // nowyItem
            // 
            this.nowyItem.Location = new System.Drawing.Point(88, 94);
            this.nowyItem.Name = "nowyItem";
            this.nowyItem.Size = new System.Drawing.Size(219, 102);
            this.nowyItem.TabIndex = 3;
            this.nowyItem.Text = "nowyItem";
            this.nowyItem.UseVisualStyleBackColor = true;
            this.nowyItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 27);
            this.textBox1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nowyItem);
            this.Controls.Add(this.listContainer);
            this.Controls.Add(this.nowaLista);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newItem;
        private System.Windows.Forms.Button nowaLista;
        private System.Windows.Forms.ListBox listContainer;
        private System.Windows.Forms.Button nowyItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}
