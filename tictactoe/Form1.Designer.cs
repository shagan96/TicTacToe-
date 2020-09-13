namespace tictactoe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abountMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abountMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abountMeToolStripMenuItem
            // 
            this.abountMeToolStripMenuItem.Name = "abountMeToolStripMenuItem";
            this.abountMeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.abountMeToolStripMenuItem.Text = "&Abount me !";
            this.abountMeToolStripMenuItem.Click += new System.EventHandler(this.abountMeToolStripMenuItem_Click);
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(13, 48);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(55, 54);
            this.btnA1.TabIndex = 1;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.UseWaitCursor = true;
            this.btnA1.Click += new System.EventHandler(this.click_Button);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(12, 196);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(55, 54);
            this.btnA3.TabIndex = 2;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.click_Button);
            // 
            // btnC2
            // 
            this.btnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(154, 120);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(55, 54);
            this.btnC2.TabIndex = 3;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.click_Button);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(83, 120);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(55, 54);
            this.btnB2.TabIndex = 4;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.click_Button);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(13, 120);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(55, 54);
            this.btnA2.TabIndex = 5;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.click_Button);
            // 
            // btnC1
            // 
            this.btnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(154, 48);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(55, 54);
            this.btnC1.TabIndex = 6;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.click_Button);
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(83, 48);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(55, 54);
            this.btnB1.TabIndex = 7;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.click_Button);
            // 
            // btnC3
            // 
            this.btnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(154, 196);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(55, 54);
            this.btnC3.TabIndex = 8;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.click_Button);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(83, 196);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(55, 54);
            this.btnB3.TabIndex = 9;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.click_Button);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 262);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abountMeToolStripMenuItem;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnB3;
    }
}

