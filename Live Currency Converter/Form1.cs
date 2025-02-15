using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CurrencyConverter=Live_Currency_Converter.CurrencyConverter;
namespace Live_Currency_Converter
{
    public partial class Form1 : Form
    {
        CurrencyConverter converter;
        public Form1()
        {
            InitializeComponent();
            converter = new CurrencyConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> symbolData = converter.GetSymbols();
            fromcomboBox.Items.Clear();
            tocomboBox.Items.Clear();

            fromcomboBox.DataSource = new BindingSource(symbolData, null);
            fromcomboBox.DisplayMember = "Value";
            fromcomboBox.ValueMember = "Key";

            tocomboBox.DataSource = new BindingSource(symbolData, null);
            tocomboBox.DisplayMember = "Value";
            tocomboBox.ValueMember = "Key";
        }

        private void convert_Click(object sender, EventArgs e)
        {
            string fromCurrency=((KeyValuePair<string, string>)fromcomboBox.SelectedItem).Key;
            string toCurrency=((KeyValuePair<string, string>)tocomboBox.SelectedItem).Key;
             //fromCurrency = "USD"; 
             //toCurrency = "EUR";
            double currencyAmount=double.Parse(fromtextBox.Text);
            double finalValue = converter.Convert(fromCurrency,toCurrency,currencyAmount);
            TotextBox.Text = finalValue.ToString(); 
        }
    }
}
