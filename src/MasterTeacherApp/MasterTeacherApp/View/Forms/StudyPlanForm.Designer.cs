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
            this.workHeadTeacherDataSet = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFile();
            this.studyPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyPlansTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.StudyPlansTableAdapter();
            this.tableAdapterManager = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager();
            this.studyPlansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studyPlansBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripFindTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.iD_StudyPlanTextBox = new System.Windows.Forms.TextBox();
            this.countLessonHoursTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classesTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.ClassesTableAdapter();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinesTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.DisciplinesTableAdapter();
            this.disciplinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_StudyPlanLabel = new System.Windows.Forms.Label();
            countLessonHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingNavigator)).BeginInit();
            this.studyPlansBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_StudyPlanLabel
            // 
            iD_StudyPlanLabel.AutoSize = true;
            iD_StudyPlanLabel.Location = new System.Drawing.Point(6, 26);
            iD_StudyPlanLabel.Name = "iD_StudyPlanLabel";
            iD_StudyPlanLabel.Size = new System.Drawing.Size(75, 13);
            iD_StudyPlanLabel.TabIndex = 1;
            iD_StudyPlanLabel.Text = "ID Study Plan:";
            // 
            // countLessonHoursLabel
            // 
            countLessonHoursLabel.AutoSize = true;
            countLessonHoursLabel.Location = new System.Drawing.Point(6, 52);
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
            this.tableAdapterManager.UpdateOrder = MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.studyPlansBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripFindTextBox,
            this.toolStripButton2});
            this.studyPlansBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studyPlansBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studyPlansBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studyPlansBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studyPlansBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studyPlansBindingNavigator.Name = "studyPlansBindingNavigator";
            this.studyPlansBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studyPlansBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.studyPlansBindingNavigator.TabIndex = 0;
            this.studyPlansBindingNavigator.Text = "bindingNavigator1";
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
            // studyPlansBindingNavigatorSaveItem
            // 
            this.studyPlansBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studyPlansBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studyPlansBindingNavigatorSaveItem.Image")));
            this.studyPlansBindingNavigatorSaveItem.Name = "studyPlansBindingNavigatorSaveItem";
            this.studyPlansBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studyPlansBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studyPlansBindingNavigatorSaveItem.Click += new System.EventHandler(this.studyPlansBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Поиск:";
            // 
            // toolStripFindTextBox
            // 
            this.toolStripFindTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripFindTextBox.Name = "toolStripFindTextBox";
            this.toolStripFindTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MasterTeacherApp.Properties.Resources.search_16x16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // iD_StudyPlanTextBox
            // 
            this.iD_StudyPlanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_StudyPlanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyPlansBindingSource, "ID_StudyPlan", true));
            this.iD_StudyPlanTextBox.Location = new System.Drawing.Point(118, 23);
            this.iD_StudyPlanTextBox.Name = "iD_StudyPlanTextBox";
            this.iD_StudyPlanTextBox.Size = new System.Drawing.Size(536, 20);
            this.iD_StudyPlanTextBox.TabIndex = 2;
            // 
            // countLessonHoursTextBox
            // 
            this.countLessonHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countLessonHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyPlansBindingSource, "CountLessonHours", true));
            this.countLessonHoursTextBox.Location = new System.Drawing.Point(118, 49);
            this.countLessonHoursTextBox.Name = "countLessonHoursTextBox";
            this.countLessonHoursTextBox.Size = new System.Drawing.Size(536, 20);
            this.countLessonHoursTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(iD_StudyPlanLabel);
            this.groupBox1.Controls.Add(this.countLessonHoursTextBox);
            this.groupBox1.Controls.Add(countLessonHoursLabel);
            this.groupBox1.Controls.Add(this.iD_StudyPlanTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Учебные планы";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.disciplinesDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 330);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дисциплины";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataMember = "FK_Disciplines_StudyPlans";
            this.disciplinesBindingSource.DataSource = this.studyPlansBindingSource;
            // 
            // disciplinesTableAdapter
            // 
            this.disciplinesTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinesDataGridView
            // 
            this.disciplinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplinesDataGridView.AutoGenerateColumns = false;
            this.disciplinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.disciplinesDataGridView.DataSource = this.disciplinesBindingSource;
            this.disciplinesDataGridView.Location = new System.Drawing.Point(9, 19);
            this.disciplinesDataGridView.Name = "disciplinesDataGridView";
            this.disciplinesDataGridView.Size = new System.Drawing.Size(645, 305);
            this.disciplinesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Discipline";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Discipline";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClassNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "ClassNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StudyPlan";
            this.dataGridViewTextBoxColumn5.HeaderText = "StudyPlan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // StudyPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studyPlansBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "StudyPlanForm";
            this.Text = "Учебные планы";
            this.Load += new System.EventHandler(this.StudyPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyPlansBindingNavigator)).EndInit();
            this.studyPlansBindingNavigator.ResumeLayout(false);
            this.studyPlansBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.Work_Head_TeacherDataSetFile workHeadTeacherDataSet;
        private System.Windows.Forms.BindingSource studyPlansBindingSource;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.StudyPlansTableAdapter studyPlansTableAdapter;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripFindTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.DisciplinesTableAdapter disciplinesTableAdapter;
        private System.Windows.Forms.DataGridView disciplinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}