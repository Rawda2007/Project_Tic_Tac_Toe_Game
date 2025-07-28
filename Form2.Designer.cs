namespace Tic_Tac_Toe_Game
{
    partial class Form2
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
            this.bReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.TurnPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b7 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bReset.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.ForeColor = System.Drawing.Color.Red;
            this.bReset.Location = new System.Drawing.Point(142, 546);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(167, 57);
            this.bReset.TabIndex = 31;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(84, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 45);
            this.label5.TabIndex = 30;
            this.label5.Text = "Winner : ";
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.Location = new System.Drawing.Point(262, 424);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(156, 34);
            this.Winner.TabIndex = 29;
            this.Winner.Text = "In Progress";
            // 
            // TurnPlayer
            // 
            this.TurnPlayer.AutoSize = true;
            this.TurnPlayer.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnPlayer.Location = new System.Drawing.Point(238, 339);
            this.TurnPlayer.Name = "TurnPlayer";
            this.TurnPlayer.Size = new System.Drawing.Size(105, 34);
            this.TurnPlayer.TabIndex = 28;
            this.TurnPlayer.Text = "Human";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 45);
            this.label2.TabIndex = 27;
            this.label2.Text = "Turn :";
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b7.FlatAppearance.BorderSize = 0;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.Color.Red;
            this.b7.Location = new System.Drawing.Point(505, 519);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(94, 102);
            this.b7.TabIndex = 25;
            this.b7.Tag = "6";
            this.b7.Text = "?";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b9.FlatAppearance.BorderSize = 0;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.Color.Red;
            this.b9.Location = new System.Drawing.Point(878, 519);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(94, 102);
            this.b9.TabIndex = 24;
            this.b9.Tag = "8";
            this.b9.Text = "?";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b8.FlatAppearance.BorderSize = 0;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.Color.Red;
            this.b8.Location = new System.Drawing.Point(687, 519);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(94, 102);
            this.b8.TabIndex = 23;
            this.b8.Tag = "7";
            this.b8.Text = "?";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.Color.Red;
            this.b4.Location = new System.Drawing.Point(505, 339);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(94, 102);
            this.b4.TabIndex = 22;
            this.b4.Tag = "3";
            this.b4.Text = "?";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.Color.Red;
            this.b3.Location = new System.Drawing.Point(865, 162);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(94, 102);
            this.b3.TabIndex = 21;
            this.b3.Tag = "2";
            this.b3.Text = "?";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b6.FlatAppearance.BorderSize = 0;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.Color.Red;
            this.b6.Location = new System.Drawing.Point(865, 339);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(94, 102);
            this.b6.TabIndex = 20;
            this.b6.Tag = "5";
            this.b6.Text = "?";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b5.FlatAppearance.BorderSize = 0;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.Color.Red;
            this.b5.Location = new System.Drawing.Point(687, 339);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(94, 102);
            this.b5.TabIndex = 19;
            this.b5.Tag = "4";
            this.b5.Text = "?";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.Red;
            this.b2.Location = new System.Drawing.Point(687, 162);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(94, 102);
            this.b2.TabIndex = 18;
            this.b2.Tag = "1";
            this.b2.Text = "?";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.Red;
            this.b1.Location = new System.Drawing.Point(505, 162);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(94, 102);
            this.b1.TabIndex = 17;
            this.b1.Tag = "0";
            this.b1.Text = "?";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2025_07_07_010201;
            this.pictureBox1.Location = new System.Drawing.Point(68, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(548, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tic_Tac_Toe_Game";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1080, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.TurnPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form2";
            this.Text = "Tic_Tac_Toe_Game_With_Computer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.Label TurnPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label1;
    }
}