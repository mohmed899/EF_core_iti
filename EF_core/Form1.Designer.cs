namespace EF_core
{
    partial class Form1
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
            this.dvg_context = new System.Windows.Forms.DataGridView();
            this.txt_posttitle = new System.Windows.Forms.TextBox();
            this.txt_postbody = new System.Windows.Forms.TextBox();
            this.txt_posttime = new System.Windows.Forms.TextBox();
            this.combo_author = new System.Windows.Forms.ComboBox();
            this.combo_blog = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_context)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_context
            // 
            this.dvg_context.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_context.Location = new System.Drawing.Point(12, 242);
            this.dvg_context.Name = "dvg_context";
            this.dvg_context.RowTemplate.Height = 25;
            this.dvg_context.Size = new System.Drawing.Size(471, 196);
            this.dvg_context.TabIndex = 0;
            this.dvg_context.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvg_context_RowHeaderMouseDoubleClick);
            // 
            // txt_posttitle
            // 
            this.txt_posttitle.Location = new System.Drawing.Point(499, 55);
            this.txt_posttitle.Name = "txt_posttitle";
            this.txt_posttitle.Size = new System.Drawing.Size(142, 23);
            this.txt_posttitle.TabIndex = 1;
            // 
            // txt_postbody
            // 
            this.txt_postbody.Location = new System.Drawing.Point(499, 153);
            this.txt_postbody.Multiline = true;
            this.txt_postbody.Name = "txt_postbody";
            this.txt_postbody.Size = new System.Drawing.Size(142, 23);
            this.txt_postbody.TabIndex = 2;
            // 
            // txt_posttime
            // 
            this.txt_posttime.Location = new System.Drawing.Point(499, 190);
            this.txt_posttime.Name = "txt_posttime";
            this.txt_posttime.Size = new System.Drawing.Size(142, 23);
            this.txt_posttime.TabIndex = 3;
            // 
            // combo_author
            // 
            this.combo_author.FormattingEnabled = true;
            this.combo_author.Location = new System.Drawing.Point(499, 113);
            this.combo_author.Name = "combo_author";
            this.combo_author.Size = new System.Drawing.Size(142, 23);
            this.combo_author.TabIndex = 4;
            // 
            // combo_blog
            // 
            this.combo_blog.FormattingEnabled = true;
            this.combo_blog.Location = new System.Drawing.Point(499, 84);
            this.combo_blog.Name = "combo_blog";
            this.combo_blog.Size = new System.Drawing.Size(142, 23);
            this.combo_blog.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(713, 262);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(511, 262);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(610, 262);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "body";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "BlogName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Auther Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.combo_blog);
            this.Controls.Add(this.combo_author);
            this.Controls.Add(this.txt_posttime);
            this.Controls.Add(this.txt_postbody);
            this.Controls.Add(this.txt_posttitle);
            this.Controls.Add(this.dvg_context);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_context)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dvg_context;
        private TextBox txt_posttitle;
        private TextBox txt_postbody;
        private TextBox txt_posttime;
        private ComboBox combo_author;
        private ComboBox combo_blog;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}