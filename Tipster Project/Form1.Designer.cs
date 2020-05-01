namespace Tipster_Project
{
    partial class tipsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipsterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.tipGroupBox = new System.Windows.Forms.GroupBox();
            this.madTipRadioButton = new System.Windows.Forms.RadioButton();
            this.generousTipRadioButton = new System.Windows.Forms.RadioButton();
            this.normalTipRadioButton = new System.Windows.Forms.RadioButton();
            this.noTipRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // billTextBox
            // 
            this.billTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTextBox.Location = new System.Drawing.Point(131, 61);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(280, 30);
            this.billTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of People";
            // 
            // peopleListBox
            // 
            this.peopleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 25;
            this.peopleListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.peopleListBox.Location = new System.Drawing.Point(362, 319);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(62, 79);
            this.peopleListBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(466, 351);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(144, 59);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateCosts);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(629, 351);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(144, 59);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // tipGroupBox
            // 
            this.tipGroupBox.Controls.Add(this.madTipRadioButton);
            this.tipGroupBox.Controls.Add(this.generousTipRadioButton);
            this.tipGroupBox.Controls.Add(this.normalTipRadioButton);
            this.tipGroupBox.Controls.Add(this.noTipRadioButton);
            this.tipGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipGroupBox.Location = new System.Drawing.Point(41, 129);
            this.tipGroupBox.Name = "tipGroupBox";
            this.tipGroupBox.Size = new System.Drawing.Size(402, 154);
            this.tipGroupBox.TabIndex = 7;
            this.tipGroupBox.TabStop = false;
            this.tipGroupBox.Text = "Tip";
            // 
            // madTipRadioButton
            // 
            this.madTipRadioButton.AutoSize = true;
            this.madTipRadioButton.Location = new System.Drawing.Point(227, 101);
            this.madTipRadioButton.Name = "madTipRadioButton";
            this.madTipRadioButton.Size = new System.Drawing.Size(72, 29);
            this.madTipRadioButton.TabIndex = 3;
            this.madTipRadioButton.TabStop = true;
            this.madTipRadioButton.Text = "Mad";
            this.madTipRadioButton.UseVisualStyleBackColor = true;
            this.madTipRadioButton.CheckedChanged += new System.EventHandler(this.addMadTip);
            // 
            // generousTipRadioButton
            // 
            this.generousTipRadioButton.AutoSize = true;
            this.generousTipRadioButton.Location = new System.Drawing.Point(45, 101);
            this.generousTipRadioButton.Name = "generousTipRadioButton";
            this.generousTipRadioButton.Size = new System.Drawing.Size(119, 29);
            this.generousTipRadioButton.TabIndex = 2;
            this.generousTipRadioButton.TabStop = true;
            this.generousTipRadioButton.Text = "Generous";
            this.generousTipRadioButton.UseVisualStyleBackColor = true;
            this.generousTipRadioButton.CheckedChanged += new System.EventHandler(this.addGenerousTip);
            // 
            // normalTipRadioButton
            // 
            this.normalTipRadioButton.AutoSize = true;
            this.normalTipRadioButton.Location = new System.Drawing.Point(227, 49);
            this.normalTipRadioButton.Name = "normalTipRadioButton";
            this.normalTipRadioButton.Size = new System.Drawing.Size(95, 29);
            this.normalTipRadioButton.TabIndex = 1;
            this.normalTipRadioButton.TabStop = true;
            this.normalTipRadioButton.Text = "Normal";
            this.normalTipRadioButton.UseVisualStyleBackColor = true;
            this.normalTipRadioButton.CheckedChanged += new System.EventHandler(this.addNormalTip);
            // 
            // noTipRadioButton
            // 
            this.noTipRadioButton.AutoSize = true;
            this.noTipRadioButton.Location = new System.Drawing.Point(45, 49);
            this.noTipRadioButton.Name = "noTipRadioButton";
            this.noTipRadioButton.Size = new System.Drawing.Size(80, 29);
            this.noTipRadioButton.TabIndex = 0;
            this.noTipRadioButton.TabStop = true;
            this.noTipRadioButton.Text = "None";
            this.noTipRadioButton.UseVisualStyleBackColor = true;
            this.noTipRadioButton.CheckedChanged += new System.EventHandler(this.addNoTip);
            // 
            // tipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tipGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tipsterForm";
            this.Text = "Tipster Data Entry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tipGroupBox.ResumeLayout(false);
            this.tipGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox tipGroupBox;
        private System.Windows.Forms.RadioButton madTipRadioButton;
        private System.Windows.Forms.RadioButton generousTipRadioButton;
        private System.Windows.Forms.RadioButton normalTipRadioButton;
        private System.Windows.Forms.RadioButton noTipRadioButton;
    }
}

