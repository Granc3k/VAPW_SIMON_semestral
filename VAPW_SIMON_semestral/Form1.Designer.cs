namespace VAPW_SIMON_semestral
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
            VstupBrana = new Label();
            VystupBrana = new Label();
            vstupVrataLabel = new Label();
            vystupVrataLabel = new Label();
            ErrorLabel = new Label();
            Semafor1 = new Panel();
            Semafor2 = new Panel();
            startButton = new Button();
            carInsideButton = new Button();
            Reset = new Button();
            washStyleComboBox = new ComboBox();
            myti = new Label();
            SuspendLayout();
            // 
            // VstupBrana
            // 
            VstupBrana.AutoSize = true;
            VstupBrana.Location = new Point(156, 125);
            VstupBrana.Name = "VstupBrana";
            VstupBrana.Size = new Size(83, 15);
            VstupBrana.TabIndex = 0;
            VstupBrana.Text = "Vstupní brána:";
            // 
            // VystupBrana
            // 
            VystupBrana.AutoSize = true;
            VystupBrana.Location = new Point(476, 125);
            VystupBrana.Name = "VystupBrana";
            VystupBrana.Size = new Size(89, 15);
            VystupBrana.TabIndex = 1;
            VystupBrana.Text = "Výstupní Brána:";
            // 
            // vstupVrataLabel
            // 
            vstupVrataLabel.AutoSize = true;
            vstupVrataLabel.Location = new Point(245, 125);
            vstupVrataLabel.Name = "vstupVrataLabel";
            vstupVrataLabel.Size = new Size(50, 15);
            vstupVrataLabel.TabIndex = 2;
            vstupVrataLabel.Text = "Zavřeno";
            // 
            // vystupVrataLabel
            // 
            vystupVrataLabel.AutoSize = true;
            vystupVrataLabel.Location = new Point(571, 125);
            vystupVrataLabel.Name = "vystupVrataLabel";
            vystupVrataLabel.Size = new Size(50, 15);
            vystupVrataLabel.TabIndex = 3;
            vystupVrataLabel.Text = "Zavřeno";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(364, 391);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(12, 15);
            ErrorLabel.TabIndex = 4;
            ErrorLabel.Text = "_";
            // 
            // Semafor1
            // 
            Semafor1.BackColor = Color.Red;
            Semafor1.Location = new Point(156, 184);
            Semafor1.Name = "Semafor1";
            Semafor1.Size = new Size(83, 68);
            Semafor1.TabIndex = 5;
            // 
            // Semafor2
            // 
            Semafor2.BackColor = Color.Red;
            Semafor2.Location = new Point(532, 184);
            Semafor2.Name = "Semafor2";
            Semafor2.Size = new Size(89, 68);
            Semafor2.TabIndex = 6;
            // 
            // startButton
            // 
            startButton.Location = new Point(87, 49);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 7;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // carInsideButton
            // 
            carInsideButton.Location = new Point(327, 49);
            carInsideButton.Name = "carInsideButton";
            carInsideButton.Size = new Size(121, 23);
            carInsideButton.TabIndex = 8;
            carInsideButton.Text = "Auto Dovnitř";
            carInsideButton.UseVisualStyleBackColor = true;
            carInsideButton.Click += carInsideButton_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(620, 49);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 9;
            Reset.Text = "Auto Ven";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += endButton_Click;
            // 
            // washStyleComboBox
            // 
            washStyleComboBox.FormattingEnabled = true;
            washStyleComboBox.Location = new Point(364, 90);
            washStyleComboBox.Name = "washStyleComboBox";
            washStyleComboBox.Size = new Size(121, 23);
            washStyleComboBox.TabIndex = 10;
            washStyleComboBox.SelectedIndexChanged += washStyleComboBox_SelectedIndexChanged;
            // 
            // myti
            // 
            myti.AutoSize = true;
            myti.Location = new Point(219, 93);
            myti.Name = "myti";
            myti.Size = new Size(139, 15);
            myti.TabIndex = 11;
            myti.Text = "Výběr mycího programu:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myti);
            Controls.Add(washStyleComboBox);
            Controls.Add(Reset);
            Controls.Add(carInsideButton);
            Controls.Add(startButton);
            Controls.Add(Semafor2);
            Controls.Add(Semafor1);
            Controls.Add(ErrorLabel);
            Controls.Add(vystupVrataLabel);
            Controls.Add(vstupVrataLabel);
            Controls.Add(VystupBrana);
            Controls.Add(VstupBrana);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VstupBrana;
        private Label VystupBrana;
        private Label vstupVrataLabel;
        private Label vystupVrataLabel;
        private Label ErrorLabel;
        private Panel Semafor1;
        private Panel Semafor2;
        private Button startButton;
        private Button carInsideButton;
        private Button Reset;
        private ComboBox washStyleComboBox;
        private Label myti;
    }
}
