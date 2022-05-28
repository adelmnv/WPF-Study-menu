using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IView
    {
        string TextBox { get; set; }
        string ImgName { get; set; }
        string ChangedImg { get; set; }

        void HomeB();
        void EmailB();
        void CloudB();
        void HomeI();
        void EmailI();
        void CloudI();
    }
}
