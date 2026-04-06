namespace Tic_Tac_Toe_Game_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_turn_fix = new System.Windows.Forms.Label();
            this.lbl_Player_turn = new System.Windows.Forms.Label();
            this.lbl_winner_fix = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_restart_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(519, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // lbl_turn_fix
            // 
            this.lbl_turn_fix.AutoSize = true;
            this.lbl_turn_fix.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turn_fix.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_turn_fix.Location = new System.Drawing.Point(181, 132);
            this.lbl_turn_fix.Name = "lbl_turn_fix";
            this.lbl_turn_fix.Size = new System.Drawing.Size(98, 42);
            this.lbl_turn_fix.TabIndex = 10;
            this.lbl_turn_fix.Text = "Turn";
            // 
            // lbl_Player_turn
            // 
            this.lbl_Player_turn.AutoSize = true;
            this.lbl_Player_turn.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_turn.ForeColor = System.Drawing.Color.White;
            this.lbl_Player_turn.Location = new System.Drawing.Point(150, 207);
            this.lbl_Player_turn.Name = "lbl_Player_turn";
            this.lbl_Player_turn.Size = new System.Drawing.Size(161, 42);
            this.lbl_Player_turn.TabIndex = 11;
            this.lbl_Player_turn.Text = "Player 1";
            // 
            // lbl_winner_fix
            // 
            this.lbl_winner_fix.AutoSize = true;
            this.lbl_winner_fix.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner_fix.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_winner_fix.Location = new System.Drawing.Point(158, 282);
            this.lbl_winner_fix.Name = "lbl_winner_fix";
            this.lbl_winner_fix.Size = new System.Drawing.Size(145, 42);
            this.lbl_winner_fix.TabIndex = 12;
            this.lbl_winner_fix.Text = "Winner";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_winner.Location = new System.Drawing.Point(120, 357);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(221, 42);
            this.lbl_winner.TabIndex = 13;
            this.lbl_winner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(467, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 98);
            this.button1.TabIndex = 15;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(619, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 98);
            this.button2.TabIndex = 16;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(771, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 98);
            this.button3.TabIndex = 17;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(467, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 98);
            this.button4.TabIndex = 18;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(619, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 98);
            this.button5.TabIndex = 19;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(771, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 98);
            this.button6.TabIndex = 20;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(467, 396);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 98);
            this.button7.TabIndex = 21;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(619, 396);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 98);
            this.button8.TabIndex = 22;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game_Project.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(771, 396);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 98);
            this.button9.TabIndex = 23;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_restart_game
            // 
            this.btn_restart_game.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restart_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_restart_game.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart_game.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_restart_game.Location = new System.Drawing.Point(120, 432);
            this.btn_restart_game.Name = "btn_restart_game";
            this.btn_restart_game.Size = new System.Drawing.Size(221, 42);
            this.btn_restart_game.TabIndex = 24;
            this.btn_restart_game.Text = "Restart Game";
            this.btn_restart_game.UseVisualStyleBackColor = false;
            this.btn_restart_game.Click += new System.EventHandler(this.btn_restart_game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(973, 580);
            this.Controls.Add(this.btn_restart_game);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.lbl_winner_fix);
            this.Controls.Add(this.lbl_Player_turn);
            this.Controls.Add(this.lbl_turn_fix);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_turn_fix;
        private System.Windows.Forms.Label lbl_Player_turn;
        private System.Windows.Forms.Label lbl_winner_fix;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_restart_game;
    }
}

