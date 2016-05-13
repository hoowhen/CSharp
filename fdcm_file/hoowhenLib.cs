using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CLib
{
    public class HoowhenLib
    {
        private bool _isopen = false;

        public HoowhenLib(Log4C.Log4COutput lo) : this(lo, Log4C.Log4CPriorityLevelType.Log4CPriorityWarn) { }
        public HoowhenLib(Log4C.Log4COutput lo, Log4C.Log4CPriorityLevelType pri)
        {
            if (_isopen)
            {
                Log4C.log_close();
            }

            Log4C.set_m_output(lo, pri);
            Log4C.log_open(Log4C.OutputCategoryName);
            _isopen = true;
        }

        public static class Pub
        {
            public enum Systype
            {
                SysLinux = 0,
                SysWindows,
                SysUnknown,
            }
        }
        public static class GeneralLib
        {
            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "get_systype",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern Pub.Systype get_systype(string sy);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_get_filelist",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_get_filelist(IntPtr[] list, string dir, Pub.Systype remote_systype, string ip, int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_filelist_init",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_filelist_init(string dir, Pub.Systype remote_systype, string ip, int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_filelist_read",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern string sg_filelist_read(int idx);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_filelist_free",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern void sg_filelist_free(int idx);
        }
        public static class Log4C
        {
            public const string PipeCategoryName = "hoowhen.pipe";
            public const string StreamCategoryName = "hoowhen.stream";
            public const string OutputCategoryName = "hoowhen.output";
            public enum Log4CPriorityLevelType
            {
                /** error */
                Log4CPriorityError = 300,
                /** warn */
                Log4CPriorityWarn = 400,
                /** notice */
                Log4CPriorityNotice = 500,
                /** info */
                Log4CPriorityInfo = 600,
                /** debug */
                Log4CPriorityDebug = 700,
                /** trace */
                Log4CPriorityTrace = 800,
            };
            [DllImport("liblog4c.dll",
                EntryPoint = "set_m_pipe",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_m_pipe(string pipename, Log4CPriorityLevelType a_priority);
            public delegate int Log4COutput(string info);
            [DllImport("liblog4c.dll",
                EntryPoint = "set_m_output",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_m_output(Log4COutput m_output, Log4CPriorityLevelType a_priority);

            [DllImport("liblog4c.dll",
                EntryPoint = "log_open",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern void log_open(string strCategory);
            [DllImport("liblog4c.dll",
                EntryPoint = "log_close",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int log_close();
            [DllImport("liblog4c.dll",
                EntryPoint = "m_log4c_log",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern void m_log4c_log(
                Log4CPriorityLevelType priority,
                string format,
                __arglist);
            [DllImport("liblog4c.dll",
             EntryPoint = "m_log4c_log",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.Cdecl)]
            public static extern void m_log4c_log(
                Log4CPriorityLevelType priority,
                string format);
        }
        public static class FdcmClient
        {
            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_get_env",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_get_env(
                string envname,
                StringBuilder envvlu,
                string ip,
                int port);
            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_get_file",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_get_file(
                string filename,
                string localdir,
                string remotedir,
                Pub.Systype remoteSystype,
                string ip, int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_put_file",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_put_file(
                string filename,
                string localdir,
                string remotedir,
                Pub.Systype remoteSystype,
                string ip,
                int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_get_file_sysline",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_get_file_sysline(
                string filename,
                string localdir,
                string remotedir,
                Pub.Systype remoteSystype,
                string ip,
                int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_put_file",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_put_file_sysline(
                string filename,
                string localdir,
                string remotedir,
                Pub.Systype remoteSystype,
                string ip,
                int port);

            [DllImport("sp_hoowhen_lib.dll",
                EntryPoint = "sg_fdcm_send_cmd",
                CharSet = CharSet.Ansi,
                CallingConvention = CallingConvention.Cdecl)]
            public static extern int sg_fdcm_send_cmd(
                string cmd,
                string ip,
                int port);
        }
    }
}
