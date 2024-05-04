using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typograph
{
    public partial class Typograph : Form
    {
        public Typograph()
        {
            InitializeComponent();
        }

        
        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text;

            if (Rule1CheckBox.Checked)
            {
                // правило 1: знаки препинания слева слитно со словом
                inputText = Regex.Replace(inputText, @"(\w)([.,!?])", " $1$2");
            }
            if (Rule2CheckBox.Checked)
            {
                // правило 2: замена подряд идущих пробелов на один
                inputText = Regex.Replace(inputText, @"\s+", " ");
            }
            if (Rule3CheckBox.Checked)
            {
                // правило 3: дефис пишется слитно с частями слова или цифр
                inputText = Regex.Replace(inputText, @"(\S+)-(\S+)", "$1-$2");
            }
            if (Rule4CheckBox.Checked)
            {
                // правило 4: разделяем стандартные сокращения через пробел
                inputText = Regex.Replace(inputText, @"(\b[а-я]\.)\s*([а-я]\.)", "$1 $2");
            }
            if (Rule5CheckBox.Checked)
            {
                // правило 5: добавляем непереносимый пробел между тире и предыдущим словом
                inputText = Regex.Replace(inputText, @"(\S+)(\s+)?-(\s+)?(\S+)", "$1\u00A0-$4");
            }
            if (Rule6CheckBox.Checked)
            {
                // правило 6: делаем первую букву после точки заглавной
                inputText = Regex.Replace(inputText, @"(?<=\.)(\s*)(\w)", m => m.Value.ToUpper());
            }
            if (Rule7CheckBox.Checked)
            {
                // правило 7: после точки с запятой пробел
                inputText = Regex.Replace(inputText, @";", "; ");
            }

            OutputTextBox.Text = inputText; 
        }


    }
}
