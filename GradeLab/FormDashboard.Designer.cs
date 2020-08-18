using System.Drawing;
using System.Windows.Forms;

namespace GradeTrackerV3
{
    partial class FormDashboard
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
            this.panelSemesterBorder = new System.Windows.Forms.Panel();
            this.panelGrades = new System.Windows.Forms.Panel();
            this.listboxCourseSelection = new System.Windows.Forms.ListBox();
            this.panelCurrentSelection = new System.Windows.Forms.Panel();
            this.btnAddNewCourse = new FontAwesome.Sharp.IconButton();
            this.textboxCurrentSelection = new System.Windows.Forms.TextBox();
            this.lblCurrentSelection = new System.Windows.Forms.Label();
            this.panelSemester = new System.Windows.Forms.Panel();
            this.listboxSemester = new System.Windows.Forms.ListBox();
            this.panelSemesterLabel = new System.Windows.Forms.Panel();
            this.lblSemester = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelProjections = new System.Windows.Forms.Panel();
            this.lblProjectionTitle = new System.Windows.Forms.Label();
            this.panelHeaderGap = new System.Windows.Forms.Panel();
            this.panelGrades.SuspendLayout();
            this.panelCurrentSelection.SuspendLayout();
            this.panelSemester.SuspendLayout();
            this.panelSemesterLabel.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelProjections.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSemesterBorder
            // 
            this.panelSemesterBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelSemesterBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSemesterBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelSemesterBorder.Location = new System.Drawing.Point(160, 0);
            this.panelSemesterBorder.Name = "panelSemesterBorder";
            this.panelSemesterBorder.Size = new System.Drawing.Size(2, 471);
            this.panelSemesterBorder.TabIndex = 1;
            // 
            // panelGrades
            // 
            this.panelGrades.Controls.Add(this.listboxCourseSelection);
            this.panelGrades.Controls.Add(this.panelCurrentSelection);
            this.panelGrades.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrades.Location = new System.Drawing.Point(5, 0);
            this.panelGrades.Name = "panelGrades";
            this.panelGrades.Size = new System.Drawing.Size(858, 138);
            this.panelGrades.TabIndex = 2;
            // 
            // listboxCourseSelection
            // 
            this.listboxCourseSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.listboxCourseSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxCourseSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listboxCourseSelection.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCourseSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.listboxCourseSelection.FormattingEnabled = true;
            this.listboxCourseSelection.HorizontalScrollbar = true;
            this.listboxCourseSelection.ItemHeight = 21;
            this.listboxCourseSelection.Items.AddRange(new object[] {
            "ENGG 1100",
            "ENGG 2100",
            "ENGG 3100",
            "ENGG 4100",
            "ENGG 5100",
            "ENGG 6100"});
            this.listboxCourseSelection.Location = new System.Drawing.Point(0, 75);
            this.listboxCourseSelection.MultiColumn = true;
            this.listboxCourseSelection.Name = "listboxCourseSelection";
            this.listboxCourseSelection.ScrollAlwaysVisible = true;
            this.listboxCourseSelection.Size = new System.Drawing.Size(858, 63);
            this.listboxCourseSelection.TabIndex = 0;
            // 
            // panelCurrentSelection
            // 
            this.panelCurrentSelection.Controls.Add(this.btnAddNewCourse);
            this.panelCurrentSelection.Controls.Add(this.textboxCurrentSelection);
            this.panelCurrentSelection.Controls.Add(this.lblCurrentSelection);
            this.panelCurrentSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentSelection.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentSelection.Name = "panelCurrentSelection";
            this.panelCurrentSelection.Size = new System.Drawing.Size(858, 60);
            this.panelCurrentSelection.TabIndex = 0;
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddNewCourse.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddNewCourse.IconColor = System.Drawing.Color.Black;
            this.btnAddNewCourse.IconSize = 16;
            this.btnAddNewCourse.Location = new System.Drawing.Point(694, 17);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Rotation = 0D;
            this.btnAddNewCourse.Size = new System.Drawing.Size(164, 28);
            this.btnAddNewCourse.TabIndex = 2;
            this.btnAddNewCourse.Text = "Add New Course";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            // 
            // textboxCurrentSelection
            // 
            this.textboxCurrentSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.textboxCurrentSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxCurrentSelection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCurrentSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.textboxCurrentSelection.Location = new System.Drawing.Point(185, 22);
            this.textboxCurrentSelection.Name = "textboxCurrentSelection";
            this.textboxCurrentSelection.Size = new System.Drawing.Size(100, 23);
            this.textboxCurrentSelection.TabIndex = 1;
            this.textboxCurrentSelection.Text = "Winter 2019";
            // 
            // lblCurrentSelection
            // 
            this.lblCurrentSelection.AutoSize = true;
            this.lblCurrentSelection.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentSelection.Location = new System.Drawing.Point(-3, 19);
            this.lblCurrentSelection.Name = "lblCurrentSelection";
            this.lblCurrentSelection.Size = new System.Drawing.Size(182, 23);
            this.lblCurrentSelection.TabIndex = 0;
            this.lblCurrentSelection.Text = "Current Selection:";
            // 
            // panelSemester
            // 
            this.panelSemester.Controls.Add(this.listboxSemester);
            this.panelSemester.Controls.Add(this.panelSemesterLabel);
            this.panelSemester.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSemester.Location = new System.Drawing.Point(0, 0);
            this.panelSemester.Name = "panelSemester";
            this.panelSemester.Size = new System.Drawing.Size(160, 471);
            this.panelSemester.TabIndex = 0;
            // 
            // listboxSemester
            // 
            this.listboxSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.listboxSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxSemester.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxSemester.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxSemester.ForeColor = System.Drawing.Color.Gainsboro;
            this.listboxSemester.FormattingEnabled = true;
            this.listboxSemester.ItemHeight = 21;
            this.listboxSemester.Items.AddRange(new object[] {
            "Winter 2019",
            "Summer 2019",
            "Fall 2019",
            "Winter 2020",
            "Summer 2020",
            "Fall 2020"});
            this.listboxSemester.Location = new System.Drawing.Point(3, 60);
            this.listboxSemester.Name = "listboxSemester";
            this.listboxSemester.Size = new System.Drawing.Size(157, 411);
            this.listboxSemester.TabIndex = 2;
            // 
            // panelSemesterLabel
            // 
            this.panelSemesterLabel.Controls.Add(this.lblSemester);
            this.panelSemesterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSemesterLabel.Location = new System.Drawing.Point(0, 0);
            this.panelSemesterLabel.Name = "panelSemesterLabel";
            this.panelSemesterLabel.Size = new System.Drawing.Size(160, 60);
            this.panelSemesterLabel.TabIndex = 1;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSemester.Location = new System.Drawing.Point(29, 19);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(100, 23);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "SEMESTER";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelProjections);
            this.panelHeader.Controls.Add(this.panelGrades);
            this.panelHeader.Controls.Add(this.panelHeaderGap);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(162, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1011, 138);
            this.panelHeader.TabIndex = 4;
            // 
            // panelProjections
            // 
            this.panelProjections.Controls.Add(this.lblProjectionTitle);
            this.panelProjections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjections.Location = new System.Drawing.Point(863, 0);
            this.panelProjections.Name = "panelProjections";
            this.panelProjections.Size = new System.Drawing.Size(148, 138);
            this.panelProjections.TabIndex = 3;
            // 
            // lblProjectionTitle
            // 
            this.lblProjectionTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProjectionTitle.AutoSize = true;
            this.lblProjectionTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectionTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProjectionTitle.Location = new System.Drawing.Point(17, 63);
            this.lblProjectionTitle.Name = "lblProjectionTitle";
            this.lblProjectionTitle.Size = new System.Drawing.Size(113, 23);
            this.lblProjectionTitle.TabIndex = 0;
            this.lblProjectionTitle.Text = "Projections";
            // 
            // panelHeaderGap
            // 
            this.panelHeaderGap.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeaderGap.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderGap.Name = "panelHeaderGap";
            this.panelHeaderGap.Size = new System.Drawing.Size(5, 138);
            this.panelHeaderGap.TabIndex = 4;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1173, 471);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSemesterBorder);
            this.Controls.Add(this.panelSemester);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panelGrades.ResumeLayout(false);
            this.panelCurrentSelection.ResumeLayout(false);
            this.panelCurrentSelection.PerformLayout();
            this.panelSemester.ResumeLayout(false);
            this.panelSemesterLabel.ResumeLayout(false);
            this.panelSemesterLabel.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelProjections.ResumeLayout(false);
            this.panelProjections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSemesterBorder;
        private System.Windows.Forms.Panel panelGrades;
        private System.Windows.Forms.Panel panelCurrentSelection;
        private System.Windows.Forms.Label lblCurrentSelection;
        private System.Windows.Forms.Panel panelSemester;
        private System.Windows.Forms.Panel panelSemesterLabel;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ListBox listboxSemester;
        private System.Windows.Forms.TextBox textboxCurrentSelection;
        private ListBox listboxCourseSelection;
        private FontAwesome.Sharp.IconButton btnAddNewCourse;
        private Panel panelHeader;
        private Panel panelProjections;
        private Label lblProjectionTitle;
        private Panel panelHeaderGap;
    }


}