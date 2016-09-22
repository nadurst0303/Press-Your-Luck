namespace Press_Your_Luck
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.spinButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.passButton = new System.Windows.Forms.Button();
            this.playerOneGroupBox = new System.Windows.Forms.GroupBox();
            this.playerOnePoints = new System.Windows.Forms.Label();
            this.playerTwoGroupBox = new System.Windows.Forms.GroupBox();
            this.playerTwoPoints = new System.Windows.Forms.Label();
            this.playerOneSpins = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.playerTwoSpins = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerOneGroupBox.SuspendLayout();
            this.playerTwoGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(363, 144);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(100, 50);
            this.spinButton.TabIndex = 16;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(364, 88);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 25);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(42, 349);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(274, 22);
            this.answerTextBox.TabIndex = 20;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(39, 279);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(46, 17);
            this.questionLabel.TabIndex = 21;
            this.questionLabel.Text = "label1";
            // 
            // passButton
            // 
            this.passButton.Location = new System.Drawing.Point(364, 220);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(100, 30);
            this.passButton.TabIndex = 22;
            this.passButton.Text = "Pass A Spin";
            this.passButton.UseVisualStyleBackColor = true;
            // 
            // playerOneGroupBox
            // 
            this.playerOneGroupBox.Controls.Add(this.playerOnePoints);
            this.playerOneGroupBox.Location = new System.Drawing.Point(42, 381);
            this.playerOneGroupBox.Name = "playerOneGroupBox";
            this.playerOneGroupBox.Size = new System.Drawing.Size(125, 60);
            this.playerOneGroupBox.TabIndex = 23;
            this.playerOneGroupBox.TabStop = false;
            this.playerOneGroupBox.Text = "Player One";
            // 
            // playerOnePoints
            // 
            this.playerOnePoints.AutoSize = true;
            this.playerOnePoints.Location = new System.Drawing.Point(6, 28);
            this.playerOnePoints.Name = "playerOnePoints";
            this.playerOnePoints.Size = new System.Drawing.Size(46, 17);
            this.playerOnePoints.TabIndex = 0;
            this.playerOnePoints.Text = "label2";
            // 
            // playerTwoGroupBox
            // 
            this.playerTwoGroupBox.Controls.Add(this.playerTwoPoints);
            this.playerTwoGroupBox.Location = new System.Drawing.Point(272, 381);
            this.playerTwoGroupBox.Name = "playerTwoGroupBox";
            this.playerTwoGroupBox.Size = new System.Drawing.Size(125, 60);
            this.playerTwoGroupBox.TabIndex = 24;
            this.playerTwoGroupBox.TabStop = false;
            this.playerTwoGroupBox.Text = "Player Two";
            // 
            // playerTwoPoints
            // 
            this.playerTwoPoints.AutoSize = true;
            this.playerTwoPoints.Location = new System.Drawing.Point(6, 28);
            this.playerTwoPoints.Name = "playerTwoPoints";
            this.playerTwoPoints.Size = new System.Drawing.Size(46, 17);
            this.playerTwoPoints.TabIndex = 0;
            this.playerTwoPoints.Text = "label4";
            // 
            // playerOneSpins
            // 
            this.playerOneSpins.AutoSize = true;
            this.playerOneSpins.Location = new System.Drawing.Point(8, 28);
            this.playerOneSpins.Name = "playerOneSpins";
            this.playerOneSpins.Size = new System.Drawing.Size(46, 17);
            this.playerOneSpins.TabIndex = 0;
            this.playerOneSpins.Text = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.playerOneSpins);
            this.groupBox3.Location = new System.Drawing.Point(173, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(70, 60);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spins";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.playerTwoSpins);
            this.groupBox4.Location = new System.Drawing.Point(403, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(70, 60);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spins";
            // 
            // playerTwoSpins
            // 
            this.playerTwoSpins.AutoSize = true;
            this.playerTwoSpins.Location = new System.Drawing.Point(8, 28);
            this.playerTwoSpins.Name = "playerTwoSpins";
            this.playerTwoSpins.Size = new System.Drawing.Size(46, 17);
            this.playerTwoSpins.TabIndex = 0;
            this.playerTwoSpins.Text = "label5";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(363, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 25);
            this.startButton.TabIndex = 27;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(42, 144);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(50, 50);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(42, 200);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(98, 200);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(154, 200);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(210, 200);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(266, 200);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(42, 88);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(266, 144);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(266, 88);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(98, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(154, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(210, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(266, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(98, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.playerTwoGroupBox);
            this.Controls.Add(this.playerOneGroupBox);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameBoard";
            this.Text = "Press Your Luck";
            this.playerOneGroupBox.ResumeLayout(false);
            this.playerOneGroupBox.PerformLayout();
            this.playerTwoGroupBox.ResumeLayout(false);
            this.playerTwoGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.PictureBox[] tile;
        

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.GroupBox playerOneGroupBox;
        private System.Windows.Forms.Label playerOnePoints;
        private System.Windows.Forms.GroupBox playerTwoGroupBox;
        private System.Windows.Forms.Label playerTwoPoints;
        private System.Windows.Forms.Label playerOneSpins;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label playerTwoSpins;
        private System.Windows.Forms.Button startButton;
    }
}

