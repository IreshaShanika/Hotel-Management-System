
namespace HotelManagementProject
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
            this.Main_Form_lbl = new System.Windows.Forms.Label();
            this.Staff_btn = new System.Windows.Forms.Button();
            this.Client_btn = new System.Windows.Forms.Button();
            this.Reservation_btn = new System.Windows.Forms.Button();
            this.Room_btn = new System.Windows.Forms.Button();
            this.X_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backward_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Form_lbl
            // 
            this.Main_Form_lbl.AutoSize = true;
            this.Main_Form_lbl.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Main_Form_lbl.ForeColor = System.Drawing.Color.White;
            this.Main_Form_lbl.Location = new System.Drawing.Point(288, 18);
            this.Main_Form_lbl.Name = "Main_Form_lbl";
            this.Main_Form_lbl.Size = new System.Drawing.Size(246, 50);
            this.Main_Form_lbl.TabIndex = 0;
            this.Main_Form_lbl.Text = "Main Form";
            this.Main_Form_lbl.Click += new System.EventHandler(this.Main_Form_lbl_Click);
            // 
            // Staff_btn
            // 
            this.Staff_btn.BackColor = System.Drawing.Color.Blue;
            this.Staff_btn.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_btn.ForeColor = System.Drawing.Color.Silver;
            this.Staff_btn.Location = new System.Drawing.Point(573, 128);
            this.Staff_btn.Name = "Staff_btn";
            this.Staff_btn.Size = new System.Drawing.Size(214, 55);
            this.Staff_btn.TabIndex = 1;
            this.Staff_btn.Text = "Staff";
            this.Staff_btn.UseVisualStyleBackColor = false;
            this.Staff_btn.Click += new System.EventHandler(this.Staff_btn_Click);
            // 
            // Client_btn
            // 
            this.Client_btn.BackColor = System.Drawing.Color.Blue;
            this.Client_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Client_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Client_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Client_btn.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_btn.ForeColor = System.Drawing.Color.Silver;
            this.Client_btn.Location = new System.Drawing.Point(130, 128);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.Size = new System.Drawing.Size(265, 64);
            this.Client_btn.TabIndex = 2;
            this.Client_btn.Text = "Client";
            this.Client_btn.UseVisualStyleBackColor = false;
            this.Client_btn.Click += new System.EventHandler(this.Client_btn_Click);
            // 
            // Reservation_btn
            // 
            this.Reservation_btn.BackColor = System.Drawing.Color.Blue;
            this.Reservation_btn.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reservation_btn.ForeColor = System.Drawing.Color.Silver;
            this.Reservation_btn.Location = new System.Drawing.Point(539, 236);
            this.Reservation_btn.Name = "Reservation_btn";
            this.Reservation_btn.Size = new System.Drawing.Size(287, 79);
            this.Reservation_btn.TabIndex = 3;
            this.Reservation_btn.Text = "Reservation";
            this.Reservation_btn.UseVisualStyleBackColor = false;
            this.Reservation_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Room_btn
            // 
            this.Room_btn.BackColor = System.Drawing.Color.Blue;
            this.Room_btn.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Room_btn.ForeColor = System.Drawing.Color.Gray;
            this.Room_btn.Location = new System.Drawing.Point(116, 236);
            this.Room_btn.Name = "Room_btn";
            this.Room_btn.Size = new System.Drawing.Size(331, 69);
            this.Room_btn.TabIndex = 4;
            this.Room_btn.Text = "Rooms";
            this.Room_btn.UseVisualStyleBackColor = false;
            this.Room_btn.Click += new System.EventHandler(this.Room_btn_Click);
            // 
            // X_lbl
            // 
            this.X_lbl.AutoSize = true;
            this.X_lbl.ForeColor = System.Drawing.Color.White;
            this.X_lbl.Location = new System.Drawing.Point(905, 9);
            this.X_lbl.Name = "X_lbl";
            this.X_lbl.Size = new System.Drawing.Size(14, 15);
            this.X_lbl.TabIndex = 6;
            this.X_lbl.Text = "X";
            this.X_lbl.Click += new System.EventHandler(this.X_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.X_lbl);
            this.panel1.Controls.Add(this.Main_Form_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 78);
            this.panel1.TabIndex = 7;
            // 
            // backward_btn
            // 
            this.backward_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backward_btn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backward_btn.Location = new System.Drawing.Point(440, 386);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(133, 44);
            this.backward_btn.TabIndex = 12;
            this.backward_btn.Text = "Backward";
            this.backward_btn.UseVisualStyleBackColor = false;
            this.backward_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.backward_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Room_btn);
            this.Controls.Add(this.Reservation_btn);
            this.Controls.Add(this.Client_btn);
            this.Controls.Add(this.Staff_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Main_Form_lbl;
        private System.Windows.Forms.Button Staff_btn;
        private System.Windows.Forms.Button Client_btn;
        private System.Windows.Forms.Button Reservation_btn;
        private System.Windows.Forms.Button Room_btn;
        private System.Windows.Forms.Label X_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backward_btn;
    }
}