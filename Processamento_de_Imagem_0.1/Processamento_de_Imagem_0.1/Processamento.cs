using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processamento_de_Imagem_0._1
{
    class Processamento
    {
        int STRIDE;
        int ALTURA;

        public Bitmap NovoFrame(Bitmap image)
        {
            Bitmap imgCopia = new Bitmap(image);

            // Aplica o lockbits recebendo como parametro o Rectangle que limita a área do lockbits
            Rectangle rect = new Rectangle(0, 0, imgCopia.Width, imgCopia.Height);
            System.Drawing.Imaging.BitmapData bmpData = imgCopia.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, imgCopia.PixelFormat);

            // Pega o endereço da primeira linha de varredura ( Scan0 ) 
            IntPtr ptr = bmpData.Scan0;

            // Cria uma matriz que recebe todos os bytes da bitmap
            int bytes = Math.Abs(bmpData.Stride) * imgCopia.Height;
            byte[] rgbValues = new byte[bytes];

            STRIDE = bmpData.Stride;
            ALTURA = imgCopia.Height;

            // Copia a matriz para o ponteiro
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int counter = STRIDE / 2; counter < rgbValues.Length; counter += STRIDE)//counter començando em 1280 para pegar o centro da img e criar a linha y
            {
                //BGRA
                rgbValues[counter] = 0;
                rgbValues[counter + 1] = 0;
                rgbValues[counter + 2] = 255; 
            }

            // Copia os valores de volta para a bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlockbits
            imgCopia.UnlockBits(bmpData);

            //Atualiza a imagem modificada 
            image = imgCopia;
            //return imgCopia;

            return image;
        }



    }
}
