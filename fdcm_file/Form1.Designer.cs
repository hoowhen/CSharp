using System.Windows.Forms;
namespace fdcm_file
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_linech = new System.Windows.Forms.CheckBox();
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.txtb_localpath = new System.Windows.Forms.TextBox();
            this.txtb_remotepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_put = new System.Windows.Forms.Button();
            this.txtb_filename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_linux = new System.Windows.Forms.RadioButton();
            this.rb_windows = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_get = new System.Windows.Forms.RadioButton();
            this.rb_put = new System.Windows.Forms.RadioButton();
            this.cbo_port = new System.Windows.Forms.ComboBox();
            this.cbo_ip = new System.Windows.Forms.ComboBox();
            this.btn_re_fl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_lc_fl = new System.Windows.Forms.Button();
            this.txtbout = new System.Windows.Forms.TextBox();
            this.cboDebug = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_linech
            // 
            this.cb_linech.AutoSize = true;
            this.cb_linech.Checked = true;
            this.cb_linech.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_linech.Location = new System.Drawing.Point(276, 241);
            this.cb_linech.Name = "cb_linech";
            this.cb_linech.Size = new System.Drawing.Size(84, 16);
            this.cb_linech.TabIndex = 7;
            this.cb_linech.Text = "换行符转换";
            this.cb_linech.UseVisualStyleBackColor = true;
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(256, 13);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(115, 23);
            this.btn_selectfile.TabIndex = 1;
            this.btn_selectfile.Text = "选择文件";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // txtb_localpath
            // 
            this.txtb_localpath.Location = new System.Drawing.Point(67, 106);
            this.txtb_localpath.Name = "txtb_localpath";
            this.txtb_localpath.Size = new System.Drawing.Size(305, 21);
            this.txtb_localpath.TabIndex = 3;
            this.txtb_localpath.TabStop = false;
            // 
            // txtb_remotepath
            // 
            this.txtb_remotepath.Location = new System.Drawing.Point(67, 178);
            this.txtb_remotepath.Name = "txtb_remotepath";
            this.txtb_remotepath.Size = new System.Drawing.Size(305, 21);
            this.txtb_remotepath.TabIndex = 3;
            this.txtb_remotepath.Text = "$(richisland_home)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "本地路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "远程路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // btn_put
            // 
            this.btn_put.Location = new System.Drawing.Point(186, 275);
            this.btn_put.Name = "btn_put";
            this.btn_put.Size = new System.Drawing.Size(188, 23);
            this.btn_put.TabIndex = 8;
            this.btn_put.Text = "发送/获取文件";
            this.btn_put.UseVisualStyleBackColor = true;
            this.btn_put.Click += new System.EventHandler(this.btn_put_Click);
            // 
            // txtb_filename
            // 
            this.txtb_filename.Location = new System.Drawing.Point(67, 69);
            this.txtb_filename.Name = "txtb_filename";
            this.txtb_filename.Size = new System.Drawing.Size(305, 21);
            this.txtb_filename.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "文件名";
            // 
            // rb_linux
            // 
            this.rb_linux.AutoSize = true;
            this.rb_linux.Checked = true;
            this.rb_linux.Location = new System.Drawing.Point(6, 20);
            this.rb_linux.Name = "rb_linux";
            this.rb_linux.Size = new System.Drawing.Size(53, 16);
            this.rb_linux.TabIndex = 6;
            this.rb_linux.TabStop = true;
            this.rb_linux.Text = "linux";
            this.rb_linux.UseVisualStyleBackColor = true;
            this.rb_linux.CheckedChanged += new System.EventHandler(this.rb_system_CheckedChange);
            // 
            // rb_windows
            // 
            this.rb_windows.AutoSize = true;
            this.rb_windows.Location = new System.Drawing.Point(77, 21);
            this.rb_windows.Name = "rb_windows";
            this.rb_windows.Size = new System.Drawing.Size(65, 16);
            this.rb_windows.TabIndex = 6;
            this.rb_windows.Text = "windows";
            this.rb_windows.UseVisualStyleBackColor = true;
            this.rb_windows.CheckedChanged += new System.EventHandler(this.rb_system_CheckedChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_linux);
            this.groupBox1.Controls.Add(this.rb_windows);
            this.groupBox1.Location = new System.Drawing.Point(69, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "远程系统类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_get);
            this.groupBox2.Controls.Add(this.rb_put);
            this.groupBox2.Location = new System.Drawing.Point(67, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送/获取文件";
            // 
            // rb_get
            // 
            this.rb_get.AutoSize = true;
            this.rb_get.Location = new System.Drawing.Point(79, 23);
            this.rb_get.Name = "rb_get";
            this.rb_get.Size = new System.Drawing.Size(47, 16);
            this.rb_get.TabIndex = 0;
            this.rb_get.Text = "获取";
            this.rb_get.UseVisualStyleBackColor = true;
            this.rb_get.CheckedChanged += new System.EventHandler(this.rb_pg_CheckedChanged);
            // 
            // rb_put
            // 
            this.rb_put.AutoSize = true;
            this.rb_put.Checked = true;
            this.rb_put.Location = new System.Drawing.Point(8, 23);
            this.rb_put.Name = "rb_put";
            this.rb_put.Size = new System.Drawing.Size(47, 16);
            this.rb_put.TabIndex = 0;
            this.rb_put.TabStop = true;
            this.rb_put.Text = "发送";
            this.rb_put.UseVisualStyleBackColor = true;
            this.rb_put.CheckedChanged += new System.EventHandler(this.rb_pg_CheckedChanged);
            // 
            // cbo_port
            // 
            this.cbo_port.FormattingEnabled = true;
            this.cbo_port.Items.AddRange(new object[] {
            "7268",
            "7230"});
            this.cbo_port.Location = new System.Drawing.Point(302, 144);
            this.cbo_port.Name = "cbo_port";
            this.cbo_port.Size = new System.Drawing.Size(70, 20);
            this.cbo_port.TabIndex = 5;
            this.cbo_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_port_KeyPress);
            this.cbo_port.Leave += new System.EventHandler(this.cbo_port_Leave);
            // 
            // cbo_ip
            // 
            this.cbo_ip.FormattingEnabled = true;
            this.cbo_ip.Items.AddRange(new object[] {
            "128.0.1.222",
            "192.168.20.127"});
            this.cbo_ip.Location = new System.Drawing.Point(67, 144);
            this.cbo_ip.Name = "cbo_ip";
            this.cbo_ip.Size = new System.Drawing.Size(210, 20);
            this.cbo_ip.TabIndex = 4;
            // 
            // btn_re_fl
            // 
            this.btn_re_fl.Location = new System.Drawing.Point(256, 205);
            this.btn_re_fl.Name = "btn_re_fl";
            this.btn_re_fl.Size = new System.Drawing.Size(115, 23);
            this.btn_re_fl.TabIndex = 12;
            this.btn_re_fl.Text = "获取远程文件列表";
            this.btn_re_fl.UseVisualStyleBackColor = true;
            this.btn_re_fl.Click += new System.EventHandler(this.btn_fl_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(401, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 292);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_lc_fl
            // 
            this.btn_lc_fl.Location = new System.Drawing.Point(256, 40);
            this.btn_lc_fl.Name = "btn_lc_fl";
            this.btn_lc_fl.Size = new System.Drawing.Size(115, 23);
            this.btn_lc_fl.TabIndex = 12;
            this.btn_lc_fl.Text = "获取本地文件列表";
            this.btn_lc_fl.UseVisualStyleBackColor = true;
            this.btn_lc_fl.Click += new System.EventHandler(this.btn_lc_fl_Click);
            // 
            // txtbout
            // 
            this.txtbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbout.Location = new System.Drawing.Point(14, 322);
            this.txtbout.Multiline = true;
            this.txtbout.Name = "txtbout";
            this.txtbout.ReadOnly = true;
            this.txtbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbout.Size = new System.Drawing.Size(606, 98);
            this.txtbout.TabIndex = 14;
            // 
            // cboDebug
            // 
            this.cboDebug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebug.FormattingEnabled = true;
            this.cboDebug.Location = new System.Drawing.Point(14, 275);
            this.cboDebug.Name = "cboDebug";
            this.cboDebug.Size = new System.Drawing.Size(155, 20);
            this.cboDebug.TabIndex = 15;
            this.cboDebug.SelectedIndexChanged += new System.EventHandler(this.cboDebug_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 432);
            this.Controls.Add(this.cboDebug);
            this.Controls.Add(this.txtbout);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_lc_fl);
            this.Controls.Add(this.btn_re_fl);
            this.Controls.Add(this.cbo_ip);
            this.Controls.Add(this.cbo_port);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_remotepath);
            this.Controls.Add(this.txtb_filename);
            this.Controls.Add(this.txtb_localpath);
            this.Controls.Add(this.btn_selectfile);
            this.Controls.Add(this.btn_put);
            this.Controls.Add(this.cb_linech);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_linech;
        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.TextBox txtb_localpath;
        private System.Windows.Forms.TextBox txtb_remotepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_put;
        private System.Windows.Forms.TextBox txtb_filename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_linux;
        private System.Windows.Forms.RadioButton rb_windows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_get;
        private System.Windows.Forms.RadioButton rb_put;
        private System.Windows.Forms.ComboBox cbo_port;
        private System.Windows.Forms.ComboBox cbo_ip;
        private System.Windows.Forms.Button btn_re_fl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_lc_fl;
        private System.Windows.Forms.TextBox txtbout;
        private ComboBox cboDebug;
    }
}

