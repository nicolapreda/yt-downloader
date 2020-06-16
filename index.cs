using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Net;


namespace Syncro_Tube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool FormatDrum = true;
        //true = mp3
        //false = mp4
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void phoenixpixelitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.phoenixpixel.it");
        }

        private void aiutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.phoenixpixel.it/syncro-tube");
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            //await

            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Seleziona la cartella di destinazione del download" }) 
            {
                if(fdb.ShowDialog() == DialogResult.OK)
                {
                    GetTitle();
                    lblInfo.Visible = true;
                    SongDownload.Visible = true;

                    lblInfo.Text = "Download video in corso...";
                    lblInfo.ForeColor = Color.Orange;

                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(textBox1.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());


                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };
                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile, outputFile);
                    }

                    if (FormatDrum == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }


                    lblInfo.Text = "Download video completato!";
                    lblInfo.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Errore nel download del video, riprova!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void GetTitle()
        {
            WebRequest request = HttpWebRequest.Create(textBox1.Text);
            WebResponse response;
            response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string readtitle = reader.ReadToEnd();
            int text = readtitle.IndexOf("<title>") + 7;
            int strings = readtitle.Substring(text).IndexOf("</title>");
            string substring = readtitle.Substring(text, strings);
            SongDownload.Text = (substring);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FormatDrum = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FormatDrum = false;
        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creato da diskxo_" + "\n" + "By phoenixpixel.it");
        }
    }
}
