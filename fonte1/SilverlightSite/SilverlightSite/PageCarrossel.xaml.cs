using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using System.Windows.Browser;

namespace SilverlightSite
{
    public partial class Page6 : Page
    {
        private double numImagem = 0;
        private String[] IMAGES = { "imagem/imagem00.png", "imagem/imagem01.png", "imagem/imagem02.png", "imagem/imagem03.png", "imagem/imagem04.png" };    // images
        private static double IMAGE_WIDTH = 425;        // Imagem Largura
        private static double IMAGE_HEIGHT = 425;       // Imagem Altura        
        private static double SPRINESS = 0.4;		    // Controle de Velocidade "Spring"
        private static double DECAY = 0.5;			    // Controle de velocidade "bounce"
        private static double SCALE_DOWN_FACTOR = 0.5;  // Escala entre imagens
        private static double OFFSET_FACTOR = 400;      // Distância entre imagens
        private static double OPACITY_DOWN_FACTOR = 0.4;    // Alpha entre imagens
        private static double MAX_SCALE = 1;               // Escala Maxima


        private double _xCenter;
        private double _yCenter;

        private double _target = 0;		// Alvo da mudança posição
        private double _current = 0;	// Posição corrente
        private double _spring = 0;		// Guarda ultimo movimento
        private List<Image> _images = new List<Image>();	// Imagens adicionadas

        private static int FPS = 24;                // fps frame (delay de mudança)
        private DispatcherTimer _timer = new DispatcherTimer(); 

        public Page6()
        {
            InitializeComponent();

            // Savar posição central
            _xCenter = Width / 2;
            _yCenter = Height / 2;

            addImages();

            lbName.Content = "Alunos"; // default

           // adiciona o scroll handler
            HtmlPage.Window.AttachEvent("DOMMouseScroll", OnMouseWheel);
            HtmlPage.Window.AttachEvent("onmousewheel", OnMouseWheel);
            HtmlPage.Document.AttachEvent("onmousewheel", OnMouseWheel);
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        /////////////////////////////////////////////////////        
        // Handlers 
        /////////////////////////////////////////////////////	

        // imagens
        void _timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _images.Count; i++)
            {
                Image image = _images[i];
                posImage(image, i);
            }


            // corrente posição
            // adiciona efeito spring
            _spring = (_target - _current) * SPRINESS + _spring * DECAY;
            _current += _spring;
        }

        // mouse wheel
        private void OnMouseWheel(object sender, HtmlEventArgs args)
        {

            double mouseDelta = 0;
            ScriptObject e = args.EventObject;
            // Mozilla and Safari    
            if (e.GetProperty("detail") != null)
            {
                mouseDelta = ((double)e.GetProperty("detail"));
            }

            // IE and Opera   
            else if (e.GetProperty("wheelDelta") != null)
                mouseDelta = ((double)e.GetProperty("wheelDelta"));

            mouseDelta = Math.Sign(mouseDelta);

            moveIndex((mouseDelta > 0) ? 1 : -1);
        }


        // define o novo tragetoria do mouse (Forward)
        void ImageNaigation_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           // moveIndex(1);
        }

        /////////////////////////////////////////////////////        
        // Private Methods 
        /////////////////////////////////////////////////////	


        // adiciona imagens
        private void addImages()
        {
            for (int i = 0; i < IMAGES.Length; i++)
            {
                // pega a imagem encontrada
                string url = IMAGES[i];
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(url, UriKind.Relative));

                // adiciona e reposiciona a imagem
                LayoutRoot.Children.Add(image);
                posImage(image, i);
                _images.Add(image);
            }
        }

        // move the index
        private void moveIndex(int value)
        {
            _target += value;
            _target = Math.Max(0, _target);
            _target = Math.Min(_images.Count - 1, _target);          
            numImagem = _target;
            // Imagens 0 - setas(alunos); 1 - video(video); 2 - vidro(professor); 3 - bandeira(gráfico); 4 - círculo(disciplina)
            if (numImagem == 0) // alunos
            {
                lbName.Content = "Alunos";
            }
            if (numImagem == 1) // Vídeo
            {
                lbName.Content = "Vídeo";
            }
            if (numImagem == 2) // professor
            {
                lbName.Content = "Professores";
            }
            if (numImagem == 3) // gráfico
            {
                lbName.Content = "Gráfico";                
            }
            if (numImagem == 4) // disciplina
            {
                lbName.Content = "Disciplinas";
            }
        }

        // reposição da imagem
        private void posImage(Image image, int index)
        {
            double diffFactor = index - _current;


            // escala e posição da imagem conforme a index dela e corrente posição
            // mais perto será maior
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = MAX_SCALE - Math.Abs(diffFactor) * SCALE_DOWN_FACTOR;
            scaleTransform.ScaleY = MAX_SCALE - Math.Abs(diffFactor) * SCALE_DOWN_FACTOR;
            image.RenderTransform = scaleTransform;

            // reposição da imagem
            double left = _xCenter - (IMAGE_WIDTH * scaleTransform.ScaleX) / 2 + diffFactor * OFFSET_FACTOR;
            double top = _yCenter - (IMAGE_HEIGHT * scaleTransform.ScaleY) / 2;
            image.Opacity = 1 - Math.Abs(diffFactor) * OPACITY_DOWN_FACTOR;

            image.SetValue(Canvas.LeftProperty, left);
            image.SetValue(Canvas.TopProperty, top);

            // ordem do elemento pela scaleX
            image.SetValue(Canvas.ZIndexProperty, (int)Math.Abs(scaleTransform.ScaleX * 100));
        }

        /////////////////////////////////////////////////////        
        // Public Methods
        /////////////////////////////////////////////////////	

        // inicia o timer
        public void Start()
        {
            // inicia o evento frame 
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / FPS);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (numImagem == 4)
            {
                moveIndex(-4);
            }
            else
            {
                moveIndex(1);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (numImagem == 0)
            {
                moveIndex(4);
            }
            else
            {
                moveIndex(-1);
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Carrossel.Children.Remove(LayoutRoot);
            // Imagens 0 - setas(alunos); 1 - video(video); 2 - vidro(professor); 3 - bandeira(gráficos); 4 - círculo(disciplina)
            if (numImagem == 0) // Pagina de Alunos
            {
                Page4 pg = new Page4();

                Carrossel.Children.Clear();

                Carrossel.Children.Add(pg);
            }

            if (numImagem == 1) // Pagina de Video
            {
                Page1 pg = new Page1();

               Carrossel.Children.Clear();

               Carrossel.Children.Add(pg);
            }

            if (numImagem == 2) // Pagina de professor
            {
                Page5 pg = new Page5();

                Carrossel.Children.Clear();

                Carrossel.Children.Add(pg);
            }

            if (numImagem == 3) // Pagina de gráfico
            {
                Page2 pg = new Page2();

                Carrossel.Children.Clear();

                Carrossel.Children.Add(pg);
            }

            if (numImagem == 4) // Pagina de disciplina
            {
                Page3 pg = new Page3();

                Carrossel.Children.Clear();

                Carrossel.Children.Add(pg);
            }
        }

    }
}
