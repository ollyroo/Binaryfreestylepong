namespace Binaryfreestylepong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.playertimer = new System.Windows.Forms.Timer(this.components);
            this.Player2score = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.Player1score = new System.Windows.Forms.Label();
            this.topWall = new System.Windows.Forms.PictureBox();
            this.bottomWall = new System.Windows.Forms.PictureBox();
            this.rightWall = new System.Windows.Forms.PictureBox();
            this.leftWall = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.playerTwo = new System.Windows.Forms.PictureBox();
            this.introBox = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 1;
            this.ballTimer.Tick += new System.EventHandler(this.ballTimer_Tick);
            // 
            // playertimer
            // 
            this.playertimer.Interval = 2;
            this.playertimer.Tick += new System.EventHandler(this.playertimer_Tick);
            // 
            // Player2score
            // 
            this.Player2score.AutoSize = true;
            this.Player2score.Location = new System.Drawing.Point(382, 23);
            this.Player2score.Name = "Player2score";
            this.Player2score.Size = new System.Drawing.Size(42, 13);
            this.Player2score.TabIndex = 7;
            this.Player2score.Text = "Player2";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(382, 44);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(13, 13);
            this.score2.TabIndex = 8;
            this.score2.Text = "0";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(29, 44);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(13, 13);
            this.score1.TabIndex = 10;
            this.score1.Text = "0";
            // 
            // Player1score
            // 
            this.Player1score.AutoSize = true;
            this.Player1score.Location = new System.Drawing.Point(29, 23);
            this.Player1score.Name = "Player1score";
            this.Player1score.Size = new System.Drawing.Size(42, 13);
            this.Player1score.TabIndex = 9;
            this.Player1score.Text = "Player1";
            // 
            // topWall
            // 
            this.topWall.Image = global::Binaryfreestylepong.Properties.Resources.barHorizontal;
            this.topWall.Location = new System.Drawing.Point(20, 0);
            this.topWall.Name = "topWall";
            this.topWall.Size = new System.Drawing.Size(420, 20);
            this.topWall.TabIndex = 6;
            this.topWall.TabStop = false;
            // 
            // bottomWall
            // 
            this.bottomWall.Image = global::Binaryfreestylepong.Properties.Resources.barHorizontal;
            this.bottomWall.Location = new System.Drawing.Point(20, 401);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(420, 20);
            this.bottomWall.TabIndex = 5;
            this.bottomWall.TabStop = false;
            // 
            // rightWall
            // 
            this.rightWall.Image = global::Binaryfreestylepong.Properties.Resources.barVertical;
            this.rightWall.Location = new System.Drawing.Point(440, 0);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(20, 421);
            this.rightWall.TabIndex = 4;
            this.rightWall.TabStop = false;
            // 
            // leftWall
            // 
            this.leftWall.Image = global::Binaryfreestylepong.Properties.Resources.barVertical;
            this.leftWall.Location = new System.Drawing.Point(0, 0);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(23, 443);
            this.leftWall.TabIndex = 3;
            this.leftWall.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::Binaryfreestylepong.Properties.Resources.ballBlack;
            this.ball.InitialImage = null;
            this.ball.Location = new System.Drawing.Point(207, 184);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 26);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // playerOne
            // 
            this.playerOne.BackColor = System.Drawing.Color.Transparent;
            this.playerOne.Image = global::Binaryfreestylepong.Properties.Resources.White;
            this.playerOne.Location = new System.Drawing.Point(57, 258);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(116, 20);
            this.playerOne.TabIndex = 1;
            this.playerOne.TabStop = false;
            // 
            // playerTwo
            // 
            this.playerTwo.Image = global::Binaryfreestylepong.Properties.Resources.black;
            this.playerTwo.Location = new System.Drawing.Point(314, 135);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(20, 116);
            this.playerTwo.TabIndex = 0;
            this.playerTwo.TabStop = false;
            // 
            // introBox
            // 
            this.introBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.introBox.Location = new System.Drawing.Point(487, 41);
            this.introBox.Name = "introBox";
            this.introBox.ReadOnly = true;
            this.introBox.Size = new System.Drawing.Size(223, 73);
            this.introBox.TabIndex = 11;
            this.introBox.Text = resources.GetString("introBox.Text");
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(487, 344);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(223, 64);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(734, 420);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.introBox);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.Player1score);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.Player2score);
            this.Controls.Add(this.topWall);
            this.Controls.Add(this.bottomWall);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.playerTwo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Binaryfreestylepong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerTwo;
        private System.Windows.Forms.PictureBox playerOne;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.PictureBox leftWall;
        private System.Windows.Forms.PictureBox rightWall;
        private System.Windows.Forms.PictureBox bottomWall;
        private System.Windows.Forms.PictureBox topWall;
        private System.Windows.Forms.Timer playertimer;
        private System.Windows.Forms.Label Player2score;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label Player1score;
        private System.Windows.Forms.RichTextBox introBox;
        private System.Windows.Forms.Button StartButton;
    }
}

