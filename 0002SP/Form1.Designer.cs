using System.Diagnostics;

namespace _0002SP
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
            openButton = new Button();
            closeButton = new Button();
            comboBox = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.BackColor = SystemColors.ControlLightLight;
            openButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openButton.Location = new Point(64, 136);
            openButton.Name = "openButton";
            openButton.Size = new Size(186, 40);
            openButton.TabIndex = 0;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(64, 188);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(186, 38);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Notebook", "Calculator", "Task Manager", "Command Prompt", "File Explorer" });
            comboBox.Location = new Point(81, 90);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 2;
            comboBox.SelectedIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 61);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose Application:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 91);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 118);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 145);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 172);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(249, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(312, 199);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(249, 27);
            textBox5.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 94);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 11;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(289, 121);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 12;
            label3.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 148);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 13;
            label4.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(289, 175);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 14;
            label5.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(289, 202);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 15;
            label6.Text = "5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(367, 61);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 18;
            label9.Text = "Active Processes:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 302);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private Button closeButton;
        private ComboBox comboBox;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
    }
}