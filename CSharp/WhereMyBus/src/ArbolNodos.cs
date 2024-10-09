using System.Collections.Generic;
namespace WhereBus{
    
    public class ArbolNodos
    {
        public List<CicloBusqueda> CiclosDeBusqueda;
        public CicloBusqueda currentCycle;

        public ArbolNodos()
        {
            CiclosDeBusqueda = new List<CicloBusqueda>();
            currentCycle = new CicloBusqueda();
            CiclosDeBusqueda.Add(currentCycle);
        }
        public void NewCicle(){
                CiclosDeBusqueda.Add(new CicloBusqueda());
        }
        public void AddNodeToCicle(Nodo node)
        {
            CiclosDeBusqueda[CiclosDeBusqueda.Count - 1].AddNode(node);
        }
        public bool ExistElement(IElementoRuta value){
            for (int i = 0; i < CiclosDeBusqueda.Count; i++){
                var ciclo = CiclosDeBusqueda[i];
                foreach(var Nodo in ciclo.Nodos){
                    if(Nodo.Elemento.GetNombre() == value.GetNombre()){
                        return true;
                    }
                }
            }
            return false;
        }
        public void NextCycle(){
            currentCycle = CiclosDeBusqueda[CiclosDeBusqueda.Count - 1];
        }
        
    }
    public class CicloBusqueda{
        public List<Nodo> Nodos;

        public CicloBusqueda()
        {
            Nodos = new List<Nodo>();
        }

        public void AddNode( Nodo nodo){
            Nodos.Add(nodo);
        }
    }

}