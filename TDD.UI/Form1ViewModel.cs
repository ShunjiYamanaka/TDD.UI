using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Form1ViewModel
    {
        //private System.Windows.Forms.TextBox ATextBox;
        //private System.Windows.Forms.TextBox BTextBox;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label ResultLabel;

        //画面のプロパティを定義する
        public string ATextBoxText { get; set; } = string.Empty;
        public string BTextBoxText { get; set; } = string.Empty;
        public string ResultLabelText { get; set; } = string.Empty;
    }
}
