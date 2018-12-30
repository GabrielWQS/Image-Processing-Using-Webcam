

//            PROCESSAMENTO DE IMAGEM 0.1
//            GABRIEL WALLACE  

/*
            antes de trabalhar no código é necessário incluir os arquivos // Inclui atualização usando o Nuget
            Aforge
            Aforge.Video
            Aforge.VideoDirectShow

            Para acessarmos o NewFrame em videoSourcePlayer, incluir na ToolBox o arquivo 
            AForge.Controls

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Processamento_de_Imagem_0._1
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        Processamento novoProcessamento = new Processamento();

        public Form1()
        {
            InitializeComponent();

            AtualizarListaCamera();

            
        }

        private void btt_Start_Click(object sender, EventArgs e)
        {
            LigaCamera();
        }

        private void bttStop_Click(object sender, EventArgs e)
        {
            DesligaCamera();
        }

        private void btt_Refresh_Click(object sender, EventArgs e)
        {
            AtualizarListaCamera();
        }

        private void AtualizarListaCamera()
        {
            //Carrega as câmeras na combobox
            try
            {
                // enumera os dispositivos de video
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                //adiciona todos os dispositivos a comboBox
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox_Cam.Items.Add(device.Name);
                }

                comboBox_Cam.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                comboBox_Cam.Items.Add("Não a dispositivos conectados");
                videoDevices = null;
            }
        }
        
        public void LigaCamera()
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[comboBox_Cam.SelectedIndex].MonikerString);

            videoSource.VideoResolution = videoSource.VideoCapabilities[0];
            
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

            alturaLB.Text = Convert.ToString(videoSource.VideoResolution.FrameSize.Height);
            larguraLB.Text = Convert.ToString(videoSource.VideoResolution.FrameSize.Width);

            frameRateLB.Text = Convert.ToString(videoSource.VideoCapabilities[0].AverageFrameRate);
        }

        public void DesligaCamera()
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap bmp = new Bitmap(image);
            image = (novoProcessamento.NovoFrame(bmp));
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DesligaCamera();
        }
    }
}
