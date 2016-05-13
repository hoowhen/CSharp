using CLib;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace fdcm_file
{
    public partial class Form1 : Form
    {
        #region Public Constructors

        public Form1()
        {
            InitializeComponent();

            
        }

        #endregion Public Constructors



        #region Private Methods

        private int dbg_out(string info)
        {
            txtbout.AppendText(info);
            return info.Length;
        }

        private void Init()
        {
            cbo_port.SelectedIndex = 0;
            cbo_ip.SelectedIndex = 0;
            rb_put.Checked = true;
            rb_linux.Checked = true;
            cb_linech.Checked = true;
            foreach (var s in Enum.GetNames(typeof(HoowhenLib.Log4C.Log4CPriorityLevelType)))
            {
                cboDebug.Items.Add(s);
            }
            cboDebug.SelectedIndex = 1;
            _hl = new HoowhenLib(dbg_out, HoowhenLib.Log4C.Log4CPriorityLevelType.Log4CPriorityWarn);
        }

        #endregion Private Methods

        private HoowhenLib _hl;
        private int _pg;
        private HoowhenLib.Pub.Systype _sy;

        private void btn_fl_Click(object sender, EventArgs e)
        {
            var port = Convert.ToInt32(cbo_port.Text);
            var path = txtb_remotepath.Text;
            var ip = cbo_ip.Text;
            get_file_list(_sy, path, ip, port);
        }

        private void btn_lc_fl_Click(object sender, EventArgs e)
        {
            string path = txtb_localpath.Text;
            get_file_list(HoowhenLib.Pub.Systype.SysWindows, path, null, 0);
        }

        //0 put,1 get
        private void btn_put_Click(object sender, EventArgs e)
        {
            int filelen = 0;
            if (_pg == 0)
            {
                if (cb_linech.Checked == false)
                    filelen = HoowhenLib.FdcmClient.sg_fdcm_put_file(txtb_filename.Text,
                    txtb_localpath.Text,
                    txtb_remotepath.Text,
                    _sy,
                    cbo_ip.Text,
                    Convert.ToInt32(cbo_port.SelectedItem.ToString()));
                else
                    filelen = HoowhenLib.FdcmClient.sg_fdcm_put_file_sysline(txtb_filename.Text,
                    txtb_localpath.Text,
                    txtb_remotepath.Text,
                    _sy,
                    cbo_ip.Text,
                    Convert.ToInt32(cbo_port.SelectedItem.ToString()));
            }
            else
            {
                if (cb_linech.Checked == false)
                    filelen = HoowhenLib.FdcmClient.sg_fdcm_get_file(txtb_filename.Text,
                    txtb_localpath.Text,
                    txtb_remotepath.Text,
                    _sy,
                    cbo_ip.Text,
                    Convert.ToInt32(cbo_port.SelectedItem.ToString()));
                else
                    filelen = HoowhenLib.FdcmClient.sg_fdcm_get_file_sysline(txtb_filename.Text,
                    txtb_localpath.Text,
                    txtb_remotepath.Text,
                    _sy,
                    cbo_ip.Text,
                    Convert.ToInt32(cbo_port.SelectedItem.ToString()));
            }
            MessageBox.Show(filelen >= 0 ? "put/get file successfully" : "put/get file failer");
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            if (_pg == 0)
            {
                //初始化一个OpenFileDialog类
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择文件";
                //判断用户是否正确的选择了文件
                if (fileDialog.ShowDialog() != DialogResult.OK) return;
                this.txtb_localpath.Text = System.IO.Path.GetDirectoryName(fileDialog.FileName);
                this.txtb_filename.Text = fileDialog.SafeFileName;
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog {Description = "请选择文件路径"};
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtb_localpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void cbo_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void cbo_port_Leave(object sender, EventArgs e)
        {
            if (cbo_port.Text.Length == 0)
            {
                cbo_port.Text = "7268";
            }
        }

        private void get_file_list(HoowhenLib.Pub.Systype syp, string path, string ip, int port)
        {
            IntPtr[] iptr = new IntPtr[1024];
            this.listBox1.Items.Clear();
            HoowhenLib.GeneralLib.sg_get_filelist(iptr, path, syp, ip, port);
            string tmp = Marshal.PtrToStringAnsi(iptr[0]);
            int i = 0;

            while ((tmp = Marshal.PtrToStringAnsi(iptr[i])) != null)
            {
                this.listBox1.Items.AddRange(new object[] { tmp });
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtb_filename.Text = listBox1.Text;
        }

        private void rb_pg_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text)
            {
                case "发送":
                    _pg = 0;
                    btn_selectfile.Text = "选择文件";
                    break;
                case "获取":
                    _pg = 1;
                    btn_selectfile.Text = "选择文件路径";
                    break;
            }
        }

        private void rb_system_CheckedChange(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            _sy = HoowhenLib.GeneralLib.get_systype(((RadioButton)sender).Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void cboDebug_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hl = new HoowhenLib(dbg_out, (HoowhenLib.Log4C.Log4CPriorityLevelType)System.Enum.Parse(typeof(HoowhenLib.Log4C.Log4CPriorityLevelType),cboDebug.SelectedItem.ToString()));
        }
    }
}
