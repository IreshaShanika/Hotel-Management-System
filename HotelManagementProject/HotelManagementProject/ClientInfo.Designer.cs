
namespace HotelManagementProject
{
    partial class ClientInfo
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
            this.Clientinfo_lbl = new System.Windows.Forms.Label();
            this.Clientid_txt = new System.Windows.Forms.TextBox();
            this.Clientidname_txt = new System.Windows.Forms.TextBox();
            this.PhoneNumber_txt = new System.Windows.Forms.TextBox();
            this.clientcountry_com = new System.Windows.Forms.ComboBox();
            this.CliendGridView = new System.Windows.Forms.DataGridView();
            this.AddClient_btn = new System.Windows.Forms.Button();
            this.Editclient_btn = new System.Windows.Forms.Button();
            this.DeleteClient_btn = new System.Windows.Forms.Button();
            this.Searchclient_txt = new System.Windows.Forms.TextBox();
            this.SearchClient_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.backward_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CliendGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.DateClient_lbl);
            this.panel1.Controls.Add(this.Clientinfo_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 78);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DateClient_lbl
            // 
            this.DateClient_lbl.AutoSize = true;
            this.DateClient_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DateClient_lbl.Location = new System.Drawing.Point(870, 53);
            this.DateClient_lbl.Name = "DateClient_lbl";
            this.DateClient_lbl.Size = new System.Drawing.Size(31, 15);
            this.DateClient_lbl.TabIndex = 1;
            this.DateClient_lbl.Text = "Date";
            // 
            // Clientinfo_lbl
            // 
            this.Clientinfo_lbl.AutoSize = true;
            this.Clientinfo_lbl.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clientinfo_lbl.ForeColor = System.Drawing.Color.White;
            this.Clientinfo_lbl.Location = new System.Drawing.Point(290, 18);
            this.Clientinfo_lbl.Name = "Clientinfo_lbl";
            this.Clientinfo_lbl.Size = new System.Drawing.Size(251, 50);
            this.Clientinfo_lbl.TabIndex = 0;
            this.Clientinfo_lbl.Text = "Client Info";
            // 
            // Clientid_txt
            // 
            this.Clientid_txt.Location = new System.Drawing.Point(41, 137);
            this.Clientid_txt.Name = "Clientid_txt";
            this.Clientid_txt.Size = new System.Drawing.Size(413, 23);
            this.Clientid_txt.TabIndex = 1;
            this.Clientid_txt.TextChanged += new System.EventHandler(this.Clientid_txt_TextChanged);
            // 
            // Clientidname_txt
            // 
            this.Clientidname_txt.Location = new System.Drawing.Point(41, 210);
            this.Clientidname_txt.Name = "Clientidname_txt";
            this.Clientidname_txt.Size = new System.Drawing.Size(413, 23);
            this.Clientidname_txt.TabIndex = 2;
            // 
            // PhoneNumber_txt
            // 
            this.PhoneNumber_txt.Location = new System.Drawing.Point(41, 275);
            this.PhoneNumber_txt.Name = "PhoneNumber_txt";
            this.PhoneNumber_txt.Size = new System.Drawing.Size(413, 23);
            this.PhoneNumber_txt.TabIndex = 3;
            // 
            // clientcountry_com
            // 
            this.clientcountry_com.FormattingEnabled = true;
            this.clientcountry_com.Items.AddRange(new object[] {
            "Sri Lanka",
            "UK",
            "USA",
            "India",
            "China"});
            this.clientcountry_com.Location = new System.Drawing.Point(41, 364);
            this.clientcountry_com.Name = "clientcountry_com";
            this.clientcountry_com.Size = new System.Drawing.Size(413, 23);
            this.clientcountry_com.TabIndex = 4;
            // 
            // CliendGridView
            // 
            this.CliendGridView.AllowUserToAddRows = false;
            this.CliendGridView.BackgroundColor = System.Drawing.Color.White;
            this.CliendGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CliendGridView.Location = new System.Drawing.Point(460, 119);
            this.CliendGridView.Name = "CliendGridView";
            this.CliendGridView.RowTemplate.Height = 25;
            this.CliendGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CliendGridView.Size = new System.Drawing.Size(441, 289);
            this.CliendGridView.TabIndex = 5;
            this.CliendGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CliendGridView_CellContentClick);
            // 
            // AddClient_btn
            // 
            this.AddClient_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddClient_btn.Location = new System.Drawing.Point(41, 454);
            this.AddClient_btn.Name = "AddClient_btn";
            this.AddClient_btn.Size = new System.Drawing.Size(75, 32);
            this.AddClient_btn.TabIndex = 6;
            this.AddClient_btn.Text = "ADD";
            this.AddClient_btn.UseVisualStyleBackColor = true;
            this.AddClient_btn.Click += new System.EventHandler(this.AddClient_btn_Click);
            // 
            // Editclient_btn
            // 
            this.Editclient_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Editclient_btn.Location = new System.Drawing.Point(162, 454);
            this.Editclient_btn.Name = "Editclient_btn";
            this.Editclient_btn.Size = new System.Drawing.Size(75, 32);
            this.Editclient_btn.TabIndex = 7;
            this.Editclient_btn.Text = "EDIT";
            this.Editclient_btn.UseVisualStyleBackColor = true;
            this.Editclient_btn.Click += new System.EventHandler(this.Editclient_btn_Click);
            // 
            // DeleteClient_btn
            // 
            this.DeleteClient_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteClient_btn.Location = new System.Drawing.Point(280, 454);
            this.DeleteClient_btn.Name = "DeleteClient_btn";
            this.DeleteClient_btn.Size = new System.Drawing.Size(86, 32);
            this.DeleteClient_btn.TabIndex = 8;
            this.DeleteClient_btn.Text = "DELETE";
            this.DeleteClient_btn.UseVisualStyleBackColor = true;
            this.DeleteClient_btn.Click += new System.EventHandler(this.DeleteClient_btn_Click);
            // 
            // Searchclient_txt
            // 
            this.Searchclient_txt.Location = new System.Drawing.Point(460, 90);
            this.Searchclient_txt.Name = "Searchclient_txt";
            this.Searchclient_txt.Size = new System.Drawing.Size(244, 23);
            this.Searchclient_txt.TabIndex = 9;
            this.Searchclient_txt.TextChanged += new System.EventHandler(this.Searchclient_txt_TextChanged);
            // 
            // SearchClient_btn
            // 
            this.SearchClient_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchClient_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchClient_btn.Location = new System.Drawing.Point(710, 88);
            this.SearchClient_btn.Name = "SearchClient_btn";
            this.SearchClient_btn.Size = new System.Drawing.Size(84, 28);
            this.SearchClient_btn.TabIndex = 10;
            this.SearchClient_btn.Text = "Search";
            this.SearchClient_btn.UseVisualStyleBackColor = true;
            this.SearchClient_btn.Click += new System.EventHandler(this.SearchClient_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_btn.ForeColor = System.Drawing.Color.Navy;
            this.Refresh_btn.Location = new System.Drawing.Point(800, 88);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(101, 29);
            this.Refresh_btn.TabIndex = 11;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // backward_btn
            // 
            this.backward_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backward_btn.Location = new System.Drawing.Point(41, 528);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(98, 30);
            this.backward_btn.TabIndex = 13;
            this.backward_btn.Text = "Backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Client Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Client Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Client Country";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backward_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.SearchClient_btn);
            this.Controls.Add(this.Searchclient_txt);
            this.Controls.Add(this.DeleteClient_btn);
            this.Controls.Add(this.Editclient_btn);
            this.Controls.Add(this.AddClient_btn);
            this.Controls.Add(this.CliendGridView);
            this.Controls.Add(this.clientcountry_com);
            this.Controls.Add(this.PhoneNumber_txt);
            this.Controls.Add(this.Clientidname_txt);
            this.Controls.Add(this.Clientid_txt);
            this.Controls.Add(this.panel1);
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CliendGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Clientinfo_lbl;
        private System.Windows.Forms.TextBox Clientid_txt;
        private System.Windows.Forms.TextBox Clientidname_txt;
        private System.Windows.Forms.TextBox PhoneNumber_txt;
        private System.Windows.Forms.ComboBox clientcountry_com;
        private System.Windows.Forms.DataGridView CliendGridView;
        private System.Windows.Forms.Button AddClient_btn;
        private System.Windows.Forms.Button Editclient_btn;
        private System.Windows.Forms.Button DeleteClient_btn;
        private System.Windows.Forms.TextBox Searchclient_txt;
        private System.Windows.Forms.Button SearchClient_btn;
        private System.Windows.Forms.Label DateClient_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}