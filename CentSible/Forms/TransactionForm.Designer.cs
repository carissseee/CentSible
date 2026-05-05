namespace CentSible.Forms
{
    partial class TransactionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.pnlBudget = new System.Windows.Forms.Panel();
            this.lblBudget2 = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.pnlTotalSpent = new System.Windows.Forms.Panel();
            this.lblSpent2 = new System.Windows.Forms.Label();
            this.lblSpent = new System.Windows.Forms.Label();
            this.pnlRemaining = new System.Windows.Forms.Panel();
            this.lblRemaining2 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SidebarTableLayoutTran = new System.Windows.Forms.FlowLayoutPanel();
            this.CentSibleTextPanelGoal = new System.Windows.Forms.Panel();
            this.CentSibleLabelTran = new System.Windows.Forms.Label();
            this.SideBarTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutButtonTran = new System.Windows.Forms.Button();
            this.PredTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.PredPicBoxTran = new System.Windows.Forms.PictureBox();
            this.PredButtonTran = new System.Windows.Forms.Button();
            this.SumTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.SumPicBoxTran = new System.Windows.Forms.PictureBox();
            this.SumButtonTran = new System.Windows.Forms.Button();
            this.TranTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.TranButtonTran = new System.Windows.Forms.Button();
            this.TranPicBoxTran = new System.Windows.Forms.PictureBox();
            this.GoalTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.GoalButtonTran = new System.Windows.Forms.Button();
            this.GoalPicBoxTran = new System.Windows.Forms.PictureBox();
            this.HomeTabLayTran = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButtonTran = new System.Windows.Forms.Button();
            this.HomePicBoxTran = new System.Windows.Forms.PictureBox();
            this.pnlBudget.SuspendLayout();
            this.pnlTotalSpent.SuspendLayout();
            this.pnlRemaining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SidebarTableLayoutTran.SuspendLayout();
            this.CentSibleTextPanelGoal.SuspendLayout();
            this.SideBarTabLayTran.SuspendLayout();
            this.PredTabLayTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredPicBoxTran)).BeginInit();
            this.SumTabLayTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumPicBoxTran)).BeginInit();
            this.TranTabLayTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranPicBoxTran)).BeginInit();
            this.GoalTabLayTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoalPicBoxTran)).BeginInit();
            this.HomeTabLayTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBoxTran)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTransaction.Location = new System.Drawing.Point(189, 12);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(126, 25);
            this.lblTransaction.TabIndex = 2;
            this.lblTransaction.Text = "Transaction";
            this.lblTransaction.Click += new System.EventHandler(this.lblTransaction_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDate.Location = new System.Drawing.Point(201, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "April 2026";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.Location = new System.Drawing.Point(720, 16);
            this.cmbYear.MaximumSize = new System.Drawing.Size(150, 0);
            this.cmbYear.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(124, 24);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(873, 16);
            this.cmbMonth.MaximumSize = new System.Drawing.Size(150, 0);
            this.cmbMonth.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(124, 24);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // pnlBudget
            // 
            this.pnlBudget.Controls.Add(this.lblBudget2);
            this.pnlBudget.Controls.Add(this.lblBudget);
            this.pnlBudget.Location = new System.Drawing.Point(194, 76);
            this.pnlBudget.Name = "pnlBudget";
            this.pnlBudget.Size = new System.Drawing.Size(234, 73);
            this.pnlBudget.TabIndex = 6;
            this.pnlBudget.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBudget_Paint);
            // 
            // lblBudget2
            // 
            this.lblBudget2.AutoSize = true;
            this.lblBudget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget2.ForeColor = System.Drawing.Color.Black;
            this.lblBudget2.Location = new System.Drawing.Point(27, 41);
            this.lblBudget2.Name = "lblBudget2";
            this.lblBudget2.Size = new System.Drawing.Size(56, 20);
            this.lblBudget2.TabIndex = 1;
            this.lblBudget2.Text = "₱ 0.00";
            this.lblBudget2.Click += new System.EventHandler(this.lblBudget2_Click_1);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBudget.Location = new System.Drawing.Point(7, 11);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(139, 20);
            this.lblBudget.TabIndex = 0;
            this.lblBudget.Text = "Monthly Budget";
            this.lblBudget.Click += new System.EventHandler(this.lblBudget_Click);
            // 
            // pnlTotalSpent
            // 
            this.pnlTotalSpent.Controls.Add(this.lblSpent2);
            this.pnlTotalSpent.Controls.Add(this.lblSpent);
            this.pnlTotalSpent.Location = new System.Drawing.Point(476, 76);
            this.pnlTotalSpent.Name = "pnlTotalSpent";
            this.pnlTotalSpent.Size = new System.Drawing.Size(234, 73);
            this.pnlTotalSpent.TabIndex = 7;
            this.pnlTotalSpent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotalSpent_Paint);
            // 
            // lblSpent2
            // 
            this.lblSpent2.AutoSize = true;
            this.lblSpent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent2.ForeColor = System.Drawing.Color.Red;
            this.lblSpent2.Location = new System.Drawing.Point(34, 41);
            this.lblSpent2.Name = "lblSpent2";
            this.lblSpent2.Size = new System.Drawing.Size(56, 20);
            this.lblSpent2.TabIndex = 2;
            this.lblSpent2.Text = "₱ 0.00";
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.ForeColor = System.Drawing.Color.Red;
            this.lblSpent.Location = new System.Drawing.Point(16, 11);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(105, 20);
            this.lblSpent.TabIndex = 2;
            this.lblSpent.Text = "Total Spent";
            this.lblSpent.Click += new System.EventHandler(this.lblSpent_Click);
            // 
            // pnlRemaining
            // 
            this.pnlRemaining.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlRemaining.Controls.Add(this.lblRemaining2);
            this.pnlRemaining.Controls.Add(this.lblRemaining);
            this.pnlRemaining.Location = new System.Drawing.Point(763, 76);
            this.pnlRemaining.Name = "pnlRemaining";
            this.pnlRemaining.Size = new System.Drawing.Size(234, 73);
            this.pnlRemaining.TabIndex = 7;
            // 
            // lblRemaining2
            // 
            this.lblRemaining2.AutoSize = true;
            this.lblRemaining2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining2.ForeColor = System.Drawing.Color.White;
            this.lblRemaining2.Location = new System.Drawing.Point(40, 41);
            this.lblRemaining2.Name = "lblRemaining2";
            this.lblRemaining2.Size = new System.Drawing.Size(56, 20);
            this.lblRemaining2.TabIndex = 3;
            this.lblRemaining2.Text = "₱ 0.00";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.Lime;
            this.lblRemaining.Location = new System.Drawing.Point(14, 11);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(162, 20);
            this.lblRemaining.TabIndex = 3;
            this.lblRemaining.Text = "Remaining Budget";
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAll.Location = new System.Drawing.Point(194, 194);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(69, 33);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExpense.Location = new System.Drawing.Point(282, 194);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(97, 33);
            this.btnExpense.TabIndex = 9;
            this.btnExpense.Text = "Expense";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBudget.Location = new System.Drawing.Point(405, 194);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(97, 33);
            this.btnBudget.TabIndex = 10;
            this.btnBudget.Text = "Budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTransaction.Location = new System.Drawing.Point(781, 194);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(216, 33);
            this.btnAddTransaction.TabIndex = 11;
            this.btnAddTransaction.Text = "+ Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colDescription,
            this.colType,
            this.colCategory,
            this.colAmount,
            this.colSave,
            this.colDelete,
            this.colTransactionID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.EnableHeadersVisualStyles = false;
            this.dgvTransaction.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvTransaction.Location = new System.Drawing.Point(194, 249);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(795, 249);
            this.dgvTransaction.TabIndex = 12;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellValueChanged);
            this.dgvTransaction.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvTransaction_CurrentCellDirtyStateChanged);
            this.dgvTransaction.Click += new System.EventHandler(this.dgvTransaction_Click);
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Items.AddRange(new object[] {
            "Expense",
            "Budget"});
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Items.AddRange(new object[] {
            "Income",
            "Allowance",
            "Food",
            "Transportation",
            "Utilities",
            "Miscellaneous",
            "Health",
            "Leisure",
            "Others"});
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            // 
            // colSave
            // 
            this.colSave.HeaderText = "";
            this.colSave.MinimumWidth = 6;
            this.colSave.Name = "colSave";
            this.colSave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Actions";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            // 
            // colTransactionID
            // 
            this.colTransactionID.HeaderText = "";
            this.colTransactionID.MinimumWidth = 6;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = false;
            // 
            // SidebarTableLayoutTran
            // 
            this.SidebarTableLayoutTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SidebarTableLayoutTran.Controls.Add(this.CentSibleTextPanelGoal);
            this.SidebarTableLayoutTran.Controls.Add(this.SideBarTabLayTran);
            this.SidebarTableLayoutTran.Location = new System.Drawing.Point(-2, -2);
            this.SidebarTableLayoutTran.Name = "SidebarTableLayoutTran";
            this.SidebarTableLayoutTran.Size = new System.Drawing.Size(200, 521);
            this.SidebarTableLayoutTran.TabIndex = 39;
            // 
            // CentSibleTextPanelGoal
            // 
            this.CentSibleTextPanelGoal.Controls.Add(this.CentSibleLabelTran);
            this.CentSibleTextPanelGoal.Location = new System.Drawing.Point(3, 3);
            this.CentSibleTextPanelGoal.Name = "CentSibleTextPanelGoal";
            this.CentSibleTextPanelGoal.Size = new System.Drawing.Size(197, 60);
            this.CentSibleTextPanelGoal.TabIndex = 12;
            // 
            // CentSibleLabelTran
            // 
            this.CentSibleLabelTran.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CentSibleLabelTran.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabelTran.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabelTran.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CentSibleLabelTran.Location = new System.Drawing.Point(0, -3);
            this.CentSibleLabelTran.Name = "CentSibleLabelTran";
            this.CentSibleLabelTran.Size = new System.Drawing.Size(197, 63);
            this.CentSibleLabelTran.TabIndex = 10;
            this.CentSibleLabelTran.Text = "CentSible";
            this.CentSibleLabelTran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarTabLayTran
            // 
            this.SideBarTabLayTran.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SideBarTabLayTran.ColumnCount = 1;
            this.SideBarTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideBarTabLayTran.Controls.Add(this.LogoutButtonTran, 1, 6);
            this.SideBarTabLayTran.Controls.Add(this.PredTabLayTran, 0, 4);
            this.SideBarTabLayTran.Controls.Add(this.SumTabLayTran, 0, 3);
            this.SideBarTabLayTran.Controls.Add(this.TranTabLayTran, 0, 2);
            this.SideBarTabLayTran.Controls.Add(this.GoalTabLayTran, 0, 1);
            this.SideBarTabLayTran.Controls.Add(this.HomeTabLayTran, 0, 0);
            this.SideBarTabLayTran.Location = new System.Drawing.Point(3, 69);
            this.SideBarTabLayTran.Name = "SideBarTabLayTran";
            this.SideBarTabLayTran.RowCount = 7;
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.SideBarTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.SideBarTabLayTran.Size = new System.Drawing.Size(189, 441);
            this.SideBarTabLayTran.TabIndex = 11;
            // 
            // LogoutButtonTran
            // 
            this.LogoutButtonTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutButtonTran.FlatAppearance.BorderSize = 0;
            this.LogoutButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.LogoutButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LogoutButtonTran.ForeColor = System.Drawing.Color.White;
            this.LogoutButtonTran.Location = new System.Drawing.Point(3, 399);
            this.LogoutButtonTran.Name = "LogoutButtonTran";
            this.LogoutButtonTran.Size = new System.Drawing.Size(183, 39);
            this.LogoutButtonTran.TabIndex = 15;
            this.LogoutButtonTran.Text = "Logout";
            this.LogoutButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonTran.UseVisualStyleBackColor = false;
            // 
            // PredTabLayTran
            // 
            this.PredTabLayTran.ColumnCount = 2;
            this.PredTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.PredTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.PredTabLayTran.Controls.Add(this.PredPicBoxTran, 0, 0);
            this.PredTabLayTran.Controls.Add(this.PredButtonTran, 1, 0);
            this.PredTabLayTran.Location = new System.Drawing.Point(3, 203);
            this.PredTabLayTran.Name = "PredTabLayTran";
            this.PredTabLayTran.RowCount = 1;
            this.PredTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayTran.Size = new System.Drawing.Size(183, 44);
            this.PredTabLayTran.TabIndex = 25;
            // 
            // PredPicBoxTran
            // 
            this.PredPicBoxTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PredPicBoxTran.Image = global::CentSible.Properties.Resources.PredictionForm;
            this.PredPicBoxTran.Location = new System.Drawing.Point(12, 3);
            this.PredPicBoxTran.Name = "PredPicBoxTran";
            this.PredPicBoxTran.Size = new System.Drawing.Size(40, 38);
            this.PredPicBoxTran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PredPicBoxTran.TabIndex = 19;
            this.PredPicBoxTran.TabStop = false;
            // 
            // PredButtonTran
            // 
            this.PredButtonTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.PredButtonTran.FlatAppearance.BorderSize = 0;
            this.PredButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.PredButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PredButtonTran.ForeColor = System.Drawing.Color.White;
            this.PredButtonTran.Location = new System.Drawing.Point(67, 3);
            this.PredButtonTran.Name = "PredButtonTran";
            this.PredButtonTran.Size = new System.Drawing.Size(113, 38);
            this.PredButtonTran.TabIndex = 14;
            this.PredButtonTran.Text = "Prediction";
            this.PredButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PredButtonTran.UseVisualStyleBackColor = false;
            // 
            // SumTabLayTran
            // 
            this.SumTabLayTran.ColumnCount = 2;
            this.SumTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.SumTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.SumTabLayTran.Controls.Add(this.SumPicBoxTran, 0, 0);
            this.SumTabLayTran.Controls.Add(this.SumButtonTran, 1, 0);
            this.SumTabLayTran.Location = new System.Drawing.Point(3, 153);
            this.SumTabLayTran.Name = "SumTabLayTran";
            this.SumTabLayTran.RowCount = 1;
            this.SumTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayTran.Size = new System.Drawing.Size(183, 44);
            this.SumTabLayTran.TabIndex = 24;
            // 
            // SumPicBoxTran
            // 
            this.SumPicBoxTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumPicBoxTran.Image = global::CentSible.Properties.Resources.SummaryForm;
            this.SumPicBoxTran.Location = new System.Drawing.Point(12, 3);
            this.SumPicBoxTran.Name = "SumPicBoxTran";
            this.SumPicBoxTran.Size = new System.Drawing.Size(40, 38);
            this.SumPicBoxTran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SumPicBoxTran.TabIndex = 18;
            this.SumPicBoxTran.TabStop = false;
            // 
            // SumButtonTran
            // 
            this.SumButtonTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SumButtonTran.FlatAppearance.BorderSize = 0;
            this.SumButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.SumButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SumButtonTran.ForeColor = System.Drawing.Color.White;
            this.SumButtonTran.Location = new System.Drawing.Point(67, 3);
            this.SumButtonTran.Name = "SumButtonTran";
            this.SumButtonTran.Size = new System.Drawing.Size(113, 38);
            this.SumButtonTran.TabIndex = 13;
            this.SumButtonTran.Text = "Summary";
            this.SumButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumButtonTran.UseVisualStyleBackColor = false;
            // 
            // TranTabLayTran
            // 
            this.TranTabLayTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.TranTabLayTran.ColumnCount = 2;
            this.TranTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.TranTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.TranTabLayTran.Controls.Add(this.TranButtonTran, 1, 0);
            this.TranTabLayTran.Controls.Add(this.TranPicBoxTran, 0, 0);
            this.TranTabLayTran.Location = new System.Drawing.Point(3, 103);
            this.TranTabLayTran.Name = "TranTabLayTran";
            this.TranTabLayTran.RowCount = 1;
            this.TranTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayTran.Size = new System.Drawing.Size(183, 44);
            this.TranTabLayTran.TabIndex = 23;
            // 
            // TranButtonTran
            // 
            this.TranButtonTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.TranButtonTran.FlatAppearance.BorderSize = 0;
            this.TranButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.TranButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TranButtonTran.ForeColor = System.Drawing.Color.White;
            this.TranButtonTran.Location = new System.Drawing.Point(67, 3);
            this.TranButtonTran.Name = "TranButtonTran";
            this.TranButtonTran.Size = new System.Drawing.Size(113, 38);
            this.TranButtonTran.TabIndex = 12;
            this.TranButtonTran.Text = "Transactions";
            this.TranButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranButtonTran.UseVisualStyleBackColor = false;
            // 
            // TranPicBoxTran
            // 
            this.TranPicBoxTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TranPicBoxTran.Image = global::CentSible.Properties.Resources.TransactionForm;
            this.TranPicBoxTran.Location = new System.Drawing.Point(12, 5);
            this.TranPicBoxTran.Name = "TranPicBoxTran";
            this.TranPicBoxTran.Size = new System.Drawing.Size(40, 33);
            this.TranPicBoxTran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TranPicBoxTran.TabIndex = 16;
            this.TranPicBoxTran.TabStop = false;
            // 
            // GoalTabLayTran
            // 
            this.GoalTabLayTran.ColumnCount = 2;
            this.GoalTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63415F));
            this.GoalTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.36585F));
            this.GoalTabLayTran.Controls.Add(this.GoalButtonTran, 1, 0);
            this.GoalTabLayTran.Controls.Add(this.GoalPicBoxTran, 0, 0);
            this.GoalTabLayTran.Location = new System.Drawing.Point(3, 53);
            this.GoalTabLayTran.Name = "GoalTabLayTran";
            this.GoalTabLayTran.RowCount = 1;
            this.GoalTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayTran.Size = new System.Drawing.Size(183, 44);
            this.GoalTabLayTran.TabIndex = 22;
            // 
            // GoalButtonTran
            // 
            this.GoalButtonTran.FlatAppearance.BorderSize = 0;
            this.GoalButtonTran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.GoalButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.GoalButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GoalButtonTran.ForeColor = System.Drawing.Color.White;
            this.GoalButtonTran.Location = new System.Drawing.Point(66, 3);
            this.GoalButtonTran.Name = "GoalButtonTran";
            this.GoalButtonTran.Size = new System.Drawing.Size(114, 38);
            this.GoalButtonTran.TabIndex = 11;
            this.GoalButtonTran.Text = "Goal";
            this.GoalButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoalButtonTran.UseVisualStyleBackColor = false;
            this.GoalButtonTran.Click += new System.EventHandler(this.GoalButtonTran_Click);
            // 
            // GoalPicBoxTran
            // 
            this.GoalPicBoxTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoalPicBoxTran.Image = global::CentSible.Properties.Resources.GoalForm;
            this.GoalPicBoxTran.Location = new System.Drawing.Point(11, 3);
            this.GoalPicBoxTran.Name = "GoalPicBoxTran";
            this.GoalPicBoxTran.Size = new System.Drawing.Size(40, 38);
            this.GoalPicBoxTran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoalPicBoxTran.TabIndex = 17;
            this.GoalPicBoxTran.TabStop = false;
            // 
            // HomeTabLayTran
            // 
            this.HomeTabLayTran.ColumnCount = 2;
            this.HomeTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.HomeTabLayTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.HomeTabLayTran.Controls.Add(this.HomeButtonTran, 1, 0);
            this.HomeTabLayTran.Controls.Add(this.HomePicBoxTran, 0, 0);
            this.HomeTabLayTran.Location = new System.Drawing.Point(3, 3);
            this.HomeTabLayTran.Name = "HomeTabLayTran";
            this.HomeTabLayTran.RowCount = 1;
            this.HomeTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeTabLayTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeTabLayTran.Size = new System.Drawing.Size(183, 44);
            this.HomeTabLayTran.TabIndex = 21;
            // 
            // HomeButtonTran
            // 
            this.HomeButtonTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.HomeButtonTran.FlatAppearance.BorderSize = 0;
            this.HomeButtonTran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.HomeButtonTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonTran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HomeButtonTran.ForeColor = System.Drawing.Color.White;
            this.HomeButtonTran.Location = new System.Drawing.Point(67, 3);
            this.HomeButtonTran.Name = "HomeButtonTran";
            this.HomeButtonTran.Size = new System.Drawing.Size(108, 38);
            this.HomeButtonTran.TabIndex = 8;
            this.HomeButtonTran.Text = "Home";
            this.HomeButtonTran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButtonTran.UseVisualStyleBackColor = false;
            // 
            // HomePicBoxTran
            // 
            this.HomePicBoxTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomePicBoxTran.Image = global::CentSible.Properties.Resources.HomeForm;
            this.HomePicBoxTran.Location = new System.Drawing.Point(12, 3);
            this.HomePicBoxTran.Name = "HomePicBoxTran";
            this.HomePicBoxTran.Size = new System.Drawing.Size(40, 38);
            this.HomePicBoxTran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePicBoxTran.TabIndex = 15;
            this.HomePicBoxTran.TabStop = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1035, 510);
            this.Controls.Add(this.SidebarTableLayoutTran);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.pnlRemaining);
            this.Controls.Add(this.pnlTotalSpent);
            this.Controls.Add(this.pnlBudget);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTransaction);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1053, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1053, 557);
            this.Name = "TransactionForm";
            this.RightToLeftLayout = true;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.pnlBudget.ResumeLayout(false);
            this.pnlBudget.PerformLayout();
            this.pnlTotalSpent.ResumeLayout(false);
            this.pnlTotalSpent.PerformLayout();
            this.pnlRemaining.ResumeLayout(false);
            this.pnlRemaining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.SidebarTableLayoutTran.ResumeLayout(false);
            this.CentSibleTextPanelGoal.ResumeLayout(false);
            this.SideBarTabLayTran.ResumeLayout(false);
            this.PredTabLayTran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredPicBoxTran)).EndInit();
            this.SumTabLayTran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SumPicBoxTran)).EndInit();
            this.TranTabLayTran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TranPicBoxTran)).EndInit();
            this.GoalTabLayTran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoalPicBoxTran)).EndInit();
            this.HomeTabLayTran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBoxTran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Panel pnlBudget;
        private System.Windows.Forms.Panel pnlTotalSpent;
        private System.Windows.Forms.Panel pnlRemaining;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblBudget2;
        private System.Windows.Forms.Label lblSpent2;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label lblRemaining2;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colSave;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.FlowLayoutPanel SidebarTableLayoutTran;
        private System.Windows.Forms.Panel CentSibleTextPanelGoal;
        private System.Windows.Forms.Label CentSibleLabelTran;
        private System.Windows.Forms.TableLayoutPanel SideBarTabLayTran;
        private System.Windows.Forms.Button LogoutButtonTran;
        private System.Windows.Forms.TableLayoutPanel PredTabLayTran;
        private System.Windows.Forms.PictureBox PredPicBoxTran;
        private System.Windows.Forms.Button PredButtonTran;
        private System.Windows.Forms.TableLayoutPanel SumTabLayTran;
        private System.Windows.Forms.PictureBox SumPicBoxTran;
        private System.Windows.Forms.Button SumButtonTran;
        private System.Windows.Forms.TableLayoutPanel TranTabLayTran;
        private System.Windows.Forms.Button TranButtonTran;
        private System.Windows.Forms.PictureBox TranPicBoxTran;
        private System.Windows.Forms.TableLayoutPanel GoalTabLayTran;
        private System.Windows.Forms.Button GoalButtonTran;
        private System.Windows.Forms.PictureBox GoalPicBoxTran;
        private System.Windows.Forms.TableLayoutPanel HomeTabLayTran;
        private System.Windows.Forms.Button HomeButtonTran;
        private System.Windows.Forms.PictureBox HomePicBoxTran;
    }
}