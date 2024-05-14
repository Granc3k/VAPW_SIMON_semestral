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
            changeMethod = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            VstupBranaPanel = new Panel();
            VystupBranaPanel = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // VstupBrana
            // 
            VstupBrana.AutoSize = true;
            VstupBrana.Location = new Point(212, 125);
            VstupBrana.Name = "VstupBrana";
            VstupBrana.Size = new Size(83, 15);
            VstupBrana.TabIndex = 0;
            VstupBrana.Text = "Vstupní brána:";
            // 
            // VystupBrana
            // 
            VystupBrana.AutoSize = true;
            VystupBrana.Location = new Point(551, 125);
            VystupBrana.Name = "VystupBrana";
            VystupBrana.Size = new Size(89, 15);
            VystupBrana.TabIndex = 1;
            VystupBrana.Text = "Výstupní Brána:";
            // 
            // vstupVrataLabel
            // 
            vstupVrataLabel.AutoSize = true;
            vstupVrataLabel.Location = new Point(301, 125);
            vstupVrataLabel.Name = "vstupVrataLabel";
            vstupVrataLabel.Size = new Size(50, 15);
            vstupVrataLabel.TabIndex = 2;
            vstupVrataLabel.Text = "Zavřeno";
            // 
            // vystupVrataLabel
            // 
            vystupVrataLabel.AutoSize = true;
            vystupVrataLabel.Location = new Point(646, 125);
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
            Semafor1.Location = new Point(241, 152);
            Semafor1.Name = "Semafor1";
            Semafor1.Size = new Size(54, 52);
            Semafor1.TabIndex = 5;
            // 
            // Semafor2
            // 
            Semafor2.BackColor = Color.Red;
            Semafor2.Location = new Point(586, 152);
            Semafor2.Name = "Semafor2";
            Semafor2.Size = new Size(54, 52);
            Semafor2.TabIndex = 6;
            // 
            // startButton
            // 
            startButton.Location = new Point(60, 49);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 7;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // carInsideButton
            // 
            carInsideButton.Location = new Point(375, 49);
            carInsideButton.Name = "carInsideButton";
            carInsideButton.Size = new Size(121, 23);
            carInsideButton.TabIndex = 8;
            carInsideButton.Text = "Auto Dovnitř";
            carInsideButton.UseVisualStyleBackColor = true;
            carInsideButton.Click += carInsideButton_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(728, 49);
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
            // changeMethod
            // 
            changeMethod.Location = new Point(12, 501);
            changeMethod.Name = "changeMethod";
            changeMethod.Size = new Size(110, 23);
            changeMethod.TabIndex = 12;
            changeMethod.Text = "Výběr napojení";
            changeMethod.UseVisualStyleBackColor = true;
            changeMethod.Click += changeMethod_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dirty_truck;
            pictureBox1.Location = new Point(21, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dirty_truck;
            pictureBox2.Location = new Point(355, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // VstupBranaPanel
            // 
            VstupBranaPanel.BackColor = SystemColors.ButtonShadow;
            VstupBranaPanel.Location = new Point(241, 226);
            VstupBranaPanel.Name = "VstupBranaPanel";
            VstupBranaPanel.Size = new Size(54, 180);
            VstupBranaPanel.TabIndex = 15;
            // 
            // VystupBranaPanel
            // 
            VystupBranaPanel.BackColor = SystemColors.ControlDark;
            VystupBranaPanel.Location = new Point(586, 226);
            VystupBranaPanel.Name = "VystupBranaPanel";
            VystupBranaPanel.Size = new Size(54, 180);
            VystupBranaPanel.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.truck;
            pictureBox3.Location = new Point(678, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 169);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 536);
            Controls.Add(pictureBox3);
            Controls.Add(VystupBranaPanel);
            Controls.Add(VstupBranaPanel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(changeMethod);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Button changeMethod;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel VstupBranaPanel;
        private Panel VystupBranaPanel;
        private PictureBox pictureBox3;
    }
}
