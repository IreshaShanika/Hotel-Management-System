
namespace HotelManagementProject
{
    partial class Reservationinfo
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
            this.Reservation_lbl = new System.Windows.Forms.Label();
            this.RedId_txt = new System.Windows.Forms.TextBox();
            this.label1DateOut_lbl = new System.Windows.Forms.Label();
            this.DateIn_lbl = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Redsearch_btn = new System.Windows.Forms.Button();
            this.RedSearch_txt = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.RedGridView = new System.Windows.Forms.DataGridView();
            this.RedAdd_btn = new System.Windows.Forms.Button();
            this.RedDelete_btn = new System.Windows.Forms.Button();
            this.RedEdit_btn = new System.Windows.Forms.Button();
            this.Redcliend_txt = new System.Windows.Forms.ComboBox();
            this.RedRoom_txt = new System.Windows.Forms.ComboBox();
            this.ref_btn = new System.Windows.Forms.Button();
            this.backward_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.DateClient_lbl);
            this.panel1.Controls.Add(this.Reservation_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 78);
            this.panel1.TabIndex = 3;
            // 
            // DateClient_lbl
            // 
            this.DateClient_lbl.AutoSize = true;
            this.DateClient_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DateClient_lbl.Location = new System.Drawing.Point(877, 54);
            this.DateClient_lbl.Name = "DateClient_lbl";
            this.DateClient_lbl.Size = new System.Drawing.Size(31, 15);
            this.DateClient_lbl.TabIndex = 1;
            this.DateClient_lbl.Text = "Date";
            this.DateClient_lbl.Click += new System.EventHandler(this.DateClient_lbl_Click);
            // 
            // Reservation_lbl
            // 
            this.Reservation_lbl.AutoSize = true;
            this.Reservation_lbl.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reservation_lbl.ForeColor = System.Drawing.Color.White;
            this.Reservation_lbl.Location = new System.Drawing.Point(52, 9);
            this.Reservation_lbl.Name = "Reservation_lbl";
            this.Reservation_lbl.Size = new System.Drawing.Size(605, 50);
            this.Reservation_lbl.TabIndex = 0;
            this.Reservation_lbl.Text = "Reservation Informations";
            // 
            // RedId_txt
            // 
            this.RedId_txt.Location = new System.Drawing.Point(52, 152);
            this.RedId_txt.Name = "RedId_txt";
            this.RedId_txt.Size = new System.Drawing.Size(409, 23);
            this.RedId_txt.TabIndex = 4;
            this.RedId_txt.TextChanged += new System.EventHandler(this.RedId_txt_TextChanged);
            // 
            // label1DateOut_lbl
            // 
            this.label1DateOut_lbl.AutoSize = true;
            this.label1DateOut_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1DateOut_lbl.Location = new System.Drawing.Point(52, 404);
            this.label1DateOut_lbl.Name = "label1DateOut_lbl";
            this.label1DateOut_lbl.Size = new System.Drawing.Size(94, 23);
            this.label1DateOut_lbl.TabIndex = 2;
            this.label1DateOut_lbl.Text = "DateOut";
            this.label1DateOut_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateIn_lbl
            // 
            this.DateIn_lbl.AutoSize = true;
            this.DateIn_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateIn_lbl.Location = new System.Drawing.Point(52, 341);
            this.DateIn_lbl.Name = "DateIn_lbl";
            this.DateIn_lbl.Size = new System.Drawing.Size(79, 23);
            this.DateIn_lbl.TabIndex = 3;
            this.DateIn_lbl.Text = "DateIn";
            this.DateIn_lbl.Click += new System.EventHandler(this.DateIn_lbl_Click);
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(52, 367);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 23);
            this.dateIn.TabIndex = 7;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateTimePicker_red_ValueChanged);
            // 
            // Dateout
            // 
            this.Dateout.Location = new System.Drawing.Point(52, 430);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(200, 23);
            this.Dateout.TabIndex = 8;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // Redsearch_btn
            // 
            this.Redsearch_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Redsearch_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Redsearch_btn.Location = new System.Drawing.Point(721, 89);
            this.Redsearch_btn.Name = "Redsearch_btn";
            this.Redsearch_btn.Size = new System.Drawing.Size(84, 28);
            this.Redsearch_btn.TabIndex = 20;
            this.Redsearch_btn.Text = "Search";
            this.Redsearch_btn.UseVisualStyleBackColor = true;
            this.Redsearch_btn.Click += new System.EventHandler(this.Redsearch_btn_Click);
            // 
            // RedSearch_txt
            // 
            this.RedSearch_txt.Location = new System.Drawing.Point(467, 91);
            this.RedSearch_txt.Name = "RedSearch_txt";
            this.RedSearch_txt.Size = new System.Drawing.Size(248, 23);
            this.RedSearch_txt.TabIndex = 19;
            // 
            // RedGridView
            // 
            this.RedGridView.AllowUserToAddRows = false;
            this.RedGridView.AllowUserToOrderColumns = true;
            this.RedGridView.BackgroundColor = System.Drawing.Color.White;
            this.RedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RedGridView.Location = new System.Drawing.Point(467, 126);
            this.RedGridView.Name = "RedGridView";
            this.RedGridView.RowTemplate.Height = 25;
            this.RedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RedGridView.Size = new System.Drawing.Size(441, 289);
            this.RedGridView.TabIndex = 22;
            this.RedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RedGridView_CellContentClick);
            // 
            // RedAdd_btn
            // 
            this.RedAdd_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RedAdd_btn.Location = new System.Drawing.Point(52, 477);
            this.RedAdd_btn.Name = "RedAdd_btn";
            this.RedAdd_btn.Size = new System.Drawing.Size(75, 32);
            this.RedAdd_btn.TabIndex = 23;
            this.RedAdd_btn.Text = "ADD";
            this.RedAdd_btn.UseVisualStyleBackColor = true;
            this.RedAdd_btn.Click += new System.EventHandler(this.RedAdd_btn_Click);
            // 
            // RedDelete_btn
            // 
            this.RedDelete_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RedDelete_btn.Location = new System.Drawing.Point(291, 480);
            this.RedDelete_btn.Name = "RedDelete_btn";
            this.RedDelete_btn.Size = new System.Drawing.Size(90, 26);
            this.RedDelete_btn.TabIndex = 24;
            this.RedDelete_btn.Text = "DELETE";
            this.RedDelete_btn.UseVisualStyleBackColor = true;
            this.RedDelete_btn.Click += new System.EventHandler(this.RedDelete_btn_Click);
            // 
            // RedEdit_btn
            // 
            this.RedEdit_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RedEdit_btn.Location = new System.Drawing.Point(166, 477);
            this.RedEdit_btn.Name = "RedEdit_btn";
            this.RedEdit_btn.Size = new System.Drawing.Size(75, 32);
            this.RedEdit_btn.TabIndex = 25;
            this.RedEdit_btn.Text = "EDIT";
            this.RedEdit_btn.UseVisualStyleBackColor = true;
            this.RedEdit_btn.Click += new System.EventHandler(this.RedEdit_btn_Click);
            // 
            // Redcliend_txt
            // 
            this.Redcliend_txt.FormattingEnabled = true;
            this.Redcliend_txt.Location = new System.Drawing.Point(52, 220);
            this.Redcliend_txt.Name = "Redcliend_txt";
            this.Redcliend_txt.Size = new System.Drawing.Size(409, 23);
            this.Redcliend_txt.TabIndex = 27;
            this.Redcliend_txt.SelectedIndexChanged += new System.EventHandler(this.Redcliend_txt_SelectedIndexChanged);
            // 
            // RedRoom_txt
            // 
            this.RedRoom_txt.FormattingEnabled = true;
            this.RedRoom_txt.Location = new System.Drawing.Point(52, 295);
            this.RedRoom_txt.Name = "RedRoom_txt";
            this.RedRoom_txt.Size = new System.Drawing.Size(409, 23);
            this.RedRoom_txt.TabIndex = 28;
            this.RedRoom_txt.SelectedIndexChanged += new System.EventHandler(this.RedRoom_txt_SelectedIndexChanged);
            // 
            // ref_btn
            // 
            this.ref_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ref_btn.ForeColor = System.Drawing.Color.Navy;
            this.ref_btn.Location = new System.Drawing.Point(811, 91);
            this.ref_btn.Name = "ref_btn";
            this.ref_btn.Size = new System.Drawing.Size(97, 28);
            this.ref_btn.TabIndex = 29;
            this.ref_btn.Text = "Refresh";
            this.ref_btn.UseVisualStyleBackColor = true;
            this.ref_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backward_btn
            // 
            this.backward_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backward_btn.Location = new System.Drawing.Point(52, 535);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(104, 33);
            this.backward_btn.TabIndex = 30;
            this.backward_btn.Text = "Backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Reservation Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Reservation Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Reservation Client";
            // 
            // Reservationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backward_btn);
            this.Controls.Add(this.ref_btn);
            this.Controls.Add(this.RedRoom_txt);
            this.Controls.Add(this.Redcliend_txt);
            this.Controls.Add(this.RedEdit_btn);
            this.Controls.Add(this.RedDelete_btn);
            this.Controls.Add(this.RedAdd_btn);
            this.Controls.Add(this.RedGridView);
            this.Controls.Add(this.Redsearch_btn);
            this.Controls.Add(this.RedSearch_txt);
            this.Controls.Add(this.Dateout);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.label1DateOut_lbl);
            this.Controls.Add(this.DateIn_lbl);
            this.Controls.Add(this.RedId_txt);
            this.Controls.Add(this.panel1);
            this.Name = "Reservationinfo";
            this.Text = "Reservationinfo";
            this.Load += new System.EventHandler(this.Reservationinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateClient_lbl;
        private System.Windows.Forms.Label Reservation_lbl;
        private System.Windows.Forms.Label label1DateOut_lbl;
        private System.Windows.Forms.TextBox RedId_txt;
        private System.Windows.Forms.Label DateIn_lbl;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Redsearch_btn;
        private System.Windows.Forms.TextBox RedSearch_txt;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView RedGridView;
        private System.Windows.Forms.Button RedAdd_btn;
        private System.Windows.Forms.Button RedDelete_btn;
        private System.Windows.Forms.Button RedEdit_btn;
        private System.Windows.Forms.ComboBox Redcliend_txt;
        private System.Windows.Forms.ComboBox RedRoom_txt;
        private System.Windows.Forms.Button ref_btn;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}