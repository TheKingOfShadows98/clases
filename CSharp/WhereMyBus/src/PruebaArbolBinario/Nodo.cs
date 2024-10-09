using System.Collections.Generic;
namespace Tests.Arbol{
    public class Node{

        public string Data {get; private set;}// Informacion guardada en el NODO.
        public Node Parent{ get; private set;}// Nodo padre del Nodo.
        public List<Node> Childs { get; private set;}// Hijos de este Nodo.

        public Node(string data){
            Data = data;// Asignamos la Informacion al nodo.
            Childs = new(); // Inicializamos la lista de Hijos.
        }

        public Node(string data, Node parent){
            Data = data;// Asignamos la Informacion al nodo.
            Parent = parent; // Asigamos el padre si lo hay.
            Childs = new(); // Inicializamos la lista de Hijos.
        }

        public void Add(Node child){
            Childs.Add(child);
            child.Parent = this;
        }

        public string GetTree(){
            string result = "";
            if(Parent != null){
                result += $"{Parent.GetTree()} > ";
            }
            result += Data;
            return result;
        }
    }


}