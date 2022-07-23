
namespace HotelManagementProject
{
    partial class RoomInfo
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
            this.Roominfo_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RoomId_txt = new System.Windows.Forms.TextBox();
            this.RoomSearch_txt = new System.Windows.Forms.TextBox();
            this.RoomPhone_txt = new System.Windows.Forms.TextBox();
            this.roomsearch_btn = new System.Windows.Forms.Button();
            this.RoomDelete_btn = new System.Windows.Forms.Button();
            this.Roomedit_btn = new System.Windows.Forms.Button();
            this.roomadd_btn = new System.Windows.Forms.Button();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.yes_rebtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.no_rebtn = new System.Windows.Forms.RadioButton();
            this.backward_btn = new System.Windows.Forms.Button();
            this.ref_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.DateClient_lbl);
            this.panel1.Controls.Add(this.Roominfo_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 78);
            this.panel1.TabIndex = 2;
            // 
            // DateClient_lbl
            // 
            this.DateClient_lbl.AutoSize = true;
            this.DateClient_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DateClient_lbl.Location = new System.Drawing.Point(858, 53);
            this.DateClient_lbl.Name = "DateClient_lbl";
            this.DateClient_lbl.Size = new System.Drawing.Size(31, 15);
            this.DateClient_lbl.TabIndex = 1;
            this.DateClient_lbl.Text = "Date";
            // 
            // Roominfo_lbl
            // 
            this.Roominfo_lbl.AutoSize = true;
            this.Roominfo_lbl.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Roominfo_lbl.ForeColor = System.Drawing.Color.White;
            this.Roominfo_lbl.Location = new System.Drawing.Point(262, 9);
            this.Roominfo_lbl.Name = "Roominfo_lbl";
            this.Roominfo_lbl.Size = new System.Drawing.Size(244, 50);
            this.Roominfo_lbl.TabIndex = 0;
            this.Roominfo_lbl.Text = "Room Info";
            // 
            // RoomId_txt
            // 
            this.RoomId_txt.Location = new System.Drawing.Point(79, 152);
            this.RoomId_txt.Name = "RoomId_txt";
            this.RoomId_txt.Size = new System.Drawing.Size(374, 23);
            this.RoomId_txt.TabIndex = 3;
            // 
            // RoomSearch_txt
            // 
            this.RoomSearch_txt.Location = new System.Drawing.Point(459, 91);
            this.RoomSearch_txt.Name = "RoomSearch_txt";
            this.RoomSearch_txt.Size = new System.Drawing.Size(232, 23);
            this.RoomSearch_txt.TabIndex = 4;
            // 
            // RoomPhone_txt
            // 
            this.RoomPhone_txt.Location = new System.Drawing.Point(79, 220);
            this.RoomPhone_txt.Name = "RoomPhone_txt";
            this.RoomPhone_txt.Size = new System.Drawing.Size(100, 23);
            this.RoomPhone_txt.TabIndex = 6;
            // 
            // roomsearch_btn
            // 
            this.roomsearch_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomsearch_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roomsearch_btn.Location = new System.Drawing.Point(697, 87);
            this.roomsearch_btn.Name = "roomsearch_btn";
            this.roomsearch_btn.Size = new System.Drawing.Size(99, 33);
            this.roomsearch_btn.TabIndex = 7;
            this.roomsearch_btn.Text = "Search";
            this.roomsearch_btn.UseVisualStyleBackColor = true;
            this.roomsearch_btn.Click += new System.EventHandler(this.roomsearch_btn_Click);
            // 
            // RoomDelete_btn
            // 
            this.RoomDelete_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomDelete_btn.Location = new System.Drawing.Point(298, 392);
            this.RoomDelete_btn.Name = "RoomDelete_btn";
            this.RoomDelete_btn.Size = new System.Drawing.Size(91, 35);
            this.RoomDelete_btn.TabIndex = 8;
            this.RoomDelete_btn.Text = "DELETE";
            this.RoomDelete_btn.UseVisualStyleBackColor = true;
            this.RoomDelete_btn.Click += new System.EventHandler(this.RoomDelete_btn_Click);
            // 
            // Roomedit_btn
            // 
            this.Roomedit_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Roomedit_btn.Location = new System.Drawing.Point(187, 392);
            this.Roomedit_btn.Name = "Roomedit_btn";
            this.Roomedit_btn.Size = new System.Drawing.Size(75, 35);
            this.Roomedit_btn.TabIndex = 9;
            this.Roomedit_btn.Text = "EDIT";
            this.Roomedit_btn.UseVisualStyleBackColor = true;
            this.Roomedit_btn.Click += new System.EventHandler(this.Roomedit_btn_Click);
            // 
            // roomadd_btn
            // 
            this.roomadd_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomadd_btn.Location = new System.Drawing.Point(79, 392);
            this.roomadd_btn.Name = "roomadd_btn";
            this.roomadd_btn.Size = new System.Drawing.Size(75, 35);
            this.roomadd_btn.TabIndex = 10;
            this.roomadd_btn.Text = "ADD";
            this.roomadd_btn.UseVisualStyleBackColor = true;
            this.roomadd_btn.Click += new System.EventHandler(this.roomadd_btn_Click);
            // 
            // RoomGridView
            // 
            this.RoomGridView.AllowUserToAddRows = false;
            this.RoomGridView.AllowUserToOrderColumns = true;
            this.RoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Location = new System.Drawing.Point(459, 126);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowTemplate.Height = 25;
            this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridView.Size = new System.Drawing.Size(441, 289);
            this.RoomGridView.TabIndex = 12;
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Free";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yes_rebtn
            // 
            this.yes_rebtn.AutoSize = true;
            this.yes_rebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yes_rebtn.Location = new System.Drawing.Point(167, 281);
            this.yes_rebtn.Name = "yes_rebtn";
            this.yes_rebtn.Size = new System.Drawing.Size(14, 13);
            this.yes_rebtn.TabIndex = 14;
            this.yes_rebtn.TabStop = true;
            this.yes_rebtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(187, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(100, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // no_rebtn
            // 
            this.no_rebtn.AutoSize = true;
            this.no_rebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no_rebtn.Location = new System.Drawing.Point(80, 279);
            this.no_rebtn.Name = "no_rebtn";
            this.no_rebtn.Size = new System.Drawing.Size(14, 13);
            this.no_rebtn.TabIndex = 16;
            this.no_rebtn.TabStop = true;
            this.no_rebtn.UseVisualStyleBackColor = true;
            // 
            // backward_btn
            // 
            this.backward_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backward_btn.Location = new System.Drawing.Point(79, 512);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(100, 33);
            this.backward_btn.TabIndex = 19;
            this.backward_btn.Text = "Backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            // 
            // ref_btn
            // 
            this.ref_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ref_btn.ForeColor = System.Drawing.Color.Navy;
            this.ref_btn.Location = new System.Drawing.Point(802, 87);
            this.ref_btn.Name = "ref_btn";
            this.ref_btn.Size = new System.Drawing.Size(98, 33);
            this.ref_btn.TabIndex = 30;
            this.ref_btn.Text = "Refresh";
            this.ref_btn.UseVisualStyleBackColor = true;
            this.ref_btn.Click += new System.EventHandler(this.ref_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(79, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Room Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Room Phone";
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ref_btn);
            this.Controls.Add(this.backward_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_rebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yes_rebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.roomadd_btn);
            this.Controls.Add(this.Roomedit_btn);
            this.Controls.Add(this.RoomDelete_btn);
            this.Controls.Add(this.roomsearch_btn);
            this.Controls.Add(this.RoomPhone_txt);
            this.Controls.Add(this.RoomSearch_txt);
            this.Controls.Add(this.RoomId_txt);
            this.Controls.Add(this.panel1);
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateClient_lbl;
        private System.Windows.Forms.Label Roominfo_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox RoomId_txt;
        private System.Windows.Forms.TextBox RoomSearch_txt;
        private System.Windows.Forms.TextBox RoomPhone_txt;
        private System.Windows.Forms.Button roomsearch_btn;
        private System.Windows.Forms.Button RoomDelete_btn;
        private System.Windows.Forms.Button Roomedit_btn;
        private System.Windows.Forms.Button roomadd_btn;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton yes_rebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton no_rebtn;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Button ref_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}