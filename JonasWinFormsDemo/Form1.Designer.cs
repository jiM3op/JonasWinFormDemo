namespace JonasWinFormsDemo
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
            button1 = new Button();
            eingabeBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(523, 82);
            button1.Name = "button1";
            button1.Size = new Size(224, 29);
            button1.TabIndex = 0;
            button1.Text = "Los geht's!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eingabeBox
            // 
            eingabeBox.Location = new Point(66, 82);
            eingabeBox.Name = "eingabeBox";
            eingabeBox.Size = new Size(423, 27);
            eingabeBox.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 59);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "EingabeText";
  
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 169);
            Controls.Add(label1);
            Controls.Add(eingabeBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox eingabeBox;
        private Label label1;
    }
}
