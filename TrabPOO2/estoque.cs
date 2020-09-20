using System;
namespace lojinha
{
    public class estoque : loja
    {
        public string produto
        {
            get;
            set;
        }
        
        public int quantidade_produto
            {
            get;
            set;
        }
         
          public string fornecedor
        {
            get;
            set;
        }
           
        
             
         };
        
         
        public void Resumo(){
            foreach(var produto in estoque)
           {
               Console.WriteLine("teste estoque");
           }

         }
          

  }

    


