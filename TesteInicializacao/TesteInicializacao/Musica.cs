using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteInicializacao
{
    class Musica : IDisposable 
    {

        
        Thread t;
        public void TocarMusicaSemBloquear()
        {
            //Inicializa outra Thread para tocar a música.
            t = new Thread(() => TocarMusica());
            t.Start();
        }

        

        public void PararMusica()
        {
            if (t != null)
            {
                t.Abort();
            }
        }
        
        public void TocarMusica()
        {
            Console.Beep(660, 100);
            Thread.Sleep(150);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(510, 100);
            Thread.Sleep(100);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(770, 100);
            Thread.Sleep(550);
            Console.Beep(380, 100);
            Thread.Sleep(575);

            Console.Beep(510, 100);
            Thread.Sleep(450);
            Console.Beep(380, 100);
            Thread.Sleep(400);
            Console.Beep(320, 100);
            Thread.Sleep(500);
            Console.Beep(440, 100);
            Thread.Sleep(300);
            Console.Beep(480, 80);
            Thread.Sleep(330);
            Console.Beep(450, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(200);
            Console.Beep(660, 80);
            Thread.Sleep(200);
            Console.Beep(760, 50);
            Thread.Sleep(150);
            Console.Beep(860, 100);
            Thread.Sleep(300);
            Console.Beep(700, 80);
            Thread.Sleep(150);
            Console.Beep(760, 50);
            Thread.Sleep(350);
            Console.Beep(660, 80);
            Thread.Sleep(300);
            Console.Beep(520, 80);
            Thread.Sleep(150);
            Console.Beep(580, 80);
            Thread.Sleep(150);
            Console.Beep(480, 80);
            Thread.Sleep(500);

            Console.Beep(510, 100);
            Thread.Sleep(450);
            Console.Beep(380, 100);
            Thread.Sleep(400);
            Console.Beep(320, 100);
            Thread.Sleep(500);
            Console.Beep(440, 100);
            Thread.Sleep(300);
            Console.Beep(480, 80);
            Thread.Sleep(330);
            Console.Beep(450, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(200);
            Console.Beep(660, 80);
            Thread.Sleep(200);
            Console.Beep(760, 50);
            Thread.Sleep(150);
            Console.Beep(860, 100);
            Thread.Sleep(300);
            Console.Beep(700, 80);
            Thread.Sleep(150);
            Console.Beep(760, 50);
            Thread.Sleep(350);
            Console.Beep(660, 80);
            Thread.Sleep(300);
            Console.Beep(520, 80);
            Thread.Sleep(150);
            Console.Beep(580, 80);
            Thread.Sleep(150);
            Console.Beep(480, 80);
            Thread.Sleep(500);

            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 150);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(150);

            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(430, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(100);
            Console.Beep(570, 100);
            Thread.Sleep(220);

            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 200);
            Thread.Sleep(300);

            Console.Beep(1020, 80);
            Thread.Sleep(300);
            Console.Beep(1020, 80);
            Thread.Sleep(150);
            Console.Beep(1020, 80);
            Thread.Sleep(300);

            Console.Beep(380, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 150);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(150);

            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(430, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(100);
            Console.Beep(570, 100);
            Thread.Sleep(420);

            Console.Beep(585, 100);
            Thread.Sleep(450);

            Console.Beep(550, 100);
            Thread.Sleep(420);

            Console.Beep(500, 100);
            Thread.Sleep(360);

            Console.Beep(380, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 150);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(150);

            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(430, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(100);
            Console.Beep(570, 100);
            Thread.Sleep(220);

            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 200);
            Thread.Sleep(300);

            Console.Beep(1020, 80);
            Thread.Sleep(300);
            Console.Beep(1020, 80);
            Thread.Sleep(150);
            Console.Beep(1020, 80);
            Thread.Sleep(300);

            Console.Beep(380, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(760, 100);
            Thread.Sleep(100);
            Console.Beep(720, 100);
            Thread.Sleep(150);
            Console.Beep(680, 100);
            Thread.Sleep(150);
            Console.Beep(620, 150);
            Thread.Sleep(300);

            Console.Beep(650, 150);
            Thread.Sleep(300);
            Console.Beep(380, 100);
            Thread.Sleep(150);
            Console.Beep(430, 100);
            Thread.Sleep(150);

            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(430, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(100);
            Console.Beep(570, 100);
            Thread.Sleep(420);

            Console.Beep(585, 100);
            Thread.Sleep(450);

            Console.Beep(550, 100);
            Thread.Sleep(420);

            Console.Beep(500, 100);
            Thread.Sleep(360);

            Console.Beep(380, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(300);
            Console.Beep(500, 100);
            Thread.Sleep(150);
            Console.Beep(500, 100);
            Thread.Sleep(300);

            Console.Beep(500, 60);
            Thread.Sleep(150);
            Console.Beep(500, 80);
            Thread.Sleep(300);
            Console.Beep(500, 60);
            Thread.Sleep(350);
            Console.Beep(500, 80);
            Thread.Sleep(150);
            Console.Beep(580, 80);
            Thread.Sleep(350);
            Console.Beep(660, 80);
            Thread.Sleep(150);
            Console.Beep(500, 80);
            Thread.Sleep(300);
            Console.Beep(430, 80);
            Thread.Sleep(150);
            Console.Beep(380, 80);
            Thread.Sleep(600);

            Console.Beep(500, 60);
            Thread.Sleep(150);
            Console.Beep(500, 80);
            Thread.Sleep(300);
            Console.Beep(500, 60);
            Thread.Sleep(350);
            Console.Beep(500, 80);
            Thread.Sleep(150);
            Console.Beep(580, 80);
            Thread.Sleep(150);
            Console.Beep(660, 80);
            Thread.Sleep(550);

            Console.Beep(870, 80);
            Thread.Sleep(325);
            Console.Beep(760, 80);
            Thread.Sleep(600);

            Console.Beep(500, 60);
            Thread.Sleep(150);
            Console.Beep(500, 80);
            Thread.Sleep(300);
            Console.Beep(500, 60);
            Thread.Sleep(350);
            Console.Beep(500, 80);
            Thread.Sleep(150);
            Console.Beep(580, 80);
            Thread.Sleep(350);
            Console.Beep(660, 80);
            Thread.Sleep(150);
            Console.Beep(500, 80);
            Thread.Sleep(300);
            Console.Beep(430, 80);
            Thread.Sleep(150);
            Console.Beep(380, 80);
            Thread.Sleep(600);

            Console.Beep(660, 100);
            Thread.Sleep(150);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(510, 100);
            Thread.Sleep(100);
            Console.Beep(660, 100);
            Thread.Sleep(300);
            Console.Beep(770, 100);
            Thread.Sleep(550);
            Console.Beep(380, 100);
            Thread.Sleep(575);
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    PararMusica();
                    t = null;
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        ~Musica() {
           // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
           Dispose(false);
        }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
