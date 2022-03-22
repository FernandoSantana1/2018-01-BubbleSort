using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //////////////Exibir o array de modo Crescente//////////////
        int[] y = new int [] { 35, 3, 1, 7, 2, 89, 1, 48, 9, 09, 90,0 };    //declarar o array
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < y.Length; i++)   
            {
                richTextBox1.AppendText(Convert.ToString(y[i]) + Environment.NewLine);   //exibir o array original
            }      
            bubblesort(y);   //ordenar o array "y"
            for(int i = 0; i < y.Length; i++)
            {
                richTextBox2.AppendText(Convert.ToString(y[i]) + Environment.NewLine);   //exibir o array organizado
            }
        }
        public void bubblesort(int[] y)   //metodo BubbleSort
        {
            for (int i = 1; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length - 1; j++) 
                {
                    if (y[j] > y[j + 1])  //se a posicao atual for MAIOR que a prixima posicao...
                    {
                        int aux;  //irá armazenar os valores
                        aux = y[j];   //a variavel "aux" recebe o valor da posicao atual do array 
                        y[j] = y[j + 1]; //a posicao atual do array recebe o valor da proxima posicao 
                        y[j + 1] = aux;  // a proxima posicao recebe o valor que esta guardado em "aux"               
                    }
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////Exibir o Array de modo Decrescente///////////////////////////////////////////////////
        
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length - 1; j++)
                {
                    if (y[j] < y[j + 1])  //Mesmo procedimento da organizacao Crescente porem se a posicao atual for MENOR que a proxima...
                    {
                        int aux;  //irá armazenar os valores
                        aux = y[j];   //a variavel "aux" recebe o valor da posicao atual do array 
                        y[j] = y[j + 1]; //a posicao atual do array recebe o valor da proxima posicao 
                        y[j + 1] = aux;  // a proxima posicao recebe o valor que esta guardado em "aux"     
                       
                    }     
                }  
            }
            for (int i = 0; i < y.Length; i++)
            {
                richTextBox3.AppendText(Convert.ToString(y[i]) + Environment.NewLine);   //exibir o array organizado
            }
        }  
    }
}
