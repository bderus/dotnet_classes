namespace ToDoApp.WinForms.Views
{
    partial class ListWindow
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
            this.newitem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.itemContainer = new System.Windows.Forms.CheckedListBox();
            this.removeItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newitem
            // 
            this.newitem.Location = new System.Drawing.Point(436, 83);
            this.newitem.Name = "newitem";
            this.newitem.Size = new System.Drawing.Size(150, 50);
            this.newitem.TabIndex = 0;
            this.newitem.Text = "Nowy Item";
            this.newitem.UseVisualStyleBackColor = true;
            this.newitem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 1;
            // 
            // itemContainer
            // 
            this.itemContainer.FormattingEnabled = true;
            this.itemContainer.Location = new System.Drawing.Point(437, 135);
            this.itemContainer.Name = "itemContainer";
            this.itemContainer.Size = new System.Drawing.Size(149, 268);
            this.itemContainer.TabIndex = 2;
            // 
            // button1
            // 
            this.removeItem.Location = new System.Drawing.Point(252, 135);
            this.removeItem.Name = "button1";
            this.removeItem.Size = new System.Drawing.Size(157, 80);
            this.removeItem.TabIndex = 3;
            this.removeItem.Text = "button1";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // ListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.itemContainer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newitem);
            this.Name = "ListWindow";
            this.Text = "ListWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newitem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox itemContainer;
        private System.Windows.Forms.Button removeItem;
    }
}