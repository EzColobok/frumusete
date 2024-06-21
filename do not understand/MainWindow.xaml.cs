using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace do_not_understand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Pos[] obiect;

        int row = Gridlogic.Rows;

        int col = Gridlogic.Columns;

        int r;

        int g;

        int b;

        int RotationState;

        int movesup;

        int right;

        int left;

        int ez;

        int rowsup = 0;

        int[] rowmax;

        int helperr;

        int helperc;

        int[,] rcocupate = new int[20, 10];

        BlockQueue blockQueue = new BlockQueue();
        public MainWindow()
        {
            for (int i=0;i<20;i++)
            {
                for (int j = 0; j < 10; j++)
                    rcocupate[i,j] = 0;
            }


            movesup = 0;
            RotationState = 0;
            InitializeComponent();
            CreateGrid(); 


            BlockSummon(blockQueue.Id);
            this.KeyDown += Rotation;

            this.KeyDown += MoveRight;

            this.KeyDown += MoveLeft;

            this.KeyDown += Movedown;


        }

        private void Rotation(object sender, KeyEventArgs z)
        {

            if (z.Key == Key.Z)
            {
                deleteblock();
                RotationState++;



                if (RotationState == 4)
                {
                    RotationState = 0;

                }
                ez = movesup;
                movesup = 0;
                BlockSummon(blockQueue.Id);
                deleteblock();
                movesup = ez;





                if (movesup >= right)
                {


                    movesup = right;




                }



                if (movesup <= left)
                {


                    movesup = left;




                }

                if (rowsup >= rowmax[RotationState])
                {


                    rowsup = rowmax[RotationState];




                }

                BlockSummon(blockQueue.Id);




            }

        }

        private void MoveRight(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Right && movesup < right)
            {

                deleteblock();

                movesup++;


                BlockSummon(blockQueue.Id);
            }

        }

        private void MoveLeft(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left && movesup > left)
            {
                deleteblock();

                movesup--;
                BlockSummon(blockQueue.Id);

            }

        }
        private void CreateGrid()
        {

            for (int i = 0; i < row; i++)
            {
                MainGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int j = 0; j < col; j++)
            {
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    Rectangle rect = new Rectangle();
                    rect.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    rect.Stroke = Brushes.White;

                    rect.StrokeThickness = 1;


                    Grid.SetRow(rect, i);
                    Grid.SetColumn(rect, j);


                    MainGrid.Children.Add(rect);
                }
            }



        }


        private void colorare()
        {
            helperc =3 + movesup;
            helperr = rowsup;
            foreach (Pos p in obiect)
            {
                Rectangle rect = new Rectangle();
                rect.Fill = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
                rect.Stroke = Brushes.White;
                rect.StrokeThickness = 1;

                
                Grid.SetRow(rect, p.Row + rowsup);

                Grid.SetColumn(rect, p.Column + helperc);


                MainGrid.Children.Add(rect);
            }
        }
        private void BlockSummon(int id)
        {
            switch (id)
            {
                case 1:

                    Block1 block1 = new Block1();

                    right = block1.Left_Right[RotationState, 1];
                    left = block1.Left_Right[RotationState, 0];

                    rowmax = block1.maxrow;

                    r = block1.R;
                    g = block1.G;
                    b = block1.B;

                    obiect = block1.Tiles[RotationState];

                    colorare();
                    break;

                case 2:

                    Block2 block2 = new Block2();
                    id = block2.Id;

                    right = block2.Left_Right[RotationState, 1];
                    left = block2.Left_Right[RotationState, 0];

                    rowmax = block2.maxrow;

                    r = block2.R;
                    g = block2.G;
                    b = block2.B;

                    obiect = block2.Tiles[0];


                    colorare();
                    break;

                case 3:

                    Block3 block3 = new Block3();

                    id = block3.Id;

                    right = block3.Left_Right[RotationState, 1];
                    left = block3.Left_Right[RotationState, 0];

                    rowmax = block3.maxrow;

                    r = block3.R;
                    g = block3.G;
                    b = block3.B;

                    obiect = block3.Tiles[RotationState];

                    colorare();
                    break;


                case 4:

                    Block4 block4 = new Block4();

                    id = block4.Id;

                    right = block4.Left_Right[RotationState, 1];
                    left = block4.Left_Right[RotationState, 0];

                    rowmax = block4.maxrow;

                    r = block4.R;
                    g = block4.G;
                    b = block4.B;

                    obiect = block4.Tiles[RotationState];

                    colorare();
                    break;

                case 5:

                    Block5 block5 = new Block5();

                    id = block5.Id;

                    right = block5.Left_Right[RotationState, 1];
                    left = block5.Left_Right[RotationState, 0];

                    rowmax = block5.maxrow;

                    r = block5.R;
                    g = block5.G;
                    b = block5.B;

                    obiect = block5.Tiles[RotationState];

                    colorare();
                    break;

                case 6:

                    Block6 block6 = new Block6();
                    id = block6.Id;


                    right = block6.Left_Right[RotationState, 1];
                    left = block6.Left_Right[RotationState, 0];

                    rowmax = block6.maxrow;

                    r = block6.R;
                    g = block6.G;
                    b = block6.B;

                    obiect = block6.Tiles[RotationState];

                    colorare();
                    break;

                case 7:

                    Block7 block7 = new Block7();

                    id = block7.Id;

                    right = block7.Left_Right[RotationState, 1];
                    left = block7.Left_Right[RotationState, 0];

                    rowmax = block7.maxrow;

                    r = block7.R;
                    g = block7.G;
                    b = block7.B;

                    obiect = block7.Tiles[RotationState];

                    colorare();
                    break;
            }
        }


        private void deleteblock()
        {
            foreach (Pos p in obiect)
            {


                Rectangle rect = new Rectangle();
                rect.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                rect.Stroke = Brushes.White; 
                rect.StrokeThickness = 1;

                
                Grid.SetRow(rect, p.Row + rowsup);
                Grid.SetColumn(rect, p.Column + 3 + movesup);

                
                MainGrid.Children.Add(rect);

            }
        }



        private void Movedown(object sender, KeyEventArgs T)
        {

            if (T.Key == Key.Down)
            {
                if (rowsup <= rowmax[RotationState])
                {
                    deleteblock();
                    rowsup++;

                    BlockSummon(blockQueue.Id);
                }
                if (rowmax[RotationState] == helperr)
                {
                    newId(blockQueue);
                    ocupat();
                    rowsup = 0;
                    movesup = 0;
                }

                
            }
        }
        public void newId(BlockQueue blockQueue)
        {
            blockQueue.GenerateNewId();

        }
        private void ocupat()
        {
            foreach (Pos p in obiect)
            {
                rcocupate[p.Row + rowsup-1, p.Column +3 + movesup] = 1;
            }

        }
    }
}
        



    
