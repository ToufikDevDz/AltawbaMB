//هام
//الأكواد المقتبسة من المواقع سواء بتصرف أو بدونه مكتوبة بين شولتين (//"  //") ومصادرها مذكورة في آخر الصفحة 
//حذار من روابط المصادر، فقد تحتوي على صور النساء، ننصحك بحجب الصور في المتصفح قبل الدخول إليها

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace AltawbaMB
{
    public partial class AltawbaMB : Form
    {
        public AltawbaMB()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //إيقاف تشغيل البرامج كل 5 ثواني
            //Tor Browser إيقاف تشغيل متصفح
            //"
            foreach (var process in Process.GetProcessesByName("tor"))
            {
                process.Kill();
            } //" م1 بتصرف

            //Baidu (Spark) Browser إيقاف تشغيل متصفح
            foreach (var process2 in Process.GetProcessesByName("spark"))
            {
                process2.Kill();
            }
        }

        private void AltawbaMB_Activated(object sender, EventArgs e)
        {
            //alt+tab لإخفاء البرنامج من قائمة 
            //ومن مدير المهام أقل التفاصيل؟ ومن قائمة طريقة عرض المهمة في ويندوز 10
            Hide();

            //ليعمل جيدا اترك الميزة
            //WindowState = Normal
        }
    }
}

//مصادر أكواد البرنامج

    //المصدر م1
    //ConsultUtah, Stack Overflow, https://stackoverflow.com/a/3345421, 
    //CC BY-SA 4.0, https://creativecommons.org/licenses/by-sa/4.0/