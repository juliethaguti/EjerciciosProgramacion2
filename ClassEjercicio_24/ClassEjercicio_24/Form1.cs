using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEjercicio_21;

namespace ClassEjercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double fahrenheit;
            double.TryParse(this.txtFahrenheit.Text, out fahrenheit);
            Fahrenheit temperatura = new Fahrenheit(fahrenheit);
            txtFahrenheitAFahrenheit.Text = temperatura.GetTemperatura().ToString();

            Celsius fahrenheitACelsius = (Celsius)temperatura;
            this.txtFahrenheitACelsius.Text = fahrenheitACelsius.GetTemperatura().ToString();

            Kelvin fahrenheitAKelvin = (Kelvin)temperatura;
            this.txtFahrenhitAKelvin.Text = fahrenheitAKelvin.GetTemperatura().ToString();
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            double celsius;
            double.TryParse(this.txtCelsius.Text, out celsius);
            Celsius temperatura = new Celsius(celsius);
            this.txtCelsiusACelsius.Text = temperatura.GetTemperatura().ToString();

            Fahrenheit celsiusAFahrenheit = (Fahrenheit)temperatura;
            this.txtCelsiusAFahrenheit.Text = celsiusAFahrenheit.GetTemperatura().ToString();

            Kelvin celsiusAKelvin = (Kelvin)temperatura;
            this.txtCelsiusAKelvin.Text = celsiusAKelvin.GetTemperatura().ToString();
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double kelvin;
            double.TryParse(this.txtKelvin.Text, out kelvin);
            Kelvin temperatura = new Kelvin(kelvin);
            this.txtKelvinAKelvin.Text = temperatura.GetTemperatura().ToString();

            Fahrenheit celsiusAKelvin = (Fahrenheit)temperatura;
            this.txtKelvinAFarenhit.Text = celsiusAKelvin.GetTemperatura().ToString();

            Celsius kelvinACelsius = (Celsius)temperatura;
            this.txtKelvinACelsius.Text = kelvinACelsius.GetTemperatura().ToString();
        }
    }
}
