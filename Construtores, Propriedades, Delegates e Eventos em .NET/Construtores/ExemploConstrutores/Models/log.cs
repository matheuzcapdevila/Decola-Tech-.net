namespace ExemploConstrutores.Models
{
    public class Log
    {
        private Log log; //proprieddade privada

       public string PropriedadeLog { get; set; }

       
        private Log()
        {
            
        }
        // public static Log GetInstance(){ //método para obter a instancia da classe
        //      if (_log == null)
        //      {
        //          _log = new Log ();
        //      }
        //      return _log; //Vai ser sempre a mesma instancia
        //  }
    }
}