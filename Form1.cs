using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using QuickType;
using System.Text.Json;
using System.Text.Json.Serialization;

//usando el NuGet Newtwonsoft.json



namespace Estructuras1Lab1
{
    public partial class Form1 : Form
    {
        public class inputsss
        {
            public Dictionary<String, bool>[] input1 { get; set; }
            public String[] input2 { get; set; }
        }
        public class Apt
        {
            public bool Academy { get; set; }
            public bool Gym { get; set; }
            public bool Grocery { get; set; }
            public bool Pharmacy { get; set; }
            public bool Restaurant { get; set; }
            public bool Beauty_salon { get; set; }
            public bool Vet { get; set; }
            public bool Hospital { get; set; }
            public bool Clinic { get; set; }
            public bool Mall { get; set; }
            public bool Gas_Station { get; set; }
            public bool Kindergarten { get; set; }
            public bool Park { get; set; }
            public bool Cofee_shop { get; set; }
            public bool Barber_Shop { get; set; }
        }
        //public class Inputsss
        //{
        //    public Dictionary<string, bool> entrada { get; set; }
        //    public Dictionary<string, bool> entrada2 { get; set; }
        //}
        public Form1()
        {
            InitializeComponent();
        }

        private void button_leer_Click(object sender, EventArgs e)
        {
            //limitar los archivos que se pueden abrir
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //String jsonString = openFileDialog1.FileName;
                String texto = File.ReadAllText(openFileDialog1.FileName);
                int puesto = 0;
                int ganador = 0;
                int evaluado = 0;
               // var welcome = Welcome.FromJson(jsonString);
                label_test.Text = texto;
                //guardar datos seleccionados
                bool bar = checkedListBox1.GetItemChecked(0);
                bool cafe = checkedListBox1.GetItemChecked(1);
                bool hospital = checkedListBox1.GetItemChecked(2);
                bool kinder = checkedListBox1.GetItemChecked(3);
                bool vets = checkedListBox1.GetItemChecked(4);
                bool panaderia = checkedListBox1.GetItemChecked(5);
                bool mall = checkedListBox1.GetItemChecked(6);
                bool salon = checkedListBox1.GetItemChecked(7);
                bool farmacia = checkedListBox1.GetItemChecked(8);
                bool gimanisum = checkedListBox1.GetItemChecked(9);
                bool tienda = checkedListBox1.GetItemChecked(10);
                bool restaurant = checkedListBox1.GetItemChecked(11);
                bool barberia = checkedListBox1.GetItemChecked(12);
                bool clinic = checkedListBox1.GetItemChecked(13);
                bool miselanea = checkedListBox1.GetItemChecked(14);
                bool gas = checkedListBox1.GetItemChecked(15);
                inputsss inputs = JsonSerializer.Deserialize<inputsss>(texto);
                foreach (Dictionary<String, bool> map in inputs.input1)
                {
                    label_test.Text = label_test.Text + ($"Apartamento: {puesto}") + "\n";
                    foreach(KeyValuePair<String, bool> entry in map)
                    {
                        label_test.Text = label_test.Text + ($"Key {entry.Key} - vaulue {entry.Value}") + "\n";
                        if ((entry.Key == "Bar" && bar == entry.Value)
                            || (entry.Key == "CofeeShop" && entry.Value == cafe)
                            || (entry.Key == "Hospital" && entry.Value == hospital)
                            || (entry.Key == "Kindergarten" && entry.Value == kinder)
                            || (entry.Key == "Vet" && entry.Value == vets)
                            || (entry.Key == "Backery" && entry.Value == panaderia)
                            || (entry.Key == "Mall" && entry.Value == mall)
                            || (entry.Key == "Salon" && entry.Value == salon)
                            || (entry.Key == "Pharmacy" && entry.Value == farmacia)
                            || (entry.Key == "Gym" && entry.Value == gimanisum)
                            || (entry.Key == "Store" && entry.Value == tienda)
                            || (entry.Key == "Restaurant" && entry.Value == restaurant)
                            || (entry.Key == "BarberShop" && entry.Value == barberia)
                            || (entry.Key == "Clinic" && entry.Value == clinic)
                            || (entry.Key == "GroceryStore" && entry.Value == miselanea)
                            || (entry.Key == "GasStation" && entry.Value == gas))
                        {
                            evaluado++;
                        }
                    }
                    puesto++;

                }


                //foreach (QuickType.Welcome w in welcome)
               /* {
                    texto = Convert.ToString(w.Bakery);
                    texto= texto + "\n" + Convert.ToString(w.Vet);
                    texto = texto + "\n" + Convert.ToString(w.Kindergarten);
                    texto = texto + "\n" + Convert.ToString(w.CofeeShop);
                    texto = texto + "\n" + Convert.ToString(w.Bakery);
                    texto = texto + "\n" + Convert.ToString(w.Bar);
                    texto = texto + "\n" + Convert.ToString(w.Hospital);
                }*/
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
