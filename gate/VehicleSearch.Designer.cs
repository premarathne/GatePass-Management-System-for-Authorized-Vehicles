namespace gate
{
    partial class VehicleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pnlHGride = new System.Windows.Forms.Panel();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHSearch = new System.Windows.Forms.Panel();
            this.btnHSearch = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.txtHNumber = new System.Windows.Forms.TextBox();
            this.btnHBack = new System.Windows.Forms.Button();
            this.btnHClear = new System.Windows.Forms.Button();
            this.pnlSSearch = new System.Windows.Forms.Panel();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSVNumber = new System.Windows.Forms.TextBox();
            this.pnlSVehicle = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSVState = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.picSVImage = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSVType = new System.Windows.Forms.TextBox();
            this.txtSVModel = new System.Windows.Forms.TextBox();
            this.btnSBack = new System.Windows.Forms.Button();
            this.btnSClear = new System.Windows.Forms.Button();
            this.pnlSOwner = new System.Windows.Forms.Panel();
            this.txtSOName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSOAline4 = new System.Windows.Forms.TextBox();
            this.txtSOTel = new System.Windows.Forms.TextBox();
            this.txtSOAline1 = new System.Windows.Forms.TextBox();
            this.txtSOAline3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSORole = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSOAline2 = new System.Windows.Forms.TextBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlHGride.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.pnlHSearch.SuspendLayout();
            this.pnlSSearch.SuspendLayout();
            this.pnlSVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSVImage)).BeginInit();
            this.pnlSOwner.SuspendLayout();
            this.pnlMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlSearch);
            this.panel1.Controls.Add(this.pnlMove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 609);
            this.panel1.TabIndex = 1;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Black;
            this.pnlSearch.Controls.Add(this.pnlHistory);
            this.pnlSearch.Controls.Add(this.pnlSSearch);
            this.pnlSearch.Controls.Add(this.pnlSVehicle);
            this.pnlSearch.Controls.Add(this.btnSBack);
            this.pnlSearch.Controls.Add(this.btnSClear);
            this.pnlSearch.Controls.Add(this.pnlSOwner);
            this.pnlSearch.Location = new System.Drawing.Point(60, 65);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(862, 548);
            this.pnlSearch.TabIndex = 21;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.Transparent;
            this.pnlHistory.Controls.Add(this.pnlHGride);
            this.pnlHistory.Controls.Add(this.pnlHSearch);
            this.pnlHistory.Controls.Add(this.btnHBack);
            this.pnlHistory.Controls.Add(this.btnHClear);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(862, 548);
            this.pnlHistory.TabIndex = 33;
            // 
            // pnlHGride
            // 
            this.pnlHGride.Controls.Add(this.gridHistory);
            this.pnlHGride.Location = new System.Drawing.Point(30, 130);
            this.pnlHGride.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHGride.Name = "pnlHGride";
            this.pnlHGride.Size = new System.Drawing.Size(802, 325);
            this.pnlHGride.TabIndex = 38;
            // 
            // gridHistory
            // 
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            this.gridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colGate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridHistory.EnableHeadersVisualStyles = false;
            this.gridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            this.gridHistory.Location = new System.Drawing.Point(30, 32);
            this.gridHistory.Margin = new System.Windows.Forms.Padding(2);
            this.gridHistory.MultiSelect = false;
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ReadOnly = true;
            this.gridHistory.RowHeadersWidth = 51;
            this.gridHistory.RowTemplate.Height = 24;
            this.gridHistory.Size = new System.Drawing.Size(742, 260);
            this.gridHistory.TabIndex = 0;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time & Date";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colGate
            // 
            this.colGate.HeaderText = "Gate";
            this.colGate.MinimumWidth = 6;
            this.colGate.Name = "colGate";
            this.colGate.ReadOnly = true;
            // 
            // pnlHSearch
            // 
            this.pnlHSearch.Controls.Add(this.btnHSearch);
            this.pnlHSearch.Controls.Add(this.label35);
            this.pnlHSearch.Controls.Add(this.txtHNumber);
            this.pnlHSearch.Location = new System.Drawing.Point(154, 32);
            this.pnlHSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHSearch.Name = "pnlHSearch";
            this.pnlHSearch.Size = new System.Drawing.Size(555, 65);
            this.pnlHSearch.TabIndex = 37;
            // 
            // btnHSearch
            // 
            this.btnHSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHSearch.FlatAppearance.BorderSize = 2;
            this.btnHSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnHSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnHSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSearch.ForeColor = System.Drawing.Color.White;
            this.btnHSearch.Location = new System.Drawing.Point(442, 18);
            this.btnHSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnHSearch.Name = "btnHSearch";
            this.btnHSearch.Size = new System.Drawing.Size(82, 28);
            this.btnHSearch.TabIndex = 2;
            this.btnHSearch.Text = "Search";
            this.btnHSearch.UseVisualStyleBackColor = true;
            this.btnHSearch.Click += new System.EventHandler(this.btnHSearch_Click);
            this.btnHSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHSearch_MouseClick);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(27, 23);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(109, 18);
            this.label35.TabIndex = 1;
            this.label35.Text = "Vehicle Number";
            // 
            // txtHNumber
            // 
            this.txtHNumber.BackColor = System.Drawing.Color.White;
            this.txtHNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHNumber.ForeColor = System.Drawing.Color.Black;
            this.txtHNumber.Location = new System.Drawing.Point(149, 20);
            this.txtHNumber.Name = "txtHNumber";
            this.txtHNumber.Size = new System.Drawing.Size(264, 25);
            this.txtHNumber.TabIndex = 0;
            // 
            // btnHBack
            // 
            this.btnHBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHBack.FlatAppearance.BorderSize = 2;
            this.btnHBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnHBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnHBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHBack.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHBack.ForeColor = System.Drawing.Color.White;
            this.btnHBack.Location = new System.Drawing.Point(750, 488);
            this.btnHBack.Name = "btnHBack";
            this.btnHBack.Size = new System.Drawing.Size(82, 28);
            this.btnHBack.TabIndex = 34;
            this.btnHBack.Text = "Back";
            this.btnHBack.UseVisualStyleBackColor = false;
            this.btnHBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHBack_MouseClick);
            // 
            // btnHClear
            // 
            this.btnHClear.BackColor = System.Drawing.Color.Transparent;
            this.btnHClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHClear.FlatAppearance.BorderSize = 2;
            this.btnHClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnHClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnHClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHClear.ForeColor = System.Drawing.Color.White;
            this.btnHClear.Location = new System.Drawing.Point(638, 488);
            this.btnHClear.Name = "btnHClear";
            this.btnHClear.Size = new System.Drawing.Size(82, 28);
            this.btnHClear.TabIndex = 33;
            this.btnHClear.Text = "Clear";
            this.btnHClear.UseVisualStyleBackColor = false;
            this.btnHClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHClear_MouseClick);
            // 
            // pnlSSearch
            // 
            this.pnlSSearch.Controls.Add(this.btnSSearch);
            this.pnlSSearch.Controls.Add(this.label17);
            this.pnlSSearch.Controls.Add(this.txtSVNumber);
            this.pnlSSearch.Location = new System.Drawing.Point(99, 32);
            this.pnlSSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSSearch.Name = "pnlSSearch";
            this.pnlSSearch.Size = new System.Drawing.Size(551, 48);
            this.pnlSSearch.TabIndex = 26;
            // 
            // btnSSearch
            // 
            this.btnSSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSSearch.FlatAppearance.BorderSize = 2;
            this.btnSSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnSSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.ForeColor = System.Drawing.Color.White;
            this.btnSSearch.Location = new System.Drawing.Point(442, 10);
            this.btnSSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(82, 28);
            this.btnSSearch.TabIndex = 2;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSSearch_MouseClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(27, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 18);
            this.label17.TabIndex = 1;
            this.label17.Text = "Vehicle Number";
            // 
            // txtSVNumber
            // 
            this.txtSVNumber.BackColor = System.Drawing.Color.White;
            this.txtSVNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVNumber.ForeColor = System.Drawing.Color.Black;
            this.txtSVNumber.Location = new System.Drawing.Point(149, 12);
            this.txtSVNumber.Name = "txtSVNumber";
            this.txtSVNumber.Size = new System.Drawing.Size(264, 25);
            this.txtSVNumber.TabIndex = 0;
            // 
            // pnlSVehicle
            // 
            this.pnlSVehicle.Controls.Add(this.label13);
            this.pnlSVehicle.Controls.Add(this.label14);
            this.pnlSVehicle.Controls.Add(this.txtSVState);
            this.pnlSVehicle.Controls.Add(this.label15);
            this.pnlSVehicle.Controls.Add(this.label16);
            this.pnlSVehicle.Controls.Add(this.picSVImage);
            this.pnlSVehicle.Controls.Add(this.label18);
            this.pnlSVehicle.Controls.Add(this.txtSVType);
            this.pnlSVehicle.Controls.Add(this.txtSVModel);
            this.pnlSVehicle.Location = new System.Drawing.Point(30, 95);
            this.pnlSVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSVehicle.Name = "pnlSVehicle";
            this.pnlSVehicle.Size = new System.Drawing.Size(330, 421);
            this.pnlSVehicle.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Vehicle State";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Image";
            // 
            // txtSVState
            // 
            this.txtSVState.BackColor = System.Drawing.Color.White;
            this.txtSVState.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVState.ForeColor = System.Drawing.Color.Black;
            this.txtSVState.Location = new System.Drawing.Point(22, 104);
            this.txtSVState.Name = "txtSVState";
            this.txtSVState.ReadOnly = true;
            this.txtSVState.Size = new System.Drawing.Size(286, 25);
            this.txtSVState.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 18);
            this.label16.TabIndex = 3;
            this.label16.Text = "Type";
            // 
            // picSVImage
            // 
            this.picSVImage.BackColor = System.Drawing.Color.White;
            this.picSVImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSVImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSVImage.Location = new System.Drawing.Point(22, 292);
            this.picSVImage.Name = "picSVImage";
            this.picSVImage.Size = new System.Drawing.Size(286, 107);
            this.picSVImage.TabIndex = 10;
            this.picSVImage.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(28, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(296, 39);
            this.label18.TabIndex = 0;
            this.label18.Text = "Vehicle Registration";
            // 
            // txtSVType
            // 
            this.txtSVType.BackColor = System.Drawing.Color.White;
            this.txtSVType.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVType.ForeColor = System.Drawing.Color.Black;
            this.txtSVType.Location = new System.Drawing.Point(22, 167);
            this.txtSVType.Name = "txtSVType";
            this.txtSVType.ReadOnly = true;
            this.txtSVType.Size = new System.Drawing.Size(286, 25);
            this.txtSVType.TabIndex = 3;
            // 
            // txtSVModel
            // 
            this.txtSVModel.BackColor = System.Drawing.Color.White;
            this.txtSVModel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVModel.ForeColor = System.Drawing.Color.Black;
            this.txtSVModel.Location = new System.Drawing.Point(22, 229);
            this.txtSVModel.Name = "txtSVModel";
            this.txtSVModel.ReadOnly = true;
            this.txtSVModel.Size = new System.Drawing.Size(286, 25);
            this.txtSVModel.TabIndex = 3;
            // 
            // btnSBack
            // 
            this.btnSBack.BackColor = System.Drawing.Color.Transparent;
            this.btnSBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSBack.FlatAppearance.BorderSize = 2;
            this.btnSBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnSBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnSBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSBack.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSBack.ForeColor = System.Drawing.Color.White;
            this.btnSBack.Location = new System.Drawing.Point(750, 488);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(82, 28);
            this.btnSBack.TabIndex = 23;
            this.btnSBack.Text = "Back";
            this.btnSBack.UseVisualStyleBackColor = false;
            this.btnSBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSBack_MouseClick);
            // 
            // btnSClear
            // 
            this.btnSClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSClear.FlatAppearance.BorderSize = 2;
            this.btnSClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnSClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.Color.White;
            this.btnSClear.Location = new System.Drawing.Point(750, 427);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(82, 28);
            this.btnSClear.TabIndex = 22;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = false;
            this.btnSClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSClear_MouseClick);
            // 
            // pnlSOwner
            // 
            this.pnlSOwner.Controls.Add(this.txtSOName);
            this.pnlSOwner.Controls.Add(this.label19);
            this.pnlSOwner.Controls.Add(this.label20);
            this.pnlSOwner.Controls.Add(this.txtSOAline4);
            this.pnlSOwner.Controls.Add(this.txtSOTel);
            this.pnlSOwner.Controls.Add(this.txtSOAline1);
            this.pnlSOwner.Controls.Add(this.txtSOAline3);
            this.pnlSOwner.Controls.Add(this.label22);
            this.pnlSOwner.Controls.Add(this.txtSORole);
            this.pnlSOwner.Controls.Add(this.label23);
            this.pnlSOwner.Controls.Add(this.label24);
            this.pnlSOwner.Controls.Add(this.txtSOAline2);
            this.pnlSOwner.Location = new System.Drawing.Point(390, 95);
            this.pnlSOwner.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSOwner.Name = "pnlSOwner";
            this.pnlSOwner.Size = new System.Drawing.Size(330, 421);
            this.pnlSOwner.TabIndex = 25;
            // 
            // txtSOName
            // 
            this.txtSOName.BackColor = System.Drawing.Color.White;
            this.txtSOName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOName.ForeColor = System.Drawing.Color.Black;
            this.txtSOName.Location = new System.Drawing.Point(22, 104);
            this.txtSOName.Name = "txtSOName";
            this.txtSOName.ReadOnly = true;
            this.txtSOName.Size = new System.Drawing.Size(286, 25);
            this.txtSOName.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(22, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 18);
            this.label19.TabIndex = 16;
            this.label19.Text = "Role";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(22, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 18);
            this.label20.TabIndex = 14;
            this.label20.Text = "Name";
            // 
            // txtSOAline4
            // 
            this.txtSOAline4.BackColor = System.Drawing.Color.White;
            this.txtSOAline4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOAline4.ForeColor = System.Drawing.Color.Black;
            this.txtSOAline4.Location = new System.Drawing.Point(22, 375);
            this.txtSOAline4.Name = "txtSOAline4";
            this.txtSOAline4.ReadOnly = true;
            this.txtSOAline4.Size = new System.Drawing.Size(286, 25);
            this.txtSOAline4.TabIndex = 12;
            // 
            // txtSOTel
            // 
            this.txtSOTel.BackColor = System.Drawing.Color.White;
            this.txtSOTel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOTel.ForeColor = System.Drawing.Color.Black;
            this.txtSOTel.Location = new System.Drawing.Point(22, 229);
            this.txtSOTel.Name = "txtSOTel";
            this.txtSOTel.ReadOnly = true;
            this.txtSOTel.Size = new System.Drawing.Size(286, 25);
            this.txtSOTel.TabIndex = 8;
            // 
            // txtSOAline1
            // 
            this.txtSOAline1.BackColor = System.Drawing.Color.White;
            this.txtSOAline1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOAline1.ForeColor = System.Drawing.Color.Black;
            this.txtSOAline1.Location = new System.Drawing.Point(22, 292);
            this.txtSOAline1.Name = "txtSOAline1";
            this.txtSOAline1.ReadOnly = true;
            this.txtSOAline1.Size = new System.Drawing.Size(286, 25);
            this.txtSOAline1.TabIndex = 9;
            // 
            // txtSOAline3
            // 
            this.txtSOAline3.BackColor = System.Drawing.Color.White;
            this.txtSOAline3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOAline3.ForeColor = System.Drawing.Color.Black;
            this.txtSOAline3.Location = new System.Drawing.Point(22, 347);
            this.txtSOAline3.Name = "txtSOAline3";
            this.txtSOAline3.ReadOnly = true;
            this.txtSOAline3.Size = new System.Drawing.Size(286, 25);
            this.txtSOAline3.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(22, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 18);
            this.label22.TabIndex = 17;
            this.label22.Text = "Telephone no";
            // 
            // txtSORole
            // 
            this.txtSORole.BackColor = System.Drawing.Color.White;
            this.txtSORole.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSORole.ForeColor = System.Drawing.Color.Black;
            this.txtSORole.Location = new System.Drawing.Point(22, 167);
            this.txtSORole.Name = "txtSORole";
            this.txtSORole.ReadOnly = true;
            this.txtSORole.Size = new System.Drawing.Size(286, 25);
            this.txtSORole.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(22, 269);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 18);
            this.label23.TabIndex = 18;
            this.label23.Text = "Address";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(65, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(216, 39);
            this.label24.TabIndex = 13;
            this.label24.Text = "Owner Details";
            // 
            // txtSOAline2
            // 
            this.txtSOAline2.BackColor = System.Drawing.Color.White;
            this.txtSOAline2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOAline2.ForeColor = System.Drawing.Color.Black;
            this.txtSOAline2.Location = new System.Drawing.Point(22, 319);
            this.txtSOAline2.Name = "txtSOAline2";
            this.txtSOAline2.ReadOnly = true;
            this.txtSOAline2.Size = new System.Drawing.Size(286, 25);
            this.txtSOAline2.TabIndex = 10;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(251)))));
            this.pnlMove.Controls.Add(this.btnHistory);
            this.pnlMove.Controls.Add(this.btnSearch);
            this.pnlMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(982, 32);
            this.pnlMove.TabIndex = 17;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(82, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(82, 32);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHistory_MouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 609);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehicleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Vehicle Details";
            this.Load += new System.EventHandler(this.VehicleSearch_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHGride.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.pnlHSearch.ResumeLayout(false);
            this.pnlHSearch.PerformLayout();
            this.pnlSSearch.ResumeLayout(false);
            this.pnlSSearch.PerformLayout();
            this.pnlSVehicle.ResumeLayout(false);
            this.pnlSVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSVImage)).EndInit();
            this.pnlSOwner.ResumeLayout(false);
            this.pnlSOwner.PerformLayout();
            this.pnlMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Panel pnlHGride;
        private System.Windows.Forms.Panel pnlHSearch;
        private System.Windows.Forms.Button btnHSearch;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtHNumber;
        private System.Windows.Forms.Button btnHBack;
        private System.Windows.Forms.Button btnHClear;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlSSearch;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSVNumber;
        private System.Windows.Forms.Panel pnlSVehicle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSVState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picSVImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSVType;
        private System.Windows.Forms.TextBox txtSVModel;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Panel pnlSOwner;
        private System.Windows.Forms.TextBox txtSOName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSOAline4;
        private System.Windows.Forms.TextBox txtSOTel;
        private System.Windows.Forms.TextBox txtSOAline1;
        private System.Windows.Forms.TextBox txtSOAline3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSORole;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSOAline2;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGate;
    }
}