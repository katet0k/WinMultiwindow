﻿namespace WinMultiwindow
{
    partial class HomeForm
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(796, 394);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 405);
            button1.Name = "button1";
            button1.Size = new Size(165, 33);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonCommand;
            // 
            // button2
            // 
            button2.Location = new Point(634, 405);
            button2.Name = "button2";
            button2.Size = new Size(165, 33);
            button2.TabIndex = 2;
            button2.Text = "Видалити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonCommand;
            // 
            // button3
            // 
            button3.Location = new Point(313, 405);
            button3.Name = "button3";
            button3.Size = new Size(165, 33);
            button3.TabIndex = 3;
            button3.Text = "Змінити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonCommand;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}