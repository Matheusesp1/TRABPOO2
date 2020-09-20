
using System;
namespace lojinha 
{
    public class pedidos
    { 
        public DateTime data 
          {get;
            set;
        }

        public string nome_cliente
         {get;
            set;
        }


        public DateTime data_envio
         {get;
            set;
        }

        public void dispache(){

           bool enviado = true;

              if (enviado)
    {
               Console.WriteLine("The variable is set to true");
    }
 else
     {
               Console.WriteLine("The variable is set to false");
     } 
                 
        } 
    }
}