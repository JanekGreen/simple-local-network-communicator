using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;
using System.Globalization;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private TcpClient klient = null;
        private BinaryReader czytaj = null;
        private BinaryWriter pisz = null;
        private StreamWriter piszDoPliku;
        private string nick;
        string tekst;
        private bool polaczono = false;
        public Form1()
        {
            InitializeComponent();

            piszDoPliku = new StreamWriter("log.txt_" + DateTime.Now.ToString("yyyyMMddTHHmmss"));
           
        }
        private void zapiszDoPliku(string tekst)
        {
            piszDoPliku.WriteLine(tekst);
            piszDoPliku.Flush();

        }

        public void dodajWiadomosc(RichTextBox rt, string w)
        {
            if (rt.InvokeRequired)
                rt.BeginInvoke(new Action<RichTextBox, string>(dodajWiadomosc), rt, w);
            else
                rt.AppendText(w + Environment.NewLine);


        }
        private void odbierzWiadomosc()
        {
            while (klient.Connected)
            {
                if (!klient.Connected)
                    return;

                tekst = czytaj.ReadString();
                if(tekst != String.Empty)
                {
                    dodajWiadomosc(richTextBox1, tekst);
                    zapiszDoPliku(tekst);

                }

            }
        }
        private void nawiazPolaczenie()
        {
            try
            {
               
                klient = new TcpClient();

                klient.Connect(new IPEndPoint(IPAddress.Parse(tAdres.Text), int.Parse(tPort.Text)));
               if(klient.Connected)
               {
                   dodajWiadomosc(richTextBox1, "Polaczono!");
                   NetworkStream stream = klient.GetStream();
                   pisz = new BinaryWriter(stream);
                   czytaj = new BinaryReader(stream);
                   Thread watekOdbioruWiadomosci = new Thread(odbierzWiadomosc);
                   watekOdbioruWiadomosci.Start();
                   polaczono = true;
                   return;

               }

            }
            catch (Exception e) { dodajWiadomosc(richTextBox1, "Coś poszło nie tak:" + e.Message); }

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (!polaczono)
            {
                if (tPort.Text == String.Empty && tAdres.Text == String.Empty)
                {
                    dodajWiadomosc(richTextBox1, "Numer portu i adres sa wymagane");
                    return;

                }
                if (textBox1.Text != String.Empty)
                    nick = textBox1.Text;
                else
                    nick = "TuskZaKare";
                nawiazPolaczenie();
            }
        }

        private void bWyslij_Click(object sender, EventArgs e)
        {
            if (tWiadomosc.Text == String.Empty) return;
            pisz.Write(nick + ": " + tWiadomosc.Text);
            richTextBox1.AppendText(nick + ": " + tWiadomosc.Text+Environment.NewLine );
            zapiszDoPliku(nick + ": " + tWiadomosc.Text);
            tWiadomosc.Clear();
        }


    }
}
