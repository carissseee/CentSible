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
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CentSibleLabel = new System.Windows.Forms.Label();
            this.HomeButtonGoal = new System.Windows.Forms.Button();
            this.GoalButtonGoal = new System.Windows.Forms.Button();
            this.TranButtonGoal = new System.Windows.Forms.Button();
            this.SumButtonGoal = new System.Windows.Forms.Button();
            this.PredButtonGoal = new System.Windows.Forms.Button();
            this.LogoutButtonGoal = new System.Windows.Forms.Button();
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
            this.colCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SidebarLayout.SuspendLayout();
            this.pnlBudget.SuspendLayout();
            this.pnlTotalSpent.SuspendLayout();
            this.pnlRemaining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarLayout
            // 
            this.SidebarLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SidebarLayout.ColumnCount = 1;
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarLayout.Controls.Add(this.CentSibleLabel, 0, 0);
            this.SidebarLayout.Controls.Add(this.HomeButtonGoal, 0, 1);
            this.SidebarLayout.Controls.Add(this.GoalButtonGoal, 0, 2);
            this.SidebarLayout.Controls.Add(this.TranButtonGoal, 0, 3);
            this.SidebarLayout.Controls.Add(this.SumButtonGoal, 0, 4);
            this.SidebarLayout.Controls.Add(this.PredButtonGoal, 0, 5);
            this.SidebarLayout.Controls.Add(this.LogoutButtonGoal, 0, 6);
            this.SidebarLayout.Location = new System.Drawing.Point(1, 0);
            this.SidebarLayout.Name = "SidebarLayout";
            this.SidebarLayout.RowCount = 7;
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.48F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83F));
            this.SidebarLayout.Size = new System.Drawing.Size(170, 508);
            this.SidebarLayout.TabIndex = 1;
            // 
            // CentSibleLabel
            // 
            this.CentSibleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CentSibleLabel.AutoSize = true;
            this.CentSibleLabel.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabel.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabel.Location = new System.Drawing.Point(12, 12);
            this.CentSibleLabel.Name = "CentSibleLabel";
            this.CentSibleLabel.Size = new System.Drawing.Size(146, 48);
            this.CentSibleLabel.TabIndex = 0;
            this.CentSibleLabel.Text = "CentSible";
            this.CentSibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeButtonGoal
            // 
            this.HomeButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.HomeButtonGoal.FlatAppearance.BorderSize = 0;
            this.HomeButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.HomeButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.HomeButtonGoal.ForeColor = System.Drawing.Color.White;
            this.HomeButtonGoal.Location = new System.Drawing.Point(3, 76);
            this.HomeButtonGoal.Name = "HomeButtonGoal";
            this.HomeButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.HomeButtonGoal.TabIndex = 1;
            this.HomeButtonGoal.Text = "Home";
            this.HomeButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButtonGoal.UseVisualStyleBackColor = false;
            // 
            // GoalButtonGoal
            // 
            this.GoalButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.GoalButtonGoal.FlatAppearance.BorderSize = 0;
            this.GoalButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.GoalButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.GoalButtonGoal.ForeColor = System.Drawing.Color.White;
            this.GoalButtonGoal.Location = new System.Drawing.Point(3, 127);
            this.GoalButtonGoal.Name = "GoalButtonGoal";
            this.GoalButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.GoalButtonGoal.TabIndex = 2;
            this.GoalButtonGoal.Text = "Goal";
            this.GoalButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoalButtonGoal.UseVisualStyleBackColor = false;
            // 
            // TranButtonGoal
            // 
            this.TranButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.TranButtonGoal.FlatAppearance.BorderSize = 0;
            this.TranButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.TranButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.TranButtonGoal.ForeColor = System.Drawing.Color.White;
            this.TranButtonGoal.Location = new System.Drawing.Point(3, 178);
            this.TranButtonGoal.Name = "TranButtonGoal";
            this.TranButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.TranButtonGoal.TabIndex = 3;
            this.TranButtonGoal.Text = "Transactions";
            this.TranButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranButtonGoal.UseVisualStyleBackColor = false;
            // 
            // SumButtonGoal
            // 
            this.SumButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SumButtonGoal.FlatAppearance.BorderSize = 0;
            this.SumButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.SumButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.SumButtonGoal.ForeColor = System.Drawing.Color.White;
            this.SumButtonGoal.Location = new System.Drawing.Point(3, 229);
            this.SumButtonGoal.Name = "SumButtonGoal";
            this.SumButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.SumButtonGoal.TabIndex = 4;
            this.SumButtonGoal.Text = "Summary";
            this.SumButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumButtonGoal.UseVisualStyleBackColor = false;
            // 
            // PredButtonGoal
            // 
            this.PredButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.PredButtonGoal.FlatAppearance.BorderSize = 0;
            this.PredButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.PredButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.PredButtonGoal.ForeColor = System.Drawing.Color.White;
            this.PredButtonGoal.Location = new System.Drawing.Point(3, 280);
            this.PredButtonGoal.Name = "PredButtonGoal";
            this.PredButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.PredButtonGoal.TabIndex = 5;
            this.PredButtonGoal.Text = "Prediction";
            this.PredButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PredButtonGoal.UseVisualStyleBackColor = false;
            // 
            // LogoutButtonGoal
            // 
            this.LogoutButtonGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutButtonGoal.FlatAppearance.BorderSize = 0;
            this.LogoutButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.LogoutButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.LogoutButtonGoal.ForeColor = System.Drawing.Color.White;
            this.LogoutButtonGoal.Location = new System.Drawing.Point(3, 465);
            this.LogoutButtonGoal.Name = "LogoutButtonGoal";
            this.LogoutButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.LogoutButtonGoal.TabIndex = 6;
            this.LogoutButtonGoal.Text = "Logout";
            this.LogoutButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonGoal.UseVisualStyleBackColor = false;
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
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTransaction.Location = new System.Drawing.Point(781, 205);
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
            this.colCategory,
            this.colType,
            this.colAmount,
            this.colEdit,
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
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Items.AddRange(new object[] {
            "Income,",
            "Allowance,",
            "Food,",
            "Transportation,",
            "Utilities,",
            "Miscellaneous,",
            "Health,",
            "Leisure,",
            "Others"});
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Items.AddRange(new object[] {
            "Budget",
            "Expense"});
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
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
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 510);
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
            this.Controls.Add(this.SidebarLayout);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarLayout.PerformLayout();
            this.pnlBudget.ResumeLayout(false);
            this.pnlBudget.PerformLayout();
            this.pnlTotalSpent.ResumeLayout(false);
            this.pnlTotalSpent.PerformLayout();
            this.pnlRemaining.ResumeLayout(false);
            this.pnlRemaining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SidebarLayout;
        private System.Windows.Forms.Label CentSibleLabel;
        private System.Windows.Forms.Button HomeButtonGoal;
        private System.Windows.Forms.Button GoalButtonGoal;
        private System.Windows.Forms.Button TranButtonGoal;
        private System.Windows.Forms.Button SumButtonGoal;
        private System.Windows.Forms.Button PredButtonGoal;
        private System.Windows.Forms.Button LogoutButtonGoal;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
    }
}