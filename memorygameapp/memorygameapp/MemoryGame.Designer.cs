namespace memorygameapp
{
    partial class MemoryGame
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
            tblMain = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnStart = new Button();
            lblPlayer1Score = new Label();
            txtPlayer1Score = new TextBox();
            lblPlayer2Score = new Label();
            txtPlayer2Score = new TextBox();
            lblCurrentTurn = new Label();
            txtCurrentTurn = new TextBox();
            tblBoard = new TableLayoutPanel();
            btn20 = new Button();
            btn19 = new Button();
            btn18 = new Button();
            btn17 = new Button();
            btn16 = new Button();
            btn15 = new Button();
            btn14 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            btn10 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblBoard.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(tblBoard, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4540863F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.54591F));
            tblMain.Size = new Size(927, 592);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 7;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9063911F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9114628F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.728945F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9114666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.728945F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.906395F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.906395F));
            tblButtons.Controls.Add(btnStart, 0, 0);
            tblButtons.Controls.Add(lblPlayer1Score, 1, 0);
            tblButtons.Controls.Add(txtPlayer1Score, 2, 0);
            tblButtons.Controls.Add(lblPlayer2Score, 3, 0);
            tblButtons.Controls.Add(txtPlayer2Score, 4, 0);
            tblButtons.Controls.Add(lblCurrentTurn, 5, 0);
            tblButtons.Controls.Add(txtCurrentTurn, 6, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(4, 4);
            tblButtons.Margin = new Padding(4);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(919, 53);
            tblButtons.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(4, 4);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 45);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.Anchor = AnchorStyles.Right;
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.Font = new Font("Segoe UI Emoji", 15.75F);
            lblPlayer1Score.Location = new Point(160, 12);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(147, 28);
            lblPlayer1Score.TabIndex = 1;
            lblPlayer1Score.Text = "Player 1 Score:";
            lblPlayer1Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayer1Score
            // 
            txtPlayer1Score.Anchor = AnchorStyles.Left;
            txtPlayer1Score.Location = new Point(313, 12);
            txtPlayer1Score.Name = "txtPlayer1Score";
            txtPlayer1Score.ReadOnly = true;
            txtPlayer1Score.Size = new Size(64, 29);
            txtPlayer1Score.TabIndex = 2;
            txtPlayer1Score.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.Anchor = AnchorStyles.Right;
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.Font = new Font("Segoe UI Emoji", 15.75F);
            lblPlayer2Score.Location = new Point(386, 12);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(147, 28);
            lblPlayer2Score.TabIndex = 3;
            lblPlayer2Score.Text = "Player 2 Score:";
            lblPlayer2Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayer2Score
            // 
            txtPlayer2Score.Anchor = AnchorStyles.Left;
            txtPlayer2Score.Location = new Point(539, 12);
            txtPlayer2Score.Name = "txtPlayer2Score";
            txtPlayer2Score.ReadOnly = true;
            txtPlayer2Score.Size = new Size(64, 29);
            txtPlayer2Score.TabIndex = 4;
            txtPlayer2Score.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCurrentTurn
            // 
            lblCurrentTurn.Anchor = AnchorStyles.Right;
            lblCurrentTurn.AutoSize = true;
            lblCurrentTurn.Font = new Font("Segoe UI Emoji", 15.75F);
            lblCurrentTurn.Location = new Point(630, 12);
            lblCurrentTurn.Name = "lblCurrentTurn";
            lblCurrentTurn.Size = new Size(129, 28);
            lblCurrentTurn.TabIndex = 5;
            lblCurrentTurn.Text = "Current Turn";
            // 
            // txtCurrentTurn
            // 
            txtCurrentTurn.Anchor = AnchorStyles.Left;
            txtCurrentTurn.Location = new Point(765, 12);
            txtCurrentTurn.Name = "txtCurrentTurn";
            txtCurrentTurn.ReadOnly = true;
            txtCurrentTurn.Size = new Size(151, 29);
            txtCurrentTurn.TabIndex = 6;
            txtCurrentTurn.TextAlign = HorizontalAlignment.Center;
            // 
            // tblBoard
            // 
            tblBoard.ColumnCount = 5;
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblBoard.Controls.Add(btn20, 4, 3);
            tblBoard.Controls.Add(btn19, 3, 3);
            tblBoard.Controls.Add(btn18, 2, 3);
            tblBoard.Controls.Add(btn17, 1, 3);
            tblBoard.Controls.Add(btn16, 0, 3);
            tblBoard.Controls.Add(btn15, 4, 2);
            tblBoard.Controls.Add(btn14, 3, 2);
            tblBoard.Controls.Add(btn13, 2, 2);
            tblBoard.Controls.Add(btn12, 1, 2);
            tblBoard.Controls.Add(btn11, 0, 2);
            tblBoard.Controls.Add(btn10, 4, 1);
            tblBoard.Controls.Add(btn9, 3, 1);
            tblBoard.Controls.Add(btn7, 1, 1);
            tblBoard.Controls.Add(btn8, 2, 1);
            tblBoard.Controls.Add(btn1, 0, 0);
            tblBoard.Controls.Add(btn2, 1, 0);
            tblBoard.Controls.Add(btn3, 2, 0);
            tblBoard.Controls.Add(btn4, 3, 0);
            tblBoard.Controls.Add(btn5, 4, 0);
            tblBoard.Controls.Add(btn6, 0, 1);
            tblBoard.Dock = DockStyle.Fill;
            tblBoard.ForeColor = SystemColors.MenuHighlight;
            tblBoard.Location = new Point(3, 64);
            tblBoard.Name = "tblBoard";
            tblBoard.RowCount = 4;
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.Size = new Size(921, 525);
            tblBoard.TabIndex = 1;
            // 
            // btn20
            // 
            btn20.Dock = DockStyle.Fill;
            btn20.FlatStyle = FlatStyle.Popup;
            btn20.Font = new Font("Wingdings", 80.25F);
            btn20.ForeColor = SystemColors.MenuHighlight;
            btn20.Location = new Point(739, 396);
            btn20.Name = "btn20";
            btn20.Size = new Size(179, 126);
            btn20.TabIndex = 19;
            btn20.Text = "u";
            btn20.UseVisualStyleBackColor = true;
            // 
            // btn19
            // 
            btn19.Dock = DockStyle.Fill;
            btn19.FlatStyle = FlatStyle.Popup;
            btn19.Font = new Font("Wingdings", 80.25F);
            btn19.ForeColor = SystemColors.MenuHighlight;
            btn19.Location = new Point(555, 396);
            btn19.Name = "btn19";
            btn19.Size = new Size(178, 126);
            btn19.TabIndex = 18;
            btn19.Text = "u";
            btn19.UseVisualStyleBackColor = true;
            // 
            // btn18
            // 
            btn18.Dock = DockStyle.Fill;
            btn18.FlatStyle = FlatStyle.Popup;
            btn18.Font = new Font("Wingdings", 80.25F);
            btn18.ForeColor = SystemColors.MenuHighlight;
            btn18.Location = new Point(371, 396);
            btn18.Name = "btn18";
            btn18.Size = new Size(178, 126);
            btn18.TabIndex = 17;
            btn18.Text = "u";
            btn18.UseVisualStyleBackColor = true;
            // 
            // btn17
            // 
            btn17.Dock = DockStyle.Fill;
            btn17.FlatStyle = FlatStyle.Popup;
            btn17.Font = new Font("Wingdings", 80.25F);
            btn17.ForeColor = SystemColors.MenuHighlight;
            btn17.Location = new Point(187, 396);
            btn17.Name = "btn17";
            btn17.Size = new Size(178, 126);
            btn17.TabIndex = 16;
            btn17.Text = "u";
            btn17.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            btn16.Dock = DockStyle.Fill;
            btn16.FlatStyle = FlatStyle.Popup;
            btn16.Font = new Font("Wingdings", 80.25F);
            btn16.ForeColor = SystemColors.MenuHighlight;
            btn16.Location = new Point(3, 396);
            btn16.Name = "btn16";
            btn16.Size = new Size(178, 126);
            btn16.TabIndex = 15;
            btn16.Text = "u";
            btn16.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            btn15.Dock = DockStyle.Fill;
            btn15.FlatStyle = FlatStyle.Popup;
            btn15.Font = new Font("Wingdings", 80.25F);
            btn15.ForeColor = SystemColors.MenuHighlight;
            btn15.Location = new Point(739, 265);
            btn15.Name = "btn15";
            btn15.Size = new Size(179, 125);
            btn15.TabIndex = 14;
            btn15.Text = "u";
            btn15.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            btn14.Dock = DockStyle.Fill;
            btn14.FlatStyle = FlatStyle.Popup;
            btn14.Font = new Font("Wingdings", 80.25F);
            btn14.ForeColor = SystemColors.MenuHighlight;
            btn14.Location = new Point(555, 265);
            btn14.Name = "btn14";
            btn14.Size = new Size(178, 125);
            btn14.TabIndex = 13;
            btn14.Text = "u";
            btn14.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            btn13.Dock = DockStyle.Fill;
            btn13.FlatStyle = FlatStyle.Popup;
            btn13.Font = new Font("Wingdings", 80.25F);
            btn13.ForeColor = SystemColors.MenuHighlight;
            btn13.Location = new Point(371, 265);
            btn13.Name = "btn13";
            btn13.Size = new Size(178, 125);
            btn13.TabIndex = 12;
            btn13.Text = "u";
            btn13.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Dock = DockStyle.Fill;
            btn12.FlatStyle = FlatStyle.Popup;
            btn12.Font = new Font("Wingdings", 80.25F);
            btn12.ForeColor = SystemColors.MenuHighlight;
            btn12.Location = new Point(187, 265);
            btn12.Name = "btn12";
            btn12.Size = new Size(178, 125);
            btn12.TabIndex = 11;
            btn12.Text = "u";
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Dock = DockStyle.Fill;
            btn11.FlatStyle = FlatStyle.Popup;
            btn11.Font = new Font("Wingdings", 80.25F);
            btn11.ForeColor = SystemColors.MenuHighlight;
            btn11.Location = new Point(3, 265);
            btn11.Name = "btn11";
            btn11.Size = new Size(178, 125);
            btn11.TabIndex = 10;
            btn11.Text = "u";
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Dock = DockStyle.Fill;
            btn10.FlatStyle = FlatStyle.Popup;
            btn10.Font = new Font("Wingdings", 80.25F);
            btn10.ForeColor = SystemColors.MenuHighlight;
            btn10.Location = new Point(739, 134);
            btn10.Name = "btn10";
            btn10.Size = new Size(179, 125);
            btn10.TabIndex = 9;
            btn10.Text = "u";
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Wingdings", 80.25F);
            btn9.ForeColor = SystemColors.MenuHighlight;
            btn9.Location = new Point(555, 134);
            btn9.Name = "btn9";
            btn9.Size = new Size(178, 125);
            btn9.TabIndex = 8;
            btn9.Text = "u";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Wingdings", 80.25F);
            btn7.ForeColor = SystemColors.MenuHighlight;
            btn7.Location = new Point(187, 134);
            btn7.Name = "btn7";
            btn7.Size = new Size(178, 125);
            btn7.TabIndex = 7;
            btn7.Text = "u";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Wingdings", 80.25F);
            btn8.ForeColor = SystemColors.MenuHighlight;
            btn8.Location = new Point(371, 134);
            btn8.Name = "btn8";
            btn8.Size = new Size(178, 125);
            btn8.TabIndex = 6;
            btn8.Text = "u";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Wingdings", 80.25F);
            btn1.ForeColor = SystemColors.MenuHighlight;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(178, 125);
            btn1.TabIndex = 0;
            btn1.Text = "u";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Wingdings", 80.25F);
            btn2.ForeColor = SystemColors.MenuHighlight;
            btn2.Location = new Point(187, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(178, 125);
            btn2.TabIndex = 1;
            btn2.Text = "u";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Wingdings", 80.25F);
            btn3.ForeColor = SystemColors.MenuHighlight;
            btn3.Location = new Point(371, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(178, 125);
            btn3.TabIndex = 2;
            btn3.Text = "u";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Wingdings", 80.25F);
            btn4.ForeColor = SystemColors.MenuHighlight;
            btn4.Location = new Point(555, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(178, 125);
            btn4.TabIndex = 3;
            btn4.Text = "u";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Wingdings", 80.25F);
            btn5.ForeColor = SystemColors.MenuHighlight;
            btn5.Location = new Point(739, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(179, 125);
            btn5.TabIndex = 4;
            btn5.Text = "u";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Wingdings", 80.25F);
            btn6.ForeColor = SystemColors.MenuHighlight;
            btn6.Location = new Point(3, 134);
            btn6.Name = "btn6";
            btn6.Size = new Size(178, 125);
            btn6.TabIndex = 5;
            btn6.Text = "u";
            btn6.UseVisualStyleBackColor = true;
            // 
            // MemoryGame
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 592);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MemoryGame";
            Text = "MemoryGame";
            tblMain.ResumeLayout(false);
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblBoard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnStart;
        private Label lblPlayer1Score;
        private TextBox txtPlayer1Score;
        private Label lblPlayer2Score;
        private TextBox txtPlayer2Score;
        private Label lblCurrentTurn;
        private TextBox txtCurrentTurn;
        private TableLayoutPanel tblBoard;
        private Button btn20;
        private Button btn19;
        private Button btn18;
        private Button btn17;
        private Button btn16;
        private Button btn15;
        private Button btn14;
        private Button btn13;
        private Button btn12;
        private Button btn11;
        private Button btn10;
        private Button btn9;
        private Button btn7;
        private Button btn8;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
    }
}