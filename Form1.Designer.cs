namespace TicTacToe
{
    partial class TicTacToeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGaneToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGaneToolStripMenuItem
            // 
            this.newGaneToolStripMenuItem.Name = "newGaneToolStripMenuItem";
            this.newGaneToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.newGaneToolStripMenuItem.Text = "New Gane";
            this.newGaneToolStripMenuItem.Click += new System.EventHandler(this.NewGaneToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.B9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.B8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.B7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.B5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.B3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.B2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.B1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.Color.LightGray;
            this.B9.Dock = System.Windows.Forms.DockStyle.Right;
            this.B9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.ForeColor = System.Drawing.Color.Black;
            this.B9.Location = new System.Drawing.Point(318, 245);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(150, 116);
            this.B9.TabIndex = 8;
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.Button_Click);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.Color.LightGray;
            this.B8.Dock = System.Windows.Forms.DockStyle.Right;
            this.B8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.ForeColor = System.Drawing.Color.Black;
            this.B8.Location = new System.Drawing.Point(160, 245);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(150, 116);
            this.B8.TabIndex = 7;
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.Button_Click);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.Color.LightGray;
            this.B7.Dock = System.Windows.Forms.DockStyle.Right;
            this.B7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.ForeColor = System.Drawing.Color.Black;
            this.B7.Location = new System.Drawing.Point(3, 245);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(150, 116);
            this.B7.TabIndex = 6;
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.Button_Click);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.Color.LightGray;
            this.B6.Dock = System.Windows.Forms.DockStyle.Right;
            this.B6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.ForeColor = System.Drawing.Color.Black;
            this.B6.Location = new System.Drawing.Point(318, 124);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(150, 115);
            this.B6.TabIndex = 5;
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.Button_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.LightGray;
            this.B5.Dock = System.Windows.Forms.DockStyle.Right;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.ForeColor = System.Drawing.Color.Black;
            this.B5.Location = new System.Drawing.Point(160, 124);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(150, 115);
            this.B5.TabIndex = 4;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.Button_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.LightGray;
            this.B4.Dock = System.Windows.Forms.DockStyle.Right;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.ForeColor = System.Drawing.Color.Black;
            this.B4.Location = new System.Drawing.Point(3, 124);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(150, 115);
            this.B4.TabIndex = 3;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.LightGray;
            this.B3.Dock = System.Windows.Forms.DockStyle.Right;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.Black;
            this.B3.Location = new System.Drawing.Point(318, 3);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(150, 115);
            this.B3.TabIndex = 2;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.LightGray;
            this.B2.Dock = System.Windows.Forms.DockStyle.Right;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.Black;
            this.B2.Location = new System.Drawing.Point(160, 3);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(150, 115);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.LightGray;
            this.B1.Dock = System.Windows.Forms.DockStyle.Right;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.Black;
            this.B1.Location = new System.Drawing.Point(3, 3);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(150, 115);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "TicTacToeForm";
            this.ShowIcon = false;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
    }
}

