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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSemesterBorder = new System.Windows.Forms.Panel();
            this.panelGrades = new System.Windows.Forms.Panel();
            this.panelHeaderBottomBorder = new System.Windows.Forms.Panel();
            this.panelHeaderTopBorder = new System.Windows.Forms.Panel();
            this.listboxCourseSelection = new System.Windows.Forms.ListBox();
            this.panelCurrentSelection = new System.Windows.Forms.Panel();
            this.btnAddNewCourse = new FontAwesome.Sharp.IconButton();
            this.lblCurrentSelection = new System.Windows.Forms.Label();
            this.panelSemester = new System.Windows.Forms.Panel();
            this.listboxSemester = new System.Windows.Forms.ListBox();
            this.panelSemesterLabel = new System.Windows.Forms.Panel();
            this.lblSemester = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelProjectionsLeftBorder = new System.Windows.Forms.Panel();
            this.panelProjections = new System.Windows.Forms.Panel();
            this.lblProjectionTitle = new System.Windows.Forms.Label();
            this.panelGradeTableContainer = new System.Windows.Forms.Panel();
            this.panelFinalMarkContainer = new System.Windows.Forms.Panel();
            this.lblFinalExamWorth = new System.Windows.Forms.Label();
            this.lblCurrentMarkYourMark = new System.Windows.Forms.Label();
            this.lblCurrentMarkWorth = new System.Windows.Forms.Label();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.lblCurrentMark = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGradeTable = new System.Windows.Forms.Panel();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YourMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelGradeTableRightBorder = new System.Windows.Forms.Panel();
            this.panelBottomButton = new System.Windows.Forms.Panel();
            this.iconButtonSaveTable = new FontAwesome.Sharp.IconButton();
            this.iconButtonResetTable = new FontAwesome.Sharp.IconButton();
            this.iconButtonClearTable = new FontAwesome.Sharp.IconButton();
            this.iconButtonDeleteCourse = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGrades.SuspendLayout();
            this.panelCurrentSelection.SuspendLayout();
            this.panelSemester.SuspendLayout();
            this.panelSemesterLabel.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelProjections.SuspendLayout();
            this.panelGradeTableContainer.SuspendLayout();
            this.panelFinalMarkContainer.SuspendLayout();
            this.panelGradeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelBottomButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSemesterBorder
            // 
            this.panelSemesterBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelSemesterBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSemesterBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelSemesterBorder.Location = new System.Drawing.Point(160, 0);
            this.panelSemesterBorder.Name = "panelSemesterBorder";
            this.panelSemesterBorder.Size = new System.Drawing.Size(2, 889);
            this.panelSemesterBorder.TabIndex = 1;
            // 
            // panelGrades
            // 
            this.panelGrades.Controls.Add(this.panelHeaderBottomBorder);
            this.panelGrades.Controls.Add(this.panelHeaderTopBorder);
            this.panelGrades.Controls.Add(this.listboxCourseSelection);
            this.panelGrades.Controls.Add(this.panelCurrentSelection);
            this.panelGrades.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrades.Location = new System.Drawing.Point(0, 0);
            this.panelGrades.Name = "panelGrades";
            this.panelGrades.Size = new System.Drawing.Size(853, 138);
            this.panelGrades.TabIndex = 2;
            // 
            // panelHeaderBottomBorder
            // 
            this.panelHeaderBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelHeaderBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBottomBorder.Location = new System.Drawing.Point(0, 136);
            this.panelHeaderBottomBorder.Name = "panelHeaderBottomBorder";
            this.panelHeaderBottomBorder.Size = new System.Drawing.Size(853, 2);
            this.panelHeaderBottomBorder.TabIndex = 2;
            // 
            // panelHeaderTopBorder
            // 
            this.panelHeaderTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelHeaderTopBorder.Location = new System.Drawing.Point(-12, 61);
            this.panelHeaderTopBorder.Name = "panelHeaderTopBorder";
            this.panelHeaderTopBorder.Size = new System.Drawing.Size(866, 2);
            this.panelHeaderTopBorder.TabIndex = 1;
            // 
            // listboxCourseSelection
            // 
            this.listboxCourseSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxCourseSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.listboxCourseSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxCourseSelection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCourseSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.listboxCourseSelection.FormattingEnabled = true;
            this.listboxCourseSelection.HorizontalScrollbar = true;
            this.listboxCourseSelection.ItemHeight = 21;
            this.listboxCourseSelection.Items.AddRange(new object[] {
            "ENGG 1100",
            "ENGG 2100",
            "ENGG 3100",
            "ENGG 4100",
            "ENGG 5100"});
            this.listboxCourseSelection.Location = new System.Drawing.Point(6, 77);
            this.listboxCourseSelection.MultiColumn = true;
            this.listboxCourseSelection.Name = "listboxCourseSelection";
            this.listboxCourseSelection.Size = new System.Drawing.Size(848, 42);
            this.listboxCourseSelection.TabIndex = 0;
            // 
            // panelCurrentSelection
            // 
            this.panelCurrentSelection.Controls.Add(this.btnAddNewCourse);
            this.panelCurrentSelection.Controls.Add(this.lblCurrentSelection);
            this.panelCurrentSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentSelection.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentSelection.Name = "panelCurrentSelection";
            this.panelCurrentSelection.Size = new System.Drawing.Size(853, 60);
            this.panelCurrentSelection.TabIndex = 0;
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddNewCourse.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddNewCourse.IconColor = System.Drawing.Color.Black;
            this.btnAddNewCourse.IconSize = 16;
            this.btnAddNewCourse.Location = new System.Drawing.Point(683, 11);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Rotation = 0D;
            this.btnAddNewCourse.Size = new System.Drawing.Size(164, 40);
            this.btnAddNewCourse.TabIndex = 2;
            this.btnAddNewCourse.Text = "Add New Course";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            // 
            // lblCurrentSelection
            // 
            this.lblCurrentSelection.AutoSize = true;
            this.lblCurrentSelection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentSelection.Location = new System.Drawing.Point(2, 19);
            this.lblCurrentSelection.Name = "lblCurrentSelection";
            this.lblCurrentSelection.Size = new System.Drawing.Size(143, 28);
            this.lblCurrentSelection.TabIndex = 0;
            this.lblCurrentSelection.Text = "Winter 2019";
            // 
            // panelSemester
            // 
            this.panelSemester.Controls.Add(this.listboxSemester);
            this.panelSemester.Controls.Add(this.panelSemesterLabel);
            this.panelSemester.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSemester.Location = new System.Drawing.Point(0, 0);
            this.panelSemester.Name = "panelSemester";
            this.panelSemester.Size = new System.Drawing.Size(160, 889);
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
            this.listboxSemester.Size = new System.Drawing.Size(157, 829);
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
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSemester.Location = new System.Drawing.Point(21, 17);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(122, 30);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Semester";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelProjectionsLeftBorder);
            this.panelHeader.Controls.Add(this.panelProjections);
            this.panelHeader.Controls.Add(this.panelGrades);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(162, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1011, 138);
            this.panelHeader.TabIndex = 4;
            // 
            // panelProjectionsLeftBorder
            // 
            this.panelProjectionsLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelProjectionsLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProjectionsLeftBorder.Location = new System.Drawing.Point(853, 0);
            this.panelProjectionsLeftBorder.Name = "panelProjectionsLeftBorder";
            this.panelProjectionsLeftBorder.Size = new System.Drawing.Size(2, 138);
            this.panelProjectionsLeftBorder.TabIndex = 5;
            // 
            // panelProjections
            // 
            this.panelProjections.Controls.Add(this.lblProjectionTitle);
            this.panelProjections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjections.Location = new System.Drawing.Point(853, 0);
            this.panelProjections.Name = "panelProjections";
            this.panelProjections.Size = new System.Drawing.Size(158, 138);
            this.panelProjections.TabIndex = 3;
            // 
            // lblProjectionTitle
            // 
            this.lblProjectionTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProjectionTitle.AutoSize = true;
            this.lblProjectionTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectionTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProjectionTitle.Location = new System.Drawing.Point(22, 63);
            this.lblProjectionTitle.Name = "lblProjectionTitle";
            this.lblProjectionTitle.Size = new System.Drawing.Size(113, 23);
            this.lblProjectionTitle.TabIndex = 0;
            this.lblProjectionTitle.Text = "Projections";
            // 
            // panelGradeTableContainer
            // 
            this.panelGradeTableContainer.Controls.Add(this.panelBottomButton);
            this.panelGradeTableContainer.Controls.Add(this.panel2);
            this.panelGradeTableContainer.Controls.Add(this.panelFinalMarkContainer);
            this.panelGradeTableContainer.Controls.Add(this.panel1);
            this.panelGradeTableContainer.Controls.Add(this.panelGradeTable);
            this.panelGradeTableContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGradeTableContainer.Location = new System.Drawing.Point(0, 0);
            this.panelGradeTableContainer.Name = "panelGradeTableContainer";
            this.panelGradeTableContainer.Size = new System.Drawing.Size(853, 751);
            this.panelGradeTableContainer.TabIndex = 0;
            // 
            // panelFinalMarkContainer
            // 
            this.panelFinalMarkContainer.Controls.Add(this.lblFinalExamWorth);
            this.panelFinalMarkContainer.Controls.Add(this.lblCurrentMarkYourMark);
            this.panelFinalMarkContainer.Controls.Add(this.lblCurrentMarkWorth);
            this.panelFinalMarkContainer.Controls.Add(this.lblFinalMark);
            this.panelFinalMarkContainer.Controls.Add(this.lblCurrentMark);
            this.panelFinalMarkContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinalMarkContainer.Location = new System.Drawing.Point(0, 414);
            this.panelFinalMarkContainer.Name = "panelFinalMarkContainer";
            this.panelFinalMarkContainer.Size = new System.Drawing.Size(853, 137);
            this.panelFinalMarkContainer.TabIndex = 1;
            // 
            // lblFinalExamWorth
            // 
            this.lblFinalExamWorth.AutoSize = true;
            this.lblFinalExamWorth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalExamWorth.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFinalExamWorth.Location = new System.Drawing.Point(313, 77);
            this.lblFinalExamWorth.Name = "lblFinalExamWorth";
            this.lblFinalExamWorth.Size = new System.Drawing.Size(48, 23);
            this.lblFinalExamWorth.TabIndex = 5;
            this.lblFinalExamWorth.Text = "50%";
            // 
            // lblCurrentMarkYourMark
            // 
            this.lblCurrentMarkYourMark.AutoSize = true;
            this.lblCurrentMarkYourMark.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMarkYourMark.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentMarkYourMark.Location = new System.Drawing.Point(494, 34);
            this.lblCurrentMarkYourMark.Name = "lblCurrentMarkYourMark";
            this.lblCurrentMarkYourMark.Size = new System.Drawing.Size(48, 23);
            this.lblCurrentMarkYourMark.TabIndex = 4;
            this.lblCurrentMarkYourMark.Text = "50%";
            // 
            // lblCurrentMarkWorth
            // 
            this.lblCurrentMarkWorth.AutoSize = true;
            this.lblCurrentMarkWorth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMarkWorth.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentMarkWorth.Location = new System.Drawing.Point(313, 34);
            this.lblCurrentMarkWorth.Name = "lblCurrentMarkWorth";
            this.lblCurrentMarkWorth.Size = new System.Drawing.Size(48, 23);
            this.lblCurrentMarkWorth.TabIndex = 3;
            this.lblCurrentMarkWorth.Text = "50%";
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMark.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFinalMark.Location = new System.Drawing.Point(75, 77);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(175, 23);
            this.lblFinalMark.TabIndex = 2;
            this.lblFinalMark.Text = "Final Exam Worth";
            // 
            // lblCurrentMark
            // 
            this.lblCurrentMark.AutoSize = true;
            this.lblCurrentMark.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMark.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentMark.Location = new System.Drawing.Point(75, 34);
            this.lblCurrentMark.Name = "lblCurrentMark";
            this.lblCurrentMark.Size = new System.Drawing.Size(136, 23);
            this.lblCurrentMark.TabIndex = 1;
            this.lblCurrentMark.Text = "Current Mark";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 2);
            this.panel1.TabIndex = 2;
            // 
            // panelGradeTable
            // 
            this.panelGradeTable.Controls.Add(this.dataGridViewGrades);
            this.panelGradeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGradeTable.Location = new System.Drawing.Point(0, 0);
            this.panelGradeTable.Name = "panelGradeTable";
            this.panelGradeTable.Size = new System.Drawing.Size(853, 412);
            this.panelGradeTable.TabIndex = 0;
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.AllowUserToDeleteRows = false;
            this.dataGridViewGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.dataGridViewGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGrades.ColumnHeadersHeight = 44;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Worth,
            this.YourMark,
            this.CourseMark});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGrades.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGrades.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewGrades.Location = new System.Drawing.Point(79, 24);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersVisible = false;
            this.dataGridViewGrades.RowHeadersWidth = 62;
            this.dataGridViewGrades.RowTemplate.Height = 28;
            this.dataGridViewGrades.Size = new System.Drawing.Size(706, 361);
            this.dataGridViewGrades.TabIndex = 0;
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 8;
            this.Task.Name = "Task";
            // 
            // Worth
            // 
            this.Worth.HeaderText = "Worth";
            this.Worth.MinimumWidth = 8;
            this.Worth.Name = "Worth";
            // 
            // YourMark
            // 
            this.YourMark.HeaderText = "Your Mark";
            this.YourMark.MinimumWidth = 8;
            this.YourMark.Name = "YourMark";
            // 
            // CourseMark
            // 
            this.CourseMark.HeaderText = "Course Mark";
            this.CourseMark.MinimumWidth = 8;
            this.CourseMark.Name = "CourseMark";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panelGradeTableRightBorder);
            this.panelFooter.Controls.Add(this.panelGradeTableContainer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(162, 138);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1011, 751);
            this.panelFooter.TabIndex = 5;
            // 
            // panelGradeTableRightBorder
            // 
            this.panelGradeTableRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panelGradeTableRightBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGradeTableRightBorder.Location = new System.Drawing.Point(853, 0);
            this.panelGradeTableRightBorder.Name = "panelGradeTableRightBorder";
            this.panelGradeTableRightBorder.Size = new System.Drawing.Size(2, 751);
            this.panelGradeTableRightBorder.TabIndex = 1;
            // 
            // panelBottomButton
            // 
            this.panelBottomButton.Controls.Add(this.iconButtonDeleteCourse);
            this.panelBottomButton.Controls.Add(this.iconButtonClearTable);
            this.panelBottomButton.Controls.Add(this.iconButtonResetTable);
            this.panelBottomButton.Controls.Add(this.iconButtonSaveTable);
            this.panelBottomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomButton.Location = new System.Drawing.Point(0, 553);
            this.panelBottomButton.Name = "panelBottomButton";
            this.panelBottomButton.Size = new System.Drawing.Size(853, 153);
            this.panelBottomButton.TabIndex = 3;
            // 
            // iconButtonSaveTable
            // 
            this.iconButtonSaveTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSaveTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSaveTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSaveTable.IconColor = System.Drawing.Color.Black;
            this.iconButtonSaveTable.IconSize = 16;
            this.iconButtonSaveTable.Location = new System.Drawing.Point(32, 76);
            this.iconButtonSaveTable.Name = "iconButtonSaveTable";
            this.iconButtonSaveTable.Rotation = 0D;
            this.iconButtonSaveTable.Size = new System.Drawing.Size(132, 41);
            this.iconButtonSaveTable.TabIndex = 0;
            this.iconButtonSaveTable.Text = "Save Table";
            this.iconButtonSaveTable.UseVisualStyleBackColor = true;
            // 
            // iconButtonResetTable
            // 
            this.iconButtonResetTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonResetTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonResetTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonResetTable.IconColor = System.Drawing.Color.Black;
            this.iconButtonResetTable.IconSize = 16;
            this.iconButtonResetTable.Location = new System.Drawing.Point(244, 76);
            this.iconButtonResetTable.Name = "iconButtonResetTable";
            this.iconButtonResetTable.Rotation = 0D;
            this.iconButtonResetTable.Size = new System.Drawing.Size(132, 41);
            this.iconButtonResetTable.TabIndex = 1;
            this.iconButtonResetTable.Text = "Reset Table";
            this.iconButtonResetTable.UseVisualStyleBackColor = true;
            // 
            // iconButtonClearTable
            // 
            this.iconButtonClearTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonClearTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClearTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonClearTable.IconColor = System.Drawing.Color.Black;
            this.iconButtonClearTable.IconSize = 16;
            this.iconButtonClearTable.Location = new System.Drawing.Point(458, 76);
            this.iconButtonClearTable.Name = "iconButtonClearTable";
            this.iconButtonClearTable.Rotation = 0D;
            this.iconButtonClearTable.Size = new System.Drawing.Size(132, 41);
            this.iconButtonClearTable.TabIndex = 2;
            this.iconButtonClearTable.Text = "Clear Table";
            this.iconButtonClearTable.UseVisualStyleBackColor = true;
            // 
            // iconButtonDeleteCourse
            // 
            this.iconButtonDeleteCourse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDeleteCourse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDeleteCourse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDeleteCourse.IconColor = System.Drawing.Color.Black;
            this.iconButtonDeleteCourse.IconSize = 16;
            this.iconButtonDeleteCourse.Location = new System.Drawing.Point(670, 76);
            this.iconButtonDeleteCourse.Name = "iconButtonDeleteCourse";
            this.iconButtonDeleteCourse.Rotation = 0D;
            this.iconButtonDeleteCourse.Size = new System.Drawing.Size(147, 41);
            this.iconButtonDeleteCourse.TabIndex = 3;
            this.iconButtonDeleteCourse.Text = "Delete Course";
            this.iconButtonDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 2);
            this.panel2.TabIndex = 4;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1173, 889);
            this.Controls.Add(this.panelFooter);
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
            this.panelGradeTableContainer.ResumeLayout(false);
            this.panelFinalMarkContainer.ResumeLayout(false);
            this.panelFinalMarkContainer.PerformLayout();
            this.panelGradeTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelBottomButton.ResumeLayout(false);
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
        private ListBox listboxCourseSelection;
        private FontAwesome.Sharp.IconButton btnAddNewCourse;
        private Panel panelHeader;
        private Panel panelProjections;
        private Label lblProjectionTitle;
        private Panel panelGradeTableContainer;
        private Panel panelFooter;
        private Panel panelGradeTableRightBorder;
        private Panel panelHeaderTopBorder;
        private Panel panelProjectionsLeftBorder;
        private Panel panelHeaderBottomBorder;
        private Panel panelGradeTable;
        private DataGridView dataGridViewGrades;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn Worth;
        private DataGridViewTextBoxColumn YourMark;
        private DataGridViewTextBoxColumn CourseMark;
        private Panel panelFinalMarkContainer;
        private Label lblCurrentMark;
        private Label lblFinalMark;
        private Label lblCurrentMarkWorth;
        private Label lblCurrentMarkYourMark;
        private Label lblFinalExamWorth;
        private Panel panel1;
        private Panel panelBottomButton;
        private FontAwesome.Sharp.IconButton iconButtonDeleteCourse;
        private FontAwesome.Sharp.IconButton iconButtonClearTable;
        private FontAwesome.Sharp.IconButton iconButtonResetTable;
        private FontAwesome.Sharp.IconButton iconButtonSaveTable;
        private Panel panel2;
    }


}
