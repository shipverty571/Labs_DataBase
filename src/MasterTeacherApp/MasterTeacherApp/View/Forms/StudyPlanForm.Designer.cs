namespace MasterTeacherApp.View.Forms
{
    partial class StudyPlanForm
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
            System.Windows.Forms.Label iD_StudyPlanLabel;
            System.Windows.Forms.Label countLessonHoursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyPlanForm));
            this.workHeadTeacherDataSet = new MasterTeacherApp.Database.WorkHeadTeacherDataSet();
            this.studyPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyPlansTableAdapter = new MasterTeacherApp.Database.WorkHeadTeacherDataSetTableAdapters.StudyPlansTableAdapter();
            this.tableAdapterManager = new MasterTeacherApp.Database.WorkHeadTeacherDataSetTableAdapters.TableAdapterManager();
            this.studyPlansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iD_StudyPlanTextBox = new System.Windows.Forms.TextBox();
            this.countLessonHoursTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.studyPlansBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_StudyPlanLabel = new System.Windows.Forms.Label();
            countLessonHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingNavigator)).BeginInit();
            this.studyPlansBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_StudyPlanLabel
            // 
            iD_StudyPlanLabel.AutoSize = true;
            iD_StudyPlanLabel.Location = new System.Drawing.Point(12, 34);
            iD_StudyPlanLabel.Name = "iD_StudyPlanLabel";
            iD_StudyPlanLabel.Size = new System.Drawing.Size(75, 13);
            iD_StudyPlanLabel.TabIndex = 1;
            iD_StudyPlanLabel.Text = "ID Study Plan:";
            // 
            // countLessonHoursLabel
            // 
            countLessonHoursLabel.AutoSize = true;
            countLessonHoursLabel.Location = new System.Drawing.Point(12, 60);
            countLessonHoursLabel.Name = "countLessonHoursLabel";
            countLessonHoursLabel.Size = new System.Drawing.Size(106, 13);
            countLessonHoursLabel.TabIndex = 3;
            countLessonHoursLabel.Text = "Count Lesson Hours:";
            // 
            // workHeadTeacherDataSet
            // 
            this.workHeadTeacherDataSet.DataSetName = "WorkHeadTeacherDataSet";
            this.workHeadTeacherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studyPlansBindingSource
            // 
            this.studyPlansBindingSource.DataMember = "StudyPlans";
            this.studyPlansBindingSource.DataSource = this.workHeadTeacherDataSet;
            // 
            // studyPlansTableAdapter
            // 
            this.studyPlansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DisciplinesTableAdapter = null;
            this.tableAdapterManager.MarksTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.StudyPlansTableAdapter = this.studyPlansTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.TimetablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterTeacherApp.Database.WorkHeadTeacherDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studyPlansBindingNavigator
            // 
            this.studyPlansBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studyPlansBindingNavigator.BindingSource = this.studyPlansBindingSource;
            this.studyPlansBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studyPlansBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studyPlansBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studyPlansBindingNavigatorSaveItem});
            this.studyPlansBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studyPlansBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studyPlansBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studyPlansBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studyPlansBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studyPlansBindingNavigator.Name = "studyPlansBindingNavigator";
            this.studyPlansBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studyPlansBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.studyPlansBindingNavigator.TabIndex = 0;
            this.studyPlansBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iD_StudyPlanTextBox
            // 
            this.iD_StudyPlanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_StudyPlanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyPlansBindingSource, "ID_StudyPlan", true));
            this.iD_StudyPlanTextBox.Location = new System.Drawing.Point(124, 31);
            this.iD_StudyPlanTextBox.Name = "iD_StudyPlanTextBox";
            this.iD_StudyPlanTextBox.Size = new System.Drawing.Size(198, 20);
            this.iD_StudyPlanTextBox.TabIndex = 2;
            // 
            // countLessonHoursTextBox
            // 
            this.countLessonHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countLessonHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyPlansBindingSource, "CountLessonHours", true));
            this.countLessonHoursTextBox.Location = new System.Drawing.Point(124, 57);
            this.countLessonHoursTextBox.Name = "countLessonHoursTextBox";
            this.countLessonHoursTextBox.Size = new System.Drawing.Size(198, 20);
            this.countLessonHoursTextBox.TabIndex = 4;
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
            // studyPlansBindingNavigatorSaveItem
            // 
            this.studyPlansBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studyPlansBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studyPlansBindingNavigatorSaveItem.Image")));
            this.studyPlansBindingNavigatorSaveItem.Name = "studyPlansBindingNavigatorSaveItem";
            this.studyPlansBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studyPlansBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studyPlansBindingNavigatorSaveItem.Click += new System.EventHandler(this.studyPlansBindingNavigatorSaveItem_Click);
            // 
            // StudyPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(iD_StudyPlanLabel);
            this.Controls.Add(this.iD_StudyPlanTextBox);
            this.Controls.Add(countLessonHoursLabel);
            this.Controls.Add(this.countLessonHoursTextBox);
            this.Controls.Add(this.studyPlansBindingNavigator);
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "StudyPlanForm";
            this.Text = "Учебные планы";
            this.Load += new System.EventHandler(this.StudyPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingNavigator)).EndInit();
            this.studyPlansBindingNavigator.ResumeLayout(false);
            this.studyPlansBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.WorkHeadTeacherDataSet workHeadTeacherDataSet;
        private System.Windows.Forms.BindingSource studyPlansBindingSource;
        private Database.WorkHeadTeacherDataSetTableAdapters.StudyPlansTableAdapter studyPlansTableAdapter;
        private Database.WorkHeadTeacherDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studyPlansBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studyPlansBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_StudyPlanTextBox;
        private System.Windows.Forms.TextBox countLessonHoursTextBox;
    }
}