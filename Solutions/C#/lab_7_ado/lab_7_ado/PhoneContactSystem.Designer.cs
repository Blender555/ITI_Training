namespace lab_7_ado
{
    partial class PhoneContactSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneContactSystem));
            head_lbl = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            all_btn = new Button();
            by_id_btn = new Button();
            delete_btn = new Button();
            update_btn = new Button();
            insert_btn = new Button();
            address_lbl = new Label();
            phone_lbl = new Label();
            name_lbl = new Label();
            id_lbl = new Label();
            address_txt = new TextBox();
            phone_txt = new TextBox();
            name_txt = new TextBox();
            id_txt = new TextBox();
            dataGridView = new DataGridView();
            search_lbl = new Label();
            search_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // head_lbl
            // 
            head_lbl.Anchor = AnchorStyles.Top;
            head_lbl.AutoSize = true;
            head_lbl.Font = new Font("Andalus", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            head_lbl.Location = new Point(330, 28);
            head_lbl.Name = "head_lbl";
            head_lbl.Size = new Size(281, 41);
            head_lbl.TabIndex = 0;
            head_lbl.Text = "Phone Book Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.contacts;
            pictureBox1.Location = new Point(425, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(all_btn);
            panel1.Controls.Add(by_id_btn);
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(insert_btn);
            panel1.Controls.Add(address_lbl);
            panel1.Controls.Add(phone_lbl);
            panel1.Controls.Add(name_lbl);
            panel1.Controls.Add(id_lbl);
            panel1.Controls.Add(address_txt);
            panel1.Controls.Add(phone_txt);
            panel1.Controls.Add(name_txt);
            panel1.Controls.Add(id_txt);
            panel1.Location = new Point(10, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 260);
            panel1.TabIndex = 2;
            // 
            // all_btn
            // 
            all_btn.BackColor = Color.White;
            all_btn.FlatStyle = FlatStyle.Flat;
            all_btn.Font = new Font("Segoe UI", 11.25F);
            all_btn.Location = new Point(164, 212);
            all_btn.Name = "all_btn";
            all_btn.Size = new Size(85, 40);
            all_btn.TabIndex = 12;
            all_btn.Text = "Get All";
            all_btn.UseVisualStyleBackColor = false;
            all_btn.Click += all_btn_Click;
            // 
            // by_id_btn
            // 
            by_id_btn.BackColor = Color.White;
            by_id_btn.FlatStyle = FlatStyle.Flat;
            by_id_btn.Font = new Font("Segoe UI", 11.25F);
            by_id_btn.Location = new Point(73, 212);
            by_id_btn.Name = "by_id_btn";
            by_id_btn.Size = new Size(85, 40);
            by_id_btn.TabIndex = 11;
            by_id_btn.Text = "Get By ID";
            by_id_btn.UseVisualStyleBackColor = false;
            by_id_btn.Click += by_id_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.White;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 11.25F);
            delete_btn.Location = new Point(283, 145);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 40);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.White;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI", 11.25F);
            update_btn.Location = new Point(283, 91);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 40);
            update_btn.TabIndex = 9;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // insert_btn
            // 
            insert_btn.BackColor = Color.White;
            insert_btn.FlatStyle = FlatStyle.Flat;
            insert_btn.Font = new Font("Segoe UI", 11.25F);
            insert_btn.Location = new Point(283, 37);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(75, 40);
            insert_btn.TabIndex = 8;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = false;
            insert_btn.Click += insert_btn_Click;
            // 
            // address_lbl
            // 
            address_lbl.AutoSize = true;
            address_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            address_lbl.Location = new Point(27, 174);
            address_lbl.Name = "address_lbl";
            address_lbl.Size = new Size(58, 20);
            address_lbl.TabIndex = 3;
            address_lbl.Text = "Address";
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            phone_lbl.Location = new Point(27, 123);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(49, 20);
            phone_lbl.TabIndex = 2;
            phone_lbl.Text = "Phone";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            name_lbl.Location = new Point(26, 72);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(48, 20);
            name_lbl.TabIndex = 1;
            name_lbl.Text = "Name";
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            id_lbl.Location = new Point(26, 21);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(24, 20);
            id_lbl.TabIndex = 0;
            id_lbl.Text = "ID";
            // 
            // address_txt
            // 
            address_txt.Location = new Point(95, 171);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(136, 23);
            address_txt.TabIndex = 7;
            // 
            // phone_txt
            // 
            phone_txt.Location = new Point(95, 121);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(136, 23);
            phone_txt.TabIndex = 6;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(95, 71);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(136, 23);
            name_txt.TabIndex = 5;
            // 
            // id_txt
            // 
            id_txt.Location = new Point(95, 21);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(136, 23);
            id_txt.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(437, 169);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(440, 260);
            dataGridView.TabIndex = 3;
            dataGridView.RowHeaderMouseClick += dataGridView_RowHeaderMouseClick;
            // 
            // search_lbl
            // 
            search_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            search_lbl.Location = new Point(552, 116);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(57, 21);
            search_lbl.TabIndex = 5;
            search_lbl.Text = "Search";
            // 
            // search_txt
            // 
            search_txt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_txt.Location = new Point(611, 117);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(170, 23);
            search_txt.TabIndex = 6;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // PhoneContactSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(search_lbl);
            Controls.Add(search_txt);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(head_lbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 550);
            Name = "PhoneContactSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhoneContactSystem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label head_lbl;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label address_lbl;
        private Label phone_lbl;
        private Label name_lbl;
        private Label id_lbl;
        private TextBox address_txt;
        private TextBox phone_txt;
        private TextBox name_txt;
        private TextBox id_txt;
        private Button insert_btn;
        private Button all_btn;
        private Button by_id_btn;
        private Button delete_btn;
        private Button update_btn;
        private DataGridView dataGridView;
        private Label search_lbl;
        private TextBox search_txt;
    }
}
