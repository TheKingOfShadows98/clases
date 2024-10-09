namespace WhereBus{


    public class Nodo
    {
        public Nodo Padre;
        public IElementoRuta Elemento;


        public Nodo(IElementoRuta elemento)
        {
            Elemento = elemento;
        }

        public Nodo(IElementoRuta elemento, Nodo padre)
        {
            Elemento = elemento;
            Padre = padre;
        }

        public string History(){
            string result = "";
            if(Padre != null){
                result += $"{Padre.History()} > ";
            }
            result += $"{Elemento.GetNombre()}";
            return result;
        } 
    }

}