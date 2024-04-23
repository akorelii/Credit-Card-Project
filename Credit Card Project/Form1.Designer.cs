namespace Credit_Card_Project
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
            panel1 = new Panel();
            panel3 = new Panel();
            cardDateLabel = new Label();
            cardNumberLabel = new Label();
            nameLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            payButton = new Button();
            dateTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 244);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateBlue;
            panel3.Controls.Add(cardDateLabel);
            panel3.Controls.Add(cardNumberLabel);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 219);
            panel3.TabIndex = 2;
            // 
            // cardDateLabel
            // 
            cardDateLabel.AutoSize = true;
            cardDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardDateLabel.ForeColor = Color.White;
            cardDateLabel.Location = new Point(268, 188);
            cardDateLabel.Name = "cardDateLabel";
            cardDateLabel.Size = new Size(0, 31);
            cardDateLabel.TabIndex = 3;
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardNumberLabel.ForeColor = Color.White;
            cardNumberLabel.Location = new Point(14, 84);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(0, 31);
            cardNumberLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(14, 175);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 31);
            nameLabel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.card_chip;
            pictureBox2.Location = new Point(14, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.visa_logo;
            pictureBox1.Location = new Point(278, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(payButton);
            panel2.Controls.Add(dateTextBox);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(idTextBox);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(391, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 244);
            panel2.TabIndex = 1;
            // 
            // payButton
            // 
            payButton.BackColor = SystemColors.ActiveBorder;
            payButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payButton.Location = new Point(15, 190);
            payButton.Name = "payButton";
            payButton.Size = new Size(367, 41);
            payButton.TabIndex = 7;
            payButton.Text = "Make Payment";
            payButton.UseVisualStyleBackColor = false;
            // 
            // dateTextBox
            // 
            dateTextBox.ForeColor = Color.Gray;
            dateTextBox.Location = new Point(15, 144);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(367, 27);
            dateTextBox.TabIndex = 6;
            dateTextBox.Text = "Date:";
            dateTextBox.Click += dateTextBox_Click;
            dateTextBox.TextChanged += dateTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Location = new Point(15, 82);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(367, 27);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Name:";
            nameTextBox.Click += nameTextBox_Click;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.ForeColor = Color.Gray;
            idTextBox.Location = new Point(15, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(367, 27);
            idTextBox.TabIndex = 4;
            idTextBox.Text = "ID:";
            idTextBox.Click += idTextBox_Click;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 244);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Card System";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label nameLabel;
        private Label cardNumberLabel;
        private Label cardDateLabel;
        private Button payButton;
        private TextBox dateTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
    }
}
