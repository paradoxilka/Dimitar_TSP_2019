namespace lab3_part1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareEquasionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thGradeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thGradeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mathsToolStripMenuItem
            // 
            this.mathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algebraToolStripMenuItem});
            this.mathsToolStripMenuItem.Name = "mathsToolStripMenuItem";
            this.mathsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.mathsToolStripMenuItem.Text = "Math formulas";
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thGradeToolStripMenuItem,
            this.thGradeToolStripMenuItem1,
            this.thGradeToolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.algebraToolStripMenuItem.Text = "Algebra";
            // 
            // thGradeToolStripMenuItem
            // 
            this.thGradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerToolStripMenuItem,
            this.factoringToolStripMenuItem,
            this.squareEquasionToolStripMenuItem});
            this.thGradeToolStripMenuItem.Name = "thGradeToolStripMenuItem";
            this.thGradeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thGradeToolStripMenuItem.Text = "6-th Grade";
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // factoringToolStripMenuItem
            // 
            this.factoringToolStripMenuItem.Name = "factoringToolStripMenuItem";
            this.factoringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.factoringToolStripMenuItem.Text = "Binomial Theorem";
            this.factoringToolStripMenuItem.Click += new System.EventHandler(this.factoringToolStripMenuItem_Click);
            // 
            // squareEquasionToolStripMenuItem
            // 
            this.squareEquasionToolStripMenuItem.Name = "squareEquasionToolStripMenuItem";
            this.squareEquasionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.squareEquasionToolStripMenuItem.Text = "Quadratic formula";
            this.squareEquasionToolStripMenuItem.Click += new System.EventHandler(this.squareEquasionToolStripMenuItem_Click);
            // 
            // thGradeToolStripMenuItem1
            // 
            this.thGradeToolStripMenuItem1.Name = "thGradeToolStripMenuItem1";
            this.thGradeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.thGradeToolStripMenuItem1.Text = "7-th Grade";
            // 
            // thGradeToolStripMenuItem2
            // 
            this.thGradeToolStripMenuItem2.Name = "thGradeToolStripMenuItem2";
            this.thGradeToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.thGradeToolStripMenuItem2.Text = "8-th Grade";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 44);
            this.label6.TabIndex = 53;
            this.label6.Text = "Behold, the smartest calculator in the world!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(611, 256);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "I have no idea what am I doing?!?!?";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareEquasionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thGradeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thGradeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
    }
}

