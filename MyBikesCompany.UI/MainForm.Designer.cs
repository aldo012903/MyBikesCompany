namespace MyBikesCompany.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.plOpt = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.rbMountain = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.plList = new System.Windows.Forms.Panel();
            this.btnShowML = new System.Windows.Forms.Button();
            this.lstBikes = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.plBikes = new System.Windows.Forms.Panel();
            this.btnRoad = new System.Windows.Forms.Button();
            this.btnMountain = new System.Windows.Forms.Button();
            this.btnBike = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.plHome = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.plOpt.SuspendLayout();
            this.plList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plBikes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.plOpt);
            this.panel1.Controls.Add(this.plList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 260);
            this.panel1.TabIndex = 1;
            // 
            // plOpt
            // 
            this.plOpt.BackColor = System.Drawing.Color.Transparent;
            this.plOpt.Controls.Add(this.btnRefresh);
            this.plOpt.Controls.Add(this.btnUpdate);
            this.plOpt.Controls.Add(this.label3);
            this.plOpt.Controls.Add(this.btnSearch);
            this.plOpt.Controls.Add(this.btnRemove);
            this.plOpt.Controls.Add(this.txtSearch);
            this.plOpt.Controls.Add(this.rbRoad);
            this.plOpt.Controls.Add(this.rbMountain);
            this.plOpt.Controls.Add(this.rbAll);
            this.plOpt.Controls.Add(this.label2);
            this.plOpt.Dock = System.Windows.Forms.DockStyle.Top;
            this.plOpt.Location = new System.Drawing.Point(0, 0);
            this.plOpt.Name = "plOpt";
            this.plOpt.Size = new System.Drawing.Size(1508, 68);
            this.plOpt.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(775, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 47);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1306, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 52);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by Id:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1208, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 52);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(1404, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 52);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1105, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(88, 44);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(533, 15);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(206, 37);
            this.rbRoad.TabIndex = 5;
            this.rbRoad.TabStop = true;
            this.rbRoad.Text = "Road Bikes";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged);
            // 
            // rbMountain
            // 
            this.rbMountain.AutoSize = true;
            this.rbMountain.Location = new System.Drawing.Point(257, 15);
            this.rbMountain.Name = "rbMountain";
            this.rbMountain.Size = new System.Drawing.Size(270, 37);
            this.rbMountain.TabIndex = 4;
            this.rbMountain.TabStop = true;
            this.rbMountain.Text = "Mountain Bikes";
            this.rbMountain.UseVisualStyleBackColor = true;
            this.rbMountain.CheckedChanged += new System.EventHandler(this.rbMountain_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(170, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(94, 37);
            this.rbAll.TabIndex = 3;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort By:";
            // 
            // plList
            // 
            this.plList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plList.Controls.Add(this.btnShowML);
            this.plList.Controls.Add(this.lstBikes);
            this.plList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plList.Location = new System.Drawing.Point(0, 0);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(1508, 260);
            this.plList.TabIndex = 2;
            // 
            // btnShowML
            // 
            this.btnShowML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowML.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowML.Location = new System.Drawing.Point(1407, 74);
            this.btnShowML.Name = "btnShowML";
            this.btnShowML.Size = new System.Drawing.Size(89, 65);
            this.btnShowML.TabIndex = 2;
            this.btnShowML.Text = "Hide";
            this.btnShowML.UseVisualStyleBackColor = true;
            this.btnShowML.Click += new System.EventHandler(this.btnShowML_Click);
            // 
            // lstBikes
            // 
            this.lstBikes.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstBikes.AllowColumnReorder = true;
            this.lstBikes.AllowDrop = true;
            this.lstBikes.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lstBikes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBikes.FullRowSelect = true;
            this.lstBikes.LabelWrap = false;
            this.lstBikes.Location = new System.Drawing.Point(0, 64);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.ShowGroups = false;
            this.lstBikes.Size = new System.Drawing.Size(1508, 196);
            this.lstBikes.TabIndex = 0;
            this.lstBikes.TabStop = false;
            this.lstBikes.UseCompatibleStateImageBehavior = false;
            this.lstBikes.View = System.Windows.Forms.View.List;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.plBikes);
            this.panel2.Controls.Add(this.btnBike);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 631);
            this.panel2.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(0, 450);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(340, 96);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(0, 355);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(340, 95);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // plBikes
            // 
            this.plBikes.Controls.Add(this.btnRoad);
            this.plBikes.Controls.Add(this.btnMountain);
            this.plBikes.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBikes.Location = new System.Drawing.Point(0, 242);
            this.plBikes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plBikes.Name = "plBikes";
            this.plBikes.Size = new System.Drawing.Size(340, 113);
            this.plBikes.TabIndex = 2;
            this.plBikes.Visible = false;
            // 
            // btnRoad
            // 
            this.btnRoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoad.Location = new System.Drawing.Point(0, 55);
            this.btnRoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(340, 58);
            this.btnRoad.TabIndex = 1;
            this.btnRoad.Text = "Road Bike";
            this.btnRoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoad.UseVisualStyleBackColor = false;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // btnMountain
            // 
            this.btnMountain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMountain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMountain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMountain.Location = new System.Drawing.Point(0, 0);
            this.btnMountain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMountain.Name = "btnMountain";
            this.btnMountain.Size = new System.Drawing.Size(340, 55);
            this.btnMountain.TabIndex = 0;
            this.btnMountain.Text = "Mountain Bike";
            this.btnMountain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMountain.UseVisualStyleBackColor = false;
            this.btnMountain.Click += new System.EventHandler(this.btnMountain_Click);
            // 
            // btnBike
            // 
            this.btnBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBike.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBike.Location = new System.Drawing.Point(0, 146);
            this.btnBike.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBike.Name = "btnBike";
            this.btnBike.Size = new System.Drawing.Size(340, 96);
            this.btnBike.TabIndex = 1;
            this.btnBike.Text = "Add Bikes";
            this.btnBike.UseVisualStyleBackColor = true;
            this.btnBike.Click += new System.EventHandler(this.btnBike_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 146);
            this.panel3.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(13, 57);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(337, 37);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "My Bike Company.";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // plHome
            // 
            this.plHome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.plHome.Controls.Add(this.lblTime);
            this.plHome.Location = new System.Drawing.Point(339, 0);
            this.plHome.Name = "plHome";
            this.plHome.Size = new System.Drawing.Size(1170, 630);
            this.plHome.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(436, 270);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(238, 97);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tag = "hI MISS:";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 891);
            this.Controls.Add(this.plHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Bike Company.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.plOpt.ResumeLayout(false);
            this.plOpt.PerformLayout();
            this.plList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.plBikes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plHome.ResumeLayout(false);
            this.plHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnExit;
        private Button btnSave;
        private Panel plBikes;
        private Button btnBike;
        private Panel panel3;
        private Label lblHome;
        private Button btnRoad;
        private Button btnMountain;
        private Panel plOpt;
        private Label label2;
        private Panel plList;
        private Button btnShowML;
        private ListView lstBikes;
        private RadioButton rbRoad;
        private RadioButton rbMountain;
        private RadioButton rbAll;
        private Label label3;
        private Button btnSearch;
        private Button btnRemove;
        private TextBox txtSearch;
        private Panel plHome;
        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Button btnUpdate;
        private Button btnRefresh;
    }
}