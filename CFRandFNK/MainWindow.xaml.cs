using System;
using System.Windows;

namespace CFRandFNK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] cfrChar = CFR.Text.ToCharArray();
            for (int i = 0; i < cfrChar.Length; i++)
            {
                if (cfrChar[i] == '.')
                {
                    cfrChar[i] = ',';
                }
            }
            CFR.Text = new string(cfrChar);
            double cfr = Convert.ToDouble(CFR.Text);

            char[] fnkChar = FNK.Text.ToCharArray();
            for (int i = 0; i < fnkChar.Length; i++)
            {
                if (fnkChar[i] == '.')
                {
                    fnkChar[i] = ',';
                }
            }
            FNK.Text = new string(fnkChar);
            double fnk = Convert.ToDouble(FNK.Text);

            double calc = (cfr * 0.03 + 10) / fnk;

            Result.Text = $"Вам пришло FNK по цене {calc:f5}";
        }
    }
}