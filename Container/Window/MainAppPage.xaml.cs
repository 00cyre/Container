using System;
using Container.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls.DataVisualization.Charting;
using System.Globalization;

namespace Container
{
    
    /// <summary>
    /// Lógica interna para MainAppPage.xaml
    /// </summary>
    ///         private void exibir(grid Grid)
        
    public partial class MainAppPage
    {

        string login = MainWindow.nome;
        int id { get; set; }
        int ExpanderCodeState = 0, OrcTodosState = 0, orcabaState = 0, countAbazinhal = 0; //depois temos que definir os codigos de stado
        public MainAppPage()
        {
            InitializeComponent();
            orcabaState = 1;
            id = Convert.ToInt32(Database.selectSingleValue("id", "empresa", $"email = '{login}'"));
            LblProprietario.Content = login;
            if (id > 500)
            {
                LblTdeconta.Content = "Premium+";
            }
            else
            {
                LblTdeconta.Content = "Normal";
            }
            criarGrafico();
            exibir(grid.funcionario);
        }
       
        private void criarGrafico()
        {
            List<KeyValuePair<string, int?>> valueList = new List<KeyValuePair<string, int?>>();
            List<string> nameList = new List<string>();

            Database.conexao.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM orcamento ORDER BY total LIMIT 6", Database.conexao);
            using (var read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    valueList.Add(new KeyValuePair<string, int?>(Convert.ToString(read["nome_orcamento"]), Convert.ToInt32(read["total"])));
                    nameList.Add(read["nome_orcamento"].ToString());
                }
            }
            Database.conexao.Close();

            Chartz1.DataContext = 200;
            
            if (valueList.Count > 0)
                label4.Content = nameList[0];
                if (valueList.Count > 1)
                    label4_Copy.Content = nameList[1];  
                    if (valueList.Count > 2)
                        label4_Copy1.Content = nameList[2];
                        if (valueList.Count > 3)
                            label4_Copy2.Content = nameList[3];
                            if (valueList.Count > 4)
                                label4_Copy3.Content = nameList[4];
                                if (valueList.Count > 5)
                                    label4_Copy4.Content = nameList[5];

            List<KeyValuePair<string, int>> valueList2 = new List<KeyValuePair<string, int>>();
            Database.conexao.Open();
            cmd = new MySqlCommand("SELECT * FROM funcionarios ORDER BY preco_hora LIMIT 6", Database.conexao);
            using (var read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    valueList2.Add(new KeyValuePair<string, int>(Convert.ToString(read["nome"]), Convert.ToInt32(read["preco_hora"])));
                }
            }
            Database.conexao.Close();
            Chartz2.DataContext = valueList2;
            

            List<KeyValuePair<string, int>> valueList3 = new List<KeyValuePair<string, int>>();
            Database.conexao.Open();
            cmd = new MySqlCommand("SELECT * FROM materiais ORDER BY preco LIMIT 6", Database.conexao);
            using (var read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    valueList3.Add(new KeyValuePair<string, int>(Convert.ToString(read["nome_produto"]), Convert.ToInt32(read["preco"])));
                }
            }
            Database.conexao.Close();
            Chartz3.DataContext = valueList3;
        }

        private void GridHead_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void ImgCloseBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(1);
        }



        private void App_Exit(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnClose_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgCloseBtnAPage.Source = new BitmapImage(new Uri(@"/Images/closelaranja.png", UriKind.RelativeOrAbsolute));

            Color color = (Color)ColorConverter.ConvertFromString("#FF404040");
            BtnCloseAPage.Fill = new SolidColorBrush(color);
        }

        private void BtnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgCloseBtnAPage.Source = new BitmapImage(new Uri(@"/Images/close.png", UriKind.RelativeOrAbsolute));

            BtnCloseAPage.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void BtnClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }





        private void ExpandGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ExpandGrid_MouseEnter(object sender, MouseEventArgs e)
        {



        }

        

        private void RectAba_MouseEnter(object sender, MouseEventArgs e)
        {

            Color colors = (Color)ColorConverter.ConvertFromString("#FF0E0E0F");
            Color colore = (Color)ColorConverter.ConvertFromString("#FF1A1A1A");

            RectAba.Fill = new LinearGradientBrush(colore, colors, 0);
        }

        private void RectAba_MouseLeave(object sender, MouseEventArgs e)
        {

            Color colors = (Color)ColorConverter.ConvertFromString("#FF0E0E0F");
            Color colore = (Color)ColorConverter.ConvertFromString("#FF141414");
            RectAba.Fill = new LinearGradientBrush(colore, colors, 0);

        }
        private void RectAba_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (ExpanderCodeState)
            {
                case 0:
                    {
                        Storyboard sb = FindResource("AbrirMenuzin") as Storyboard;
                        sb.Begin();
                        ExpanderCodeState = 1;
                        break;
                    }
                case 1:
                    {
                        Storyboard sbr = FindResource("FecharMenuzin") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 0;
                        break;
                    }
                case 3:
                    {
                        Storyboard sbr = FindResource("AbrirMenuRegistrar") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 4;
                        break;
                    }
                case 5:
                    {
                        Storyboard sbr = FindResource("AbrirMenuFunc") as Storyboard;
                        sbr.Begin();
                        ExpanderCodeState = 6;
                        break;
                    }
            }

        }
        private void RegistrarFunc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 1 || ExpanderCodeState == 0)
            {
                Storyboard sbr12 = FindResource("FecharMenuzin") as Storyboard;
                sbr12.Begin();

                ExpanderCodeState = 5;

          

            }
            else if (ExpanderCodeState == 4)
            {
                Storyboard sbr12 = FindResource("FecharMenuzin") as Storyboard;
                sbr12.Begin();

                ExpanderCodeState = 5;
            }
            else if (ExpanderCodeState == 5)
            {
                MessageBox.Show("C é burro ou oq?");
            }
        }
        private void GridMenuRegistrarOrc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 0 || ExpanderCodeState == 1)
            {
                Storyboard sbr12 = FindResource("Registrar Orcamento") as Storyboard;


                sbr12.Begin();

                ExpanderCodeState = 3;
                RectOrçamentoSelect.Opacity = 255;

            }
            else if (ExpanderCodeState == 4)
            {
                MessageBox.Show("C é burro ou oq?");
            }
            else if (ExpanderCodeState == 6)
            {

                ExpanderCodeState = 3;

            }
        }

        private void GridMenuPrincipal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard sbr = FindResource("VoltarMenuPrincipal") as Storyboard;
            sbr.Begin();
            ExpanderCodeState = 0;
 
        }

        private void GridMenuRegistrarOrc_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }

        private void GridMenuRegistrarOrc_MouseLeave(object sender, MouseEventArgs e)
        {

            Color color = (Color)ColorConverter.ConvertFromString("#00FFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }



        private void GridAddOrc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }



        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Color colore = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
            plush.Fill = new SolidColorBrush(colore);
            plusv.Fill = new SolidColorBrush(colore);
            Color colorb = (Color)ColorConverter.ConvertFromString("#FF00FF3A");

            ElpseAddOrc.Stroke = new SolidColorBrush(colorb);


        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private async void rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (countAbazinhal == 0)
            {
                orcabaState = 1;
                //mudar conteudo datagrid para materiais
                countAbazinhal++;
                Storyboard sbr = FindResource("AbazinhaOrc1st") as Storyboard;
                sbr.Begin();
                await Task.Delay(500);
                tatsar_Copy.Text = "Marca";
                tatsar.Text = "Imposto";
                TxtRegistrarOrc.Text = "Preço";
                exibir(grid.material);
                //DGridOrçamento.DataContext = Database.selectDataTable("m.nome_produto, m.marca, o.unidades, m.preco, m.imposto, o.total_material", "materiais m join orcamento_materiais o on m.id=o.materiais_id", $"m.empresa_id='{this.id}'");
                countAbazinhal++;
            }
            else
            {

                switch (orcabaState)
                {
                    case 0:
                        {
                            orcabaState = 1;
                            //mudar conteudo da datagrid para os materiais

                            Storyboard sbr = FindResource("AbazinhaOrc") as Storyboard;
                            sbr.Begin();
                            await Task.Delay(500);
                            //DGridOrçamento.Columns[0].Visibility = Visibility.Collapsed;
                            
                            exibir(grid.material);
                            //DGridOrçamento.DataContext = Database.selectDataTable("funcionarios");

                            break;
                        }
                    case 1:
                        {
                            orcabaState = 0;
                            //mudar conteudo datagrid para operarios

                            Storyboard sbr = FindResource("AbazinhaOrcr") as Storyboard;
                            sbr.Begin();
                            await Task.Delay(500);
                            
                            exibir(grid.funcionario);

                            

                            //DGridOrçamento.DataContext = Database.selectDataTable("m.nome_produto, m.marca, o.unidades, m.preco, m.imposto, o.total_material", "materiais m join orcamento_materiais o on m.id=o.materiais_id", $"m.empresa_id='{this.id}'");
                            break;
                        }

                }
                countAbazinhal++;
            }

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Color colore = (Color)ColorConverter.ConvertFromString("#FFB2B2B2");
            plush.Fill = new SolidColorBrush(colore);
            plusv.Fill = new SolidColorBrush(colore);
            Color colorb = (Color)ColorConverter.ConvertFromString("#FF00B229");
            ElpseAddOrc.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 178, 41));
            DateTime theDate = DateTime.Now;
            if (OrcTodosState == 0)//ír p orcamentos
            {

            }
            else //ir p todos
            {
                switch (orcabaState)
                {
                    case 1: // materiais
                        {

                            Database.insert("materiais", $"nome_produto = '{tatsar_Copy1.Text}', marca = '{tatsar_Copy.Text}', imposto = '{tatsar.Text}', preco = '{TxtRegistrarOrc.Text}'");
                            exibir(grid.material);
                            break;
                        }
                    case 0: // funcionarios
                        {
                            break;
                        }
                }
            }

           // Database.insert("orcamento", "default," + "'" + TxtRegistrarOrc.Text + "'," + "'" + tatsar.Text + "'," + "'" + theDate.ToString("yyyy-MM-dd H:mm:ss") + "',NULL,NULL,NULL,NULL," + id);
            //exibir(grid.orcamento);
            //DGridOrçamento.DataContext = Database.selectDataTable("orcamento");



        }


        private void RegistrarFunc_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");


        }

        private void RegistrarFunc_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#00FFFFFF");

        }

        private void DGridOrçamento_Initialized(object sender, EventArgs e)
        {
           

            
        }

        private void DGridOrçamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GridMenuEditar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpanderCodeState == 0 || ExpanderCodeState == 1)
            {
                Storyboard sbr12 = FindResource("AbrirEditar") as Storyboard;


                sbr12.Begin();

                ExpanderCodeState = 3;


            }
            else if (ExpanderCodeState == 4)
            {
                //MessageBox.Show("C é burro ou oq?");
            }
            else if (ExpanderCodeState == 6)
            {

                //ExpanderCodeState = 3;
            }
        }
        private void GridMenuEditar_MouseEnter(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }
        private void GridMenuEditar_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#0CFFFFFF");
            RectOrçamento.Fill = new SolidColorBrush(color);
        }

        
        private async void RectAbaOrcT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OrcTodosState == 0)
            {
                Storyboard sb = FindResource("IrPOrcamentos") as Storyboard;
                sb.Begin();
                await Task.Delay(500);
                exibir(grid.orcamento);
                //DGridOrçamento.DataContext = Database.selectDataTable("orcamento");
                OrcTodosState = 1;
                RectTrocaAba.IsHitTestVisible = false;
            }
            else
            {
                Storyboard sb = FindResource("IrPTodos") as Storyboard;
                sb.Begin();
                await Task.Delay(500);
                if(orcabaState == 0)
                {

                    exibir(grid.material);
                       // DGridOrçamento.DataContext = Database.selectDataTable("m.nome_produto, m.marca, o.unidades, m.preco, m.imposto, o.total_material", "materiais m join orcamento_materiais o on m.id=o.materiais_id", $"m.empresa_id='{this.id}'");

                        
                        //DGridOrçamento.DataContext = Database.selectDataTable("m.nome_produto, m.marca, o.unidades, m.preco, m.imposto, o.total_material");

                    
                }
                else
                {

                    //DGridOrçamento.DataContext = Database.selectDataTable("", "funcionarios ", $"empresa_id={this.id}");
                    exibir(grid.funcionario);
                }
                OrcTodosState = 0;
                RectTrocaAba.IsHitTestVisible = true;
            }
        }



        private void exibir(grid Grid)
        {
            DataTable data = null;
            switch (Grid)
            {
                case grid.orcamento:
                    DGridOrçamento.MinColumnWidth = 330;
                    tatsar_Copy.Text = "Nome";
                    tatsar.Text = "Area";
                    TxtRegistrarOrc.Text = "Total";
                    data = Database.selectDataTable("nome_orcamento, area_construcao, data_orcamento, total", "orcamento", $"empresa_id='{this.id}'");
                    break;
                case grid.orcamento_func:
                    data = Database.selectDataTable("f.nome, o.nome_orcamento, of.total_funcionarios, of.horas_trabalhadas", "orcamento_funcionarios of JOIN orcamento o ON of.orcamento_id = o.id JOIN funcionarios f ON f.id = of.funcionarios_id", $"f.empresa_id='{this.id}' && o.empresa_id='{this.id}'");
                    break;
                case grid.orcamento_mat:
                    DGridOrçamento.MinColumnWidth = 366;
                    data = Database.selectDataTable("m.nome_produto, o.nome_orcamento, om.unidades, om.total_material", "orcamento_materiais om JOIN orcamento o ON om.orcamento_id = o.id JOIN materiais m ON m.id = om.materiais_id", $"m.empresa_id='{this.id}' && o.empresa_id='{this.id}'");
                    break;
                case grid.material:
                    DGridOrçamento.MinColumnWidth = 430;
                    data = Database.selectDataTable("nome_produto, marca, preco", "materiais", $"empresa_id='{this.id}'");
                    tatsar_Copy1.Text = "Nome";
                    tatsar_Copy.Text = "Marca";
                    tatsar.Text = "Imposto";
                    TxtRegistrarOrc.Text = "Preço";
                    break;
                case grid.funcionario:
                    DGridOrçamento.MinColumnWidth = 230;
                    tatsar_Copy2.Text = "Nome";
                    tatsar_Copy1.Text = "Profissão";
                    tatsar_Copy.Text = "Preço/H";
                    tatsar.Text = "Telefone";
                    TxtRegistrarOrc.Text = "Cidade";
                    data = Database.selectDataTable("nome, especialidade, preco_hora, telefone, cidade", "funcionarios", $"empresa_id='{this.id}'");
                    break;
            }
            DGridOrçamento.DataContext = data;
        }

        private void inserir(grid Grid)
        {
            switch (Grid)
            {
                case grid.orcamento:
                    Database.insert("orcamento", $"default, '{tatsar.Text}', '{TxtRegistrarOrc.Text}', {DateTime.Now.ToString("yyyy-MM-dd")}, null, null, null, null, {id}");
                    break;
                case grid.orcamento_func:
                    Database.insert("orcamento_funcionarios", "");
                    break;
                case grid.orcamento_mat:
                    Database.insert("orcamento_materiais", "");
                    break;
                case grid.material:
                    tatsar_Copy1.Text = "Nome";
                    tatsar_Copy.Text = "Marca";
                    tatsar.Text = "Imposto";
                    TxtRegistrarOrc.Text = "Preço";
                    Database.insert("materiais", $"default, '{tatsar_Copy.Text}', '{tatsar.Text}', null, '{TxtRegistrarOrc.Text}', null, {id}");

                    Database.insert("materiais", $"default, '{tatsar_Copy1.Text}', '{TxtRegistrarOrc.Text}', {tatsar.Text}, '{tatsar_Copy.Text}', null, {id}");

                    break;
                case grid.funcionario:
                    Database.insert("funcionarios", "");
                    break;
            }
        }

        enum grid
        {
            orcamento,
            orcamento_func,
            orcamento_mat,
            material,
            funcionario
        }
    }
}