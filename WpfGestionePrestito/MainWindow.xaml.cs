using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGestionePrestito
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

        private void btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            string nascita;
            string nome = txt_nome.Text;
            string cognome = txt_cognome.Text;
            if (RadioButton_M.IsChecked == true)
            {
                nascita = "nato il";
            }
            else
            {
                nascita = "nata il";
            }
            double importo = double.Parse(txt_importoRichiesto.Text);
            double rata = double.Parse(txt_rate.Text);
            double percentuale = double.Parse(txt_percentuale.Text);
            double importoRestituire = importo * percentuale / 100;
            double importoRata = importoRestituire / rata;
            txt_importoRestituire.Text = importoRestituire.ToString();
            txt_importoRate.Text = importoRata.ToString();
            lbl_ris.Content = $"{nome} {cognome} residente in {cmb_residenza.Text} {nascita} {datapicker_data.Text} prestito di {importo}€ ad un tasso del {percentuale}% \n da restituire in {rata} da {importoRata}€ ciascuna, per un totale di {importoRestituire}€";
        }

        private void btn_nuovo_Click(object sender, RoutedEventArgs e)
        {
            txt_nome.Clear();
            txt_cognome.Clear();
            txt_rate.Clear();
            txt_importoRichiesto.Clear();
            txt_percentuale.Clear();
            txt_importoRestituire.Clear();
            txt_importoRate.Clear();
            datapicker_data.SelectedDate = null;
            cmb_residenza.SelectedItem = null;
            RadioButton_F.IsChecked = false;
            RadioButton_M.IsChecked = false;
        }

        private void btn_stampa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
