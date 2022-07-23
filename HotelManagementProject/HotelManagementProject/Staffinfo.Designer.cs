
namespace HotelManagementProject
{
    partial class Staffinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateClient_lbl = new System.Windows.Forms.Label();
            this.Staffinfo_lbl = new System.Windows.Forms.Label();
            this.Staffid_txt = new System.Windows.Forms.TextBox();
            this.staffSearch_txt = new System.Windows.Forms.TextBox();
            this.StaffPhone_txt = new System.Windows.Forms.TextBox();
            this.StaffName_txt = new System.Windows.Forms.TextBox();
            this.Gender_com = new System.Windows.Forms.ComboBox();
            this.StaffAdd_btn = new System.Windows.Forms.Button();
            this.StaffDelete_btn = new System.Windows.Forms.Button();
            this.StaffEdit_btn = new System.Windows.Forms.Button();
            this.StaffSearch_btn = new System.Windows.Forms.Button();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.password_txt = new System.Windows.Forms.TextBox();
            this.backward_btn = new System.Windows.Forms.Button();
            this.ref_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.DateClient_lbl);
            this.panel1.Controls.Add(this.Staffinfo_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 78);
            this.panel1.TabIndex = 1;
            // 
            // DateClient_lbl
            // 
            this.DateClient_lbl.AutoSize = true;
            this.DateClient_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DateClient_lbl.Location = new System.Drawing.Point(872, 53);
            this.DateClient_lbl.Name = "DateClient_lbl";
            this.DateClient_lbl.Size = new System.Drawing.Size(31, 15);
            this.DateClient_lbl.TabIndex = 1;
            this.DateClient_lbl.Text = "Date";
            this.DateClient_lbl.Click += new System.EventHandler(this.DateClient_lbl_Click);
            // 
            // Staffinfo_lbl
            // 
            this.Staffinfo_lbl.AutoSize = true;
            this.Staffinfo_lbl.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staffinfo_lbl.ForeColor = System.Drawing.Color.White;
            this.Staffinfo_lbl.Location = new System.Drawing.Point(284, 18);
            this.Staffinfo_lbl.Name = "Staffinfo_lbl";
            this.Staffinfo_lbl.Size = new System.Drawing.Size(245, 50);
            this.Staffinfo_lbl.TabIndex = 0;
            this.Staffinfo_lbl.Text = "Staff Info";
            // 
            // Staffid_txt
            // 
            this.Staffid_txt.Location = new System.Drawing.Point(48, 149);
            this.Staffid_txt.Name = "Staffid_txt";
            this.Staffid_txt.Size = new System.Drawing.Size(408, 23);
            this.Staffid_txt.TabIndex = 2;
            // 
            // staffSearch_txt
            // 
            this.staffSearch_txt.Location = new System.Drawing.Point(462, 88);
            this.staffSearch_txt.Name = "staffSearch_txt";
            this.staffSearch_txt.Size = new System.Drawing.Size(253, 23);
            this.staffSearch_txt.TabIndex = 3;
            this.staffSearch_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StaffPhone_txt
            // 
            this.StaffPhone_txt.Location = new System.Drawing.Point(48, 310);
            this.StaffPhone_txt.Name = "StaffPhone_txt";
            this.StaffPhone_txt.Size = new System.Drawing.Size(408, 23);
            this.StaffPhone_txt.TabIndex = 4;
            this.StaffPhone_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StaffName_txt
            // 
            this.StaffName_txt.Location = new System.Drawing.Point(48, 228);
            this.StaffName_txt.Name = "StaffName_txt";
            this.StaffName_txt.Size = new System.Drawing.Size(408, 23);
            this.StaffName_txt.TabIndex = 5;
            // 
            // Gender_com
            // 
            this.Gender_com.FormattingEnabled = true;
            this.Gender_com.Items.AddRange(new object[] {
            "m",
            "f"});
            this.Gender_com.Location = new System.Drawing.Point(48, 445);
            this.Gender_com.Name = "Gender_com";
            this.Gender_com.Size = new System.Drawing.Size(408, 23);
            this.Gender_com.TabIndex = 6;
            // 
            // StaffAdd_btn
            // 
            this.StaffAdd_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffAdd_btn.Location = new System.Drawing.Point(48, 489);
            this.StaffAdd_btn.Name = "StaffAdd_btn";
            this.StaffAdd_btn.Size = new System.Drawing.Size(75, 40);
            this.StaffAdd_btn.TabIndex = 7;
            this.StaffAdd_btn.Text = "ADD";
            this.StaffAdd_btn.UseVisualStyleBackColor = true;
            this.StaffAdd_btn.Click += new System.EventHandler(this.StaffAdd_btn_Click);
            // 
            // StaffDelete_btn
            // 
            this.StaffDelete_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffDelete_btn.Location = new System.Drawing.Point(265, 489);
            this.StaffDelete_btn.Name = "StaffDelete_btn";
            this.StaffDelete_btn.Size = new System.Drawing.Size(85, 40);
            this.StaffDelete_btn.TabIndex = 8;
            this.StaffDelete_btn.Text = "DELETE";
            this.StaffDelete_btn.UseVisualStyleBackColor = true;
            this.StaffDelete_btn.Click += new System.EventHandler(this.StaffDelete_btn_Click);
            // 
            // StaffEdit_btn
            // 
            this.StaffEdit_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffEdit_btn.Location = new System.Drawing.Point(159, 489);
            this.StaffEdit_btn.Name = "StaffEdit_btn";
            this.StaffEdit_btn.Size = new System.Drawing.Size(75, 40);
            this.StaffEdit_btn.TabIndex = 9;
            this.StaffEdit_btn.Text = "EDIT";
            this.StaffEdit_btn.UseVisualStyleBackColor = true;
            this.StaffEdit_btn.Click += new System.EventHandler(this.StaffEdit_btn_Click);
            // 
            // StaffSearch_btn
            // 
            this.StaffSearch_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffSearch_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StaffSearch_btn.Location = new System.Drawing.Point(721, 84);
            this.StaffSearch_btn.Name = "StaffSearch_btn";
            this.StaffSearch_btn.Size = new System.Drawing.Size(84, 33);
            this.StaffSearch_btn.TabIndex = 10;
            this.StaffSearch_btn.Text = "Search";
            this.StaffSearch_btn.UseVisualStyleBackColor = true;
            this.StaffSearch_btn.Click += new System.EventHandler(this.StaffSearch_btn_Click);
            // 
            // StaffGridView
            // 
            this.StaffGridView.AllowUserToAddRows = false;
            this.StaffGridView.AllowUserToOrderColumns = true;
            this.StaffGridView.BackgroundColor = System.Drawing.Color.White;
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView.Location = new System.Drawing.Point(462, 123);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.RowTemplate.Height = 25;
            this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridView.Size = new System.Drawing.Size(441, 289);
            this.StaffGridView.TabIndex = 11;
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(48, 377);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(408, 23);
            this.password_txt.TabIndex = 12;
            // 
            // backward_btn
            // 
            this.backward_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backward_btn.Location = new System.Drawing.Point(48, 535);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(105, 34);
            this.backward_btn.TabIndex = 13;
            this.backward_btn.Text = "Backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            // 
            // ref_btn
            // 
            this.ref_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ref_btn.ForeColor = System.Drawing.Color.Navy;
            this.ref_btn.Location = new System.Drawing.Point(811, 84);
            this.ref_btn.Name = "ref_btn";
            this.ref_btn.Size = new System.Drawing.Size(92, 33);
            this.ref_btn.TabIndex = 31;
            this.ref_btn.Text = "Refresh";
            this.ref_btn.UseVisualStyleBackColor = true;
            this.ref_btn.Click += new System.EventHandler(this.ref_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Staff Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Staff Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Staff Password";
            // 
            // Staffinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ref_btn);
            this.Controls.Add(this.backward_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.StaffSearch_btn);
            this.Controls.Add(this.StaffEdit_btn);
            this.Controls.Add(this.StaffDelete_btn);
            this.Controls.Add(this.StaffAdd_btn);
            this.Controls.Add(this.Gender_com);
            this.Controls.Add(this.StaffName_txt);
            this.Controls.Add(this.StaffPhone_txt);
            this.Controls.Add(this.staffSearch_txt);
            this.Controls.Add(this.Staffid_txt);
            this.Controls.Add(this.panel1);
            this.Name = "Staffinfo";
            this.Text = "Staffinfo";
            this.Load += new System.EventHandler(this.Staffinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateClient_lbl;
        private System.Windows.Forms.Label Staffinfo_lbl;
        private System.Windows.Forms.TextBox Staffid_txt;
        private System.Windows.Forms.TextBox staffSearch_txt;
        private System.Windows.Forms.TextBox StaffPhone_txt;
        private System.Windows.Forms.TextBox StaffName_txt;
        private System.Windows.Forms.ComboBox Gender_com;
        private System.Windows.Forms.Button StaffAdd_btn;
        private System.Windows.Forms.Button StaffDelete_btn;
        private System.Windows.Forms.Button StaffEdit_btn;
        private System.Windows.Forms.Button StaffSearch_btn;
        private System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Button ref_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}