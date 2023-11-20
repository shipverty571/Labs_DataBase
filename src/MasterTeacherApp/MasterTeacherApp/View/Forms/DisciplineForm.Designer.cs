namespace MasterTeacherApp.View.Forms
{
    partial class DisciplineForm
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
            System.Windows.Forms.Label iD_DisciplineLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label teacherLabel;
            System.Windows.Forms.Label classNumberLabel;
            System.Windows.Forms.Label studyPlanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplineForm));
            this.workHeadTeacherDataSet = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFile();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinesTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.DisciplinesTableAdapter();
            this.tableAdapterManager = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager();
            this.marksTableAdapter = new MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.MarksTableAdapter();
            this.disciplinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.disciplinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripFindTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripFilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.iD_DisciplineTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.classNumberTextBox = new System.Windows.Forms.TextBox();
            this.studyPlanTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_DisciplineLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            teacherLabel = new System.Windows.Forms.Label();
            classNumberLabel = new System.Windows.Forms.Label();
            studyPlanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingNavigator)).BeginInit();
            this.disciplinesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_DisciplineLabel
            // 
            iD_DisciplineLabel.AutoSize = true;
            iD_DisciplineLabel.Location = new System.Drawing.Point(6, 27);
            iD_DisciplineLabel.Name = "iD_DisciplineLabel";
            iD_DisciplineLabel.Size = new System.Drawing.Size(69, 13);
            iD_DisciplineLabel.TabIndex = 1;
            iD_DisciplineLabel.Text = "ID Discipline:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 53);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Location = new System.Drawing.Point(6, 79);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new System.Drawing.Size(50, 13);
            teacherLabel.TabIndex = 5;
            teacherLabel.Text = "Teacher:";
            // 
            // classNumberLabel
            // 
            classNumberLabel.AutoSize = true;
            classNumberLabel.Location = new System.Drawing.Point(6, 105);
            classNumberLabel.Name = "classNumberLabel";
            classNumberLabel.Size = new System.Drawing.Size(75, 13);
            classNumberLabel.TabIndex = 7;
            classNumberLabel.Text = "Class Number:";
            // 
            // studyPlanLabel
            // 
            studyPlanLabel.AutoSize = true;
            studyPlanLabel.Location = new System.Drawing.Point(6, 131);
            studyPlanLabel.Name = "studyPlanLabel";
            studyPlanLabel.Size = new System.Drawing.Size(61, 13);
            studyPlanLabel.TabIndex = 9;
            studyPlanLabel.Text = "Study Plan:";
            // 
            // workHeadTeacherDataSet
            // 
            this.workHeadTeacherDataSet.DataSetName = "WorkHeadTeacherDataSet";
            this.workHeadTeacherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataMember = "Disciplines";
            this.disciplinesBindingSource.DataSource = this.workHeadTeacherDataSet;
            // 
            // disciplinesTableAdapter
            // 
            this.disciplinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DisciplinesTableAdapter = this.disciplinesTableAdapter;
            this.tableAdapterManager.MarksTableAdapter = this.marksTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.StudyPlansTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.TimetablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterTeacherApp.Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinesBindingNavigator
            // 
            this.disciplinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disciplinesBindingNavigator.BindingSource = this.disciplinesBindingSource;
            this.disciplinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disciplinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disciplinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.disciplinesBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripFindTextBox,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripFilterComboBox});
            this.disciplinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disciplinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disciplinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disciplinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disciplinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disciplinesBindingNavigator.Name = "disciplinesBindingNavigator";
            this.disciplinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disciplinesBindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.disciplinesBindingNavigator.TabIndex = 0;
            this.disciplinesBindingNavigator.Text = "bindingNavigator1";
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
            // disciplinesBindingNavigatorSaveItem
            // 
            this.disciplinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disciplinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disciplinesBindingNavigatorSaveItem.Image")));
            this.disciplinesBindingNavigatorSaveItem.Name = "disciplinesBindingNavigatorSaveItem";
            this.disciplinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disciplinesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.disciplinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.disciplinesBindingNavigatorSaveItem_Click_1);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Фильтр:";
            // 
            // toolStripFilterComboBox
            // 
            this.toolStripFilterComboBox.Name = "toolStripFilterComboBox";
            this.toolStripFilterComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // iD_DisciplineTextBox
            // 
            this.iD_DisciplineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_DisciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "ID_Discipline", true));
            this.iD_DisciplineTextBox.Location = new System.Drawing.Point(87, 24);
            this.iD_DisciplineTextBox.Name = "iD_DisciplineTextBox";
            this.iD_DisciplineTextBox.Size = new System.Drawing.Size(548, 20);
            this.iD_DisciplineTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(87, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(548, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "Teacher", true));
            this.teacherTextBox.Location = new System.Drawing.Point(87, 76);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(548, 20);
            this.teacherTextBox.TabIndex = 6;
            // 
            // classNumberTextBox
            // 
            this.classNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "ClassNumber", true));
            this.classNumberTextBox.Location = new System.Drawing.Point(87, 102);
            this.classNumberTextBox.Name = "classNumberTextBox";
            this.classNumberTextBox.Size = new System.Drawing.Size(548, 20);
            this.classNumberTextBox.TabIndex = 8;
            // 
            // studyPlanTextBox
            // 
            this.studyPlanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studyPlanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinesBindingSource, "StudyPlan", true));
            this.studyPlanTextBox.Location = new System.Drawing.Point(87, 128);
            this.studyPlanTextBox.Name = "studyPlanTextBox";
            this.studyPlanTextBox.Size = new System.Drawing.Size(548, 20);
            this.studyPlanTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(iD_DisciplineLabel);
            this.groupBox1.Controls.Add(this.studyPlanTextBox);
            this.groupBox1.Controls.Add(this.iD_DisciplineTextBox);
            this.groupBox1.Controls.Add(studyPlanLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.classNumberTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(classNumberLabel);
            this.groupBox1.Controls.Add(teacherLabel);
            this.groupBox1.Controls.Add(this.teacherTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дисциплины";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.marksDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 280);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценки";
            // 
            // marksDataGridView
            // 
            this.marksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksDataGridView.AutoGenerateColumns = false;
            this.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.marksDataGridView.DataSource = this.marksBindingSource;
            this.marksDataGridView.Location = new System.Drawing.Point(9, 19);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.Size = new System.Drawing.Size(626, 255);
            this.marksDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Mark";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Mark";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Discipline";
            this.dataGridViewTextBoxColumn2.HeaderText = "Discipline";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateLesson";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateLesson";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateMark";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateMark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mark";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mark";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "FK_Marks_Disciplines";
            this.marksBindingSource.DataSource = this.disciplinesBindingSource;
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disciplinesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "DisciplineForm";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.DisciplineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workHeadTeacherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingNavigator)).EndInit();
            this.disciplinesBindingNavigator.ResumeLayout(false);
            this.disciplinesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.Work_Head_TeacherDataSetFile workHeadTeacherDataSet;
        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.DisciplinesTableAdapter disciplinesTableAdapter;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disciplinesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton disciplinesBindingNavigatorSaveItem;
        private Database.Work_Head_TeacherDataSetFileTableAdapters.MarksTableAdapter marksTableAdapter;
        private System.Windows.Forms.TextBox iD_DisciplineTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.TextBox classNumberTextBox;
        private System.Windows.Forms.TextBox studyPlanTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripFindTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripFilterComboBox;
    }
}