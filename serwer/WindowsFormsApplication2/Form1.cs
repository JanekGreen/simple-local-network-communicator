using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private TcpListener listener = null;
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
            piszDoPliku = new StreamWriter("log.txt_"  + DateTime.Now.ToString("yyyyMMddTHHmmss"));

      
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
                if (tekst != String.Empty)
                {
                    dodajWiadomosc(richTextBox1, tekst);
                    zapiszDoPliku(tekst);

                }
            } 
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (!polaczono)
            {
                if (textBox1.Text != String.Empty)
                    nick = textBox1.Text;
                else
                    nick = "MacierewiczZaKare";
                Thread watekNasluchu = new Thread(this.CzekajNapolaczenie);
                watekNasluchu.Start();
            }
        }

       
        private void CzekajNapolaczenie()
        {
            try
            {
                if (tPort.Text == String.Empty)
                {
                    dodajWiadomosc(richTextBox1, "Podaj numer portu!");
                    return;
                }
                listener = new TcpListener(IPAddress.Any, int.Parse(tPort.Text));
                listener.Start();
            }
            catch (Exception e) { dodajWiadomosc(richTextBox1, "Coś poszło nie tak:" + e.Message); }

                dodajWiadomosc(richTextBox1, "Oczekiwanie na polaczenie...");
           
                klient = listener.AcceptTcpClient();
                dodajWiadomosc(richTextBox1, "Zarządzano polaczenia");
                NetworkStream stream = klient.GetStream();
                pisz = new BinaryWriter(stream);
                czytaj = new BinaryReader(stream);

                Thread watekOdbioruWiadomosci = new Thread(odbierzWiadomosc);
                watekOdbioruWiadomosci.Start();
                polaczono = true;
                return;
            


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
