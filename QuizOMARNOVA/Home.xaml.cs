using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizOMARNOVA
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        List<String> results = new List<string>();
        public Home()
        {
            InitializeComponent();
            Pago.Items.Add("Credit or Debit card");
            Pago.Items.Add("Paypal");
            Pago.Items.Add("Nequi");
            Pago.Items.Add("Efecty");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            results.Add(txtGameName.Text);
            results.Add(Pago.Text);
            if (gift.IsChecked==true)
            {
                results.Add(gift.Content.ToString());
            }

            results.Add(calendario.ToString());

            
            
            txtResults.Text = String.Join(Environment.NewLine, results);

            
        }

      
    }
}
