namespace GradeTrackerV3
{
    partial class MainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMaximize = new FontAwesome.Sharp.IconButton();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnStatistics);
            this.panelMenu.Controls.Add(this.btnEdit);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 479);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAbout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconSize = 32;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 330);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnAbout.Rotation = 0D;
            this.btnAbout.Size = new System.Drawing.Size(220, 70);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStatistics.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnStatistics.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.IconSize = 32;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 260);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnStatistics.Rotation = 0D;
            this.btnStatistics.Size = new System.Drawing.Size(220, 70);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconSize = 32;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnEdit.Rotation = 0D;
            this.btnEdit.Size = new System.Drawing.Size(220, 70);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 120);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(220, 70);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GradeTrackerV3.Properties.Resources.LogoMakr_4g9NlW;
            this.btnHome.Location = new System.Drawing.Point(3, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(211, 91);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelTitleBar.Controls.Add(this.iconMaximize);
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconClose);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(753, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMaximize.FlatAppearance.BorderSize = 0;
            this.iconMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconSize = 26;
            this.iconMaximize.Location = new System.Drawing.Point(686, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Rotation = 0D;
            this.iconMaximize.Size = new System.Drawing.Size(29, 23);
            this.iconMaximize.TabIndex = 2;
            this.iconMaximize.UseVisualStyleBackColor = true;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMinimize.FlatAppearance.BorderSize = 0;
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconSize = 26;
            this.iconMinimize.Location = new System.Drawing.Point(651, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Rotation = 0D;
            this.iconMinimize.Size = new System.Drawing.Size(29, 23);
            this.iconMinimize.TabIndex = 1;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconClose.FlatAppearance.BorderSize = 0;
            this.iconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconClose.ForeColor = System.Drawing.Color.Transparent;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconClose.IconSize = 26;
            this.iconClose.Location = new System.Drawing.Point(721, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Rotation = 0D;
            this.iconClose.Size = new System.Drawing.Size(29, 23);
            this.iconClose.TabIndex = 3;
            this.iconClose.UseVisualStyleBackColor = true;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(250, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(201, 43);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "GradeLab";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(753, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(753, 390);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(973, 479);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconMaximize;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}

