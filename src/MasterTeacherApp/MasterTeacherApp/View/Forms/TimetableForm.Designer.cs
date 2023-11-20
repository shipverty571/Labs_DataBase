namespace MasterTeacherApp.View.Forms
{
    partial class TimetableForm
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
            System.Windows.Forms.Label iD_TimetableLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label disciplineLabel;
            System.Windows.Forms.Label lessonNumberLabel;
            System.Windows.Forms.Label auditoriumLabel;
            System.Windows.Forms.Label dateLessonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableForm));
            this.workHeadTeacherDataSet = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFile();
            this.timetablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetablesTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TimetablesTableAdapter();
            this.tableAdapterManager = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager();
            this.timetablesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timetablesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TimetableTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.disciplineTextBox = new System.Windows.Forms.TextBox();
            this.lessonNumberTextBox = new System.Windows.Forms.TextBox();
            this.auditoriumTextBox = new System.Windows.Forms.TextBox();
            this.dateLessonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_TimetableLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            disciplineLabel = new System.Windows.Forms.Label();
            lessonNumberLabel = new System.Windows.Forms.Label();
            auditoriumLabel = new System.Windows.Forms.Label();
            dateLessonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingNavigator)).BeginInit();
            this.timetablesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TimetableLabel
            // 
            iD_TimetableLabel.AutoSize = true;
            iD_TimetableLabel.Location = new System.Drawing.Point(12, 31);
            iD_TimetableLabel.Name = "iD_TimetableLabel";
            iD_TimetableLabel.Size = new System.Drawing.Size(70, 13);
            iD_TimetableLabel.TabIndex = 1;
            iD_TimetableLabel.Text = "ID Timetable:";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(12, 57);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(35, 13);
            classLabel.TabIndex = 3;
            classLabel.Text = "Class:";
            // 
            // disciplineLabel
            // 
            disciplineLabel.AutoSize = true;
            disciplineLabel.Location = new System.Drawing.Point(12, 83);
            disciplineLabel.Name = "disciplineLabel";
            disciplineLabel.Size = new System.Drawing.Size(55, 13);
            disciplineLabel.TabIndex = 5;
            disciplineLabel.Text = "Discipline:";
            // 
            // lessonNumberLabel
            // 
            lessonNumberLabel.AutoSize = true;
            lessonNumberLabel.Location = new System.Drawing.Point(12, 109);
            lessonNumberLabel.Name = "lessonNumberLabel";
            lessonNumberLabel.Size = new System.Drawing.Size(84, 13);
            lessonNumberLabel.TabIndex = 7;
            lessonNumberLabel.Text = "Lesson Number:";
            // 
            // auditoriumLabel
            // 
            auditoriumLabel.AutoSize = true;
            auditoriumLabel.Location = new System.Drawing.Point(12, 135);
            auditoriumLabel.Name = "auditoriumLabel";
            auditoriumLabel.Size = new System.Drawing.Size(59, 13);
            auditoriumLabel.TabIndex = 9;
            auditoriumLabel.Text = "Auditorium:";
            // 
            // dateLessonLabel
            // 
            dateLessonLabel.AutoSize = true;
            dateLessonLabel.Location = new System.Drawing.Point(12, 162);
            dateLessonLabel.Name = "dateLessonLabel";
            dateLessonLabel.Size = new System.Drawing.Size(70, 13);
            dateLessonLabel.TabIndex = 11;
            dateLessonLabel.Text = "Date Lesson:";
            // 
            // workHeadTeacherDataSet
            // 
            this.workHeadTeacherDataSet.DataSetName = "WorkHeadTeacherDataSet";
            this.workHeadTeacherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetablesBindingSource
            // 
            this.timetablesBindingSource.DataMember = "Timetables";
            this.timetablesBindingSource.DataSource = this.workHeadTeacherDataSet;
            // 
            // timetablesTableAdapter
            // 
            this.timetablesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DisciplinesTableAdapter = null;
            this.tableAdapterManager.MarksTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.StudyPlansTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.TimetablesTableAdapter = this.timetablesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timetablesBindingNavigator
            // 
            this.timetablesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.timetablesBindingNavigator.BindingSource = this.timetablesBindingSource;
            this.timetablesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.timetablesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.timetablesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.timetablesBindingNavigatorSaveItem});
            this.timetablesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.timetablesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.timetablesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.timetablesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.timetablesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.timetablesBindingNavigator.Name = "timetablesBindingNavigator";
            this.timetablesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.timetablesBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.timetablesBindingNavigator.TabIndex = 0;
            this.timetablesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // timetablesBindingNavigatorSaveItem
            // 
            this.timetablesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.timetablesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("timetablesBindingNavigatorSaveItem.Image")));
            this.timetablesBindingNavigatorSaveItem.Name = "timetablesBindingNavigatorSaveItem";
            this.timetablesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.timetablesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.timetablesBindingNavigatorSaveItem.Click += new System.EventHandler(this.timetablesBindingNavigatorSaveItem_Click);
            // 
            // iD_TimetableTextBox
            // 
            this.iD_TimetableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_TimetableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetablesBindingSource, "ID_Timetable", true));
            this.iD_TimetableTextBox.Location = new System.Drawing.Point(102, 28);
            this.iD_TimetableTextBox.Name = "iD_TimetableTextBox";
            this.iD_TimetableTextBox.Size = new System.Drawing.Size(220, 20);
            this.iD_TimetableTextBox.TabIndex = 2;
            // 
            // classTextBox
            // 
            this.classTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetablesBindingSource, "Class", true));
            this.classTextBox.Location = new System.Drawing.Point(102, 54);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(220, 20);
            this.classTextBox.TabIndex = 4;
            // 
            // disciplineTextBox
            // 
            this.disciplineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetablesBindingSource, "Discipline", true));
            this.disciplineTextBox.Location = new System.Drawing.Point(102, 80);
            this.disciplineTextBox.Name = "disciplineTextBox";
            this.disciplineTextBox.Size = new System.Drawing.Size(220, 20);
            this.disciplineTextBox.TabIndex = 6;
            // 
            // lessonNumberTextBox
            // 
            this.lessonNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetablesBindingSource, "LessonNumber", true));
            this.lessonNumberTextBox.Location = new System.Drawing.Point(102, 106);
            this.lessonNumberTextBox.Name = "lessonNumberTextBox";
            this.lessonNumberTextBox.Size = new System.Drawing.Size(220, 20);
            this.lessonNumberTextBox.TabIndex = 8;
            // 
            // auditoriumTextBox
            // 
            this.auditoriumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auditoriumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetablesBindingSource, "Auditorium", true));
            this.auditoriumTextBox.Location = new System.Drawing.Point(102, 132);
            this.auditoriumTextBox.Name = "auditoriumTextBox";
            this.auditoriumTextBox.Size = new System.Drawing.Size(220, 20);
            this.auditoriumTextBox.TabIndex = 10;
            // 
            // dateLessonDateTimePicker
            // 
            this.dateLessonDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLessonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.timetablesBindingSource, "DateLesson", true));
            this.dateLessonDateTimePicker.Location = new System.Drawing.Point(102, 158);
            this.dateLessonDateTimePicker.Name = "dateLessonDateTimePicker";
            this.dateLessonDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.dateLessonDateTimePicker.TabIndex = 12;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(iD_TimetableLabel);
            this.Controls.Add(this.iD_TimetableTextBox);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(disciplineLabel);
            this.Controls.Add(this.disciplineTextBox);
            this.Controls.Add(lessonNumberLabel);
            this.Controls.Add(this.lessonNumberTextBox);
            this.Controls.Add(auditoriumLabel);
            this.Controls.Add(this.auditoriumTextBox);
            this.Controls.Add(dateLessonLabel);
            this.Controls.Add(this.dateLessonDateTimePicker);
            this.Controls.Add(this.timetablesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 230);
            this.Name = "TimetableForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesBindingNavigator)).EndInit();
            this.timetablesBindingNavigator.ResumeLayout(false);
            this.timetablesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.Work_Head_TeacherDataSetFile workHeadTeacherDataSet;
        private System.Windows.Forms.BindingSource timetablesBindingSource;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.TimetablesTableAdapter timetablesTableAdapter;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator timetablesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton timetablesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TimetableTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox disciplineTextBox;
        private System.Windows.Forms.TextBox lessonNumberTextBox;
        private System.Windows.Forms.TextBox auditoriumTextBox;
        private System.Windows.Forms.DateTimePicker dateLessonDateTimePicker;
    }
}