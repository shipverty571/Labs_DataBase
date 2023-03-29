namespace MasterTeacherApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TeacherMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.TeacherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StudyPlanToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DisciplineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClassToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MarkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TimetableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StudentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TeacherMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherMenuStrip
            // 
            this.TeacherMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.TeacherMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TeacherMenuStrip.Name = "TeacherMenuStrip";
            this.TeacherMenuStrip.Size = new System.Drawing.Size(584, 24);
            this.TeacherMenuStrip.TabIndex = 0;
            this.TeacherMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.toolStripSeparator1,
            this.AboutToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::MasterTeacherApp.Properties.Resources.logout_16x16;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::MasterTeacherApp.Properties.Resources.about_16x16;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.AboutToolStripMenuItem.Text = "О программе...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeacherToolStripButton,
            this.StudyPlanToolStripButton,
            this.DisciplineToolStripButton,
            this.ClassToolStripButton,
            this.MarkToolStripButton,
            this.TimetableToolStripButton,
            this.StudentToolStripButton,
            this.toolStripSeparator2,
            this.ExitToolStripButton,
            this.AboutToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(584, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // TeacherToolStripButton
            // 
            this.TeacherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TeacherToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.teacher_16x16;
            this.TeacherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TeacherToolStripButton.Name = "TeacherToolStripButton";
            this.TeacherToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.TeacherToolStripButton.Text = "Преподаватели";
            this.TeacherToolStripButton.Click += new System.EventHandler(this.TeacherToolStripButton_Click);
            // 
            // StudyPlanToolStripButton
            // 
            this.StudyPlanToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StudyPlanToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.studyPlan_16x16;
            this.StudyPlanToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StudyPlanToolStripButton.Name = "StudyPlanToolStripButton";
            this.StudyPlanToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StudyPlanToolStripButton.Text = "Учебные планы";
            this.StudyPlanToolStripButton.Click += new System.EventHandler(this.StudyPlanToolStripButton_Click);
            // 
            // DisciplineToolStripButton
            // 
            this.DisciplineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DisciplineToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.discipline_16x16;
            this.DisciplineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisciplineToolStripButton.Name = "DisciplineToolStripButton";
            this.DisciplineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DisciplineToolStripButton.Text = "Дисциплины";
            this.DisciplineToolStripButton.Click += new System.EventHandler(this.DisciplineToolStripButton_Click);
            // 
            // ClassToolStripButton
            // 
            this.ClassToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClassToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.classroom_16x16;
            this.ClassToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClassToolStripButton.Name = "ClassToolStripButton";
            this.ClassToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ClassToolStripButton.Text = "Классы";
            this.ClassToolStripButton.Click += new System.EventHandler(this.ClassToolStripButton_Click);
            // 
            // MarkToolStripButton
            // 
            this.MarkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MarkToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.mark_16x16;
            this.MarkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MarkToolStripButton.Name = "MarkToolStripButton";
            this.MarkToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.MarkToolStripButton.Text = "Оценки";
            this.MarkToolStripButton.Click += new System.EventHandler(this.MarkToolStripButton_Click);
            // 
            // TimetableToolStripButton
            // 
            this.TimetableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TimetableToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.timetable_16x16;
            this.TimetableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TimetableToolStripButton.Name = "TimetableToolStripButton";
            this.TimetableToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.TimetableToolStripButton.Text = "Расписание";
            this.TimetableToolStripButton.Click += new System.EventHandler(this.TimetableToolStripButton_Click);
            // 
            // StudentToolStripButton
            // 
            this.StudentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StudentToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.student_16x16;
            this.StudentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StudentToolStripButton.Name = "StudentToolStripButton";
            this.StudentToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StudentToolStripButton.Text = "Ученики";
            this.StudentToolStripButton.Click += new System.EventHandler(this.StudentToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.logout_16x16;
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExitToolStripButton.Text = "toolStripButton1";
            this.ExitToolStripButton.ToolTipText = "Закрыть программу";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolStripButton.Image = global::MasterTeacherApp.Properties.Resources.about_16x16;
            this.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AboutToolStripButton.Text = "toolStripButton1";
            this.AboutToolStripButton.ToolTipText = "О программе";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.TeacherMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TeacherMenuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "MasterTeacherApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TeacherMenuStrip.ResumeLayout(false);
            this.TeacherMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip TeacherMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripButton TeacherToolStripButton;
        private System.Windows.Forms.ToolStripButton StudyPlanToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DisciplineToolStripButton;
        private System.Windows.Forms.ToolStripButton ClassToolStripButton;
        private System.Windows.Forms.ToolStripButton MarkToolStripButton;
        private System.Windows.Forms.ToolStripButton TimetableToolStripButton;
        private System.Windows.Forms.ToolStripButton StudentToolStripButton;
    }
}

