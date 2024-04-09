namespace WinFormsApp1
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
            add_button = new Button();
            find_button = new Button();
            delete_button = new Button();
            change_button = new Button();
            IDtext = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nametext = new TextBox();
            Clienttext = new TextBox();
            Pricetext = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Location = new Point(594, 32);
            add_button.Name = "add_button";
            add_button.Size = new Size(112, 34);
            add_button.TabIndex = 0;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // find_button
            // 
            find_button.Location = new Point(594, 85);
            find_button.Name = "find_button";
            find_button.Size = new Size(112, 34);
            find_button.TabIndex = 1;
            find_button.Text = "Find";
            find_button.UseVisualStyleBackColor = true;
            find_button.Click += find_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(594, 138);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(112, 34);
            delete_button.TabIndex = 2;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // change_button
            // 
            change_button.Location = new Point(594, 191);
            change_button.Name = "change_button";
            change_button.Size = new Size(112, 34);
            change_button.TabIndex = 3;
            change_button.Text = "Change";
            change_button.UseVisualStyleBackColor = true;
            change_button.Click += change_button_Click;
            // 
            // IDtext
            // 
            IDtext.Location = new Point(33, 36);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(107, 30);
            IDtext.TabIndex = 4;
            IDtext.TextChanged += IDtext_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 24);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 7;
            label3.Text = "Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // Nametext
            // 
            Nametext.Location = new Point(166, 36);
            Nametext.Name = "Nametext";
            Nametext.Size = new Size(107, 30);
            Nametext.TabIndex = 9;
            Nametext.TextChanged += Nametext_TextChanged;
            // 
            // Clienttext
            // 
            Clienttext.Location = new Point(305, 36);
            Clienttext.Name = "Clienttext";
            Clienttext.Size = new Size(107, 30);
            Clienttext.TabIndex = 10;
            Clienttext.TextChanged += Clienttext_TextChanged;
            // 
            // Pricetext
            // 
            Pricetext.Location = new Point(439, 36);
            Pricetext.Name = "Pricetext";
            Pricetext.Size = new Size(107, 30);
            Pricetext.TabIndex = 11;
            Pricetext.TextChanged += Pricetext_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 148);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 85);
            label6.Name = "label6";
            label6.Size = new Size(63, 24);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Pricetext);
            Controls.Add(Clienttext);
            Controls.Add(Nametext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IDtext);
            Controls.Add(change_button);
            Controls.Add(delete_button);
            Controls.Add(find_button);
            Controls.Add(add_button);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_button;
        private Button find_button;
        private Button delete_button;
        private Button change_button;
        private TextBox IDtext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nametext;
        private TextBox Clienttext;
        private TextBox Pricetext;
        private Label label5;
        private Label label6;
    }
}
