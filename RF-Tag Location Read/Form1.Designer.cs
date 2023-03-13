namespace RF_Tag_Location_Read
{
    partial class Form1
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
            this.cmd_start = new System.Windows.Forms.Button();
            this.cmd_stop = new System.Windows.Forms.Button();
            this.lst_Tags = new System.Windows.Forms.ListView();
            this.clm_epc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_TagsTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_start
            // 
            this.cmd_start.Location = new System.Drawing.Point(12, 12);
            this.cmd_start.Name = "cmd_start";
            this.cmd_start.Size = new System.Drawing.Size(75, 23);
            this.cmd_start.TabIndex = 0;
            this.cmd_start.Text = "Start";
            this.cmd_start.UseVisualStyleBackColor = true;
            this.cmd_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_stop
            // 
            this.cmd_stop.Location = new System.Drawing.Point(106, 12);
            this.cmd_stop.Name = "cmd_stop";
            this.cmd_stop.Size = new System.Drawing.Size(75, 23);
            this.cmd_stop.TabIndex = 2;
            this.cmd_stop.Text = "Stop";
            this.cmd_stop.UseVisualStyleBackColor = true;
            this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
            // 
            // lst_Tags
            // 
            this.lst_Tags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_epc,
            this.clm_x,
            this.clm_y,
            this.clm_z,
            this.clm_count});
            this.lst_Tags.GridLines = true;
            this.lst_Tags.HideSelection = false;
            this.lst_Tags.Location = new System.Drawing.Point(12, 56);
            this.lst_Tags.MultiSelect = false;
            this.lst_Tags.Name = "lst_Tags";
            this.lst_Tags.Size = new System.Drawing.Size(587, 832);
            this.lst_Tags.TabIndex = 3;
            this.lst_Tags.UseCompatibleStateImageBehavior = false;
            this.lst_Tags.View = System.Windows.Forms.View.Details;
            // 
            // clm_epc
            // 
            this.clm_epc.Text = "EPC";
            this.clm_epc.Width = 181;
            // 
            // clm_x
            // 
            this.clm_x.Text = "x";
            this.clm_x.Width = 86;
            // 
            // clm_y
            // 
            this.clm_y.Text = "y";
            this.clm_y.Width = 93;
            // 
            // clm_z
            // 
            this.clm_z.Text = "z";
            this.clm_z.Width = 93;
            // 
            // clm_count
            // 
            this.clm_count.Text = "Count";
            // 
            // lbl_TagsTotal
            // 
            this.lbl_TagsTotal.AutoSize = true;
            this.lbl_TagsTotal.Location = new System.Drawing.Point(367, 22);
            this.lbl_TagsTotal.Name = "lbl_TagsTotal";
            this.lbl_TagsTotal.Size = new System.Drawing.Size(16, 13);
            this.lbl_TagsTotal.TabIndex = 4;
            this.lbl_TagsTotal.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Tags";
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(632, 56);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_out.Size = new System.Drawing.Size(1306, 832);
            this.txt_out.TabIndex = 6;
            this.txt_out.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 900);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TagsTotal);
            this.Controls.Add(this.lst_Tags);
            this.Controls.Add(this.cmd_stop);
            this.Controls.Add(this.cmd_start);
            this.Name = "Form1";
            this.Text = "Tag Locations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_start;
        private System.Windows.Forms.Button cmd_stop;
        private System.Windows.Forms.ListView lst_Tags;
        private System.Windows.Forms.ColumnHeader clm_epc;
        private System.Windows.Forms.ColumnHeader clm_x;
        private System.Windows.Forms.ColumnHeader clm_y;
        private System.Windows.Forms.ColumnHeader clm_z;
        private System.Windows.Forms.ColumnHeader clm_count;
        private System.Windows.Forms.Label lbl_TagsTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_out;
    }
}

