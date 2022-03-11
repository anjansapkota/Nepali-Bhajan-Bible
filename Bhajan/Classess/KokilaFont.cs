using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bhajan.Classess
{
    internal class KokilaFont
    {
        public static PrivateFontCollection pfc = new PrivateFontCollection();
        public KokilaFont()
        {
            string appfolder;
            if (AppDomain.CurrentDomain.BaseDirectory.ToUpper().Contains("RELEASE"))
            {
                appfolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Release\\", "");
            }
            else
            {
                appfolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "");
            }
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            var k = (byte[])(File.ReadAllBytes(appfolder + "kokila.ttf"));
            IntPtr data = Marshal.AllocCoTaskMem(k.Length); // Very important.
            Marshal.Copy(k, 0, data, k.Length);
            pfc.AddMemoryFont(data, k.Length); // Your own collection of fonts here.
            Marshal.FreeCoTaskMem(data); // Very important.
            //unsafe
            //{
            //    fixed (byte* pFontData = k)
            //    {
            //        pfc.AddMemoryFont((System.IntPtr)pFontData, k.Length);
            //    }
            //}
        }

        public static FontFamily GetKokila()
        {
            return pfc.Families[0];
        }
    }
}
